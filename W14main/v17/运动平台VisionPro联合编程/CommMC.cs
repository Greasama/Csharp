using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro.ApplicationWizard.Implementation.Internal;
using gts;

namespace 相机机械臂VisionPro联合编程
{
    //通过函数GetAxisStatus取得轴状态，状态信息存在TAxisStatus中
    public struct TAxisStatus
    {
        public short sRtn;                            // 读轴状态是否成功 0代表成功
        public bool b1Alarm;                          //标志_伺服报警
        public bool b4PosFlowError;                   //标志_跟随误差超限
        public bool b5Trig_PosLmt;                    //标志_触发_正限位
        public bool b6Trig_NegLmt;                    //标志_触发_负限位
        public bool b7Trig_SmoothStop;                //标志_触发_缓慢停止
        public bool b8Trig_AbruptStop;                //标志_触发_急速停止
        public bool b9AxisOn;                         //标志_轴上伺服
        public bool b10ProfileMoving;                 //标志_轴规划_运动中
        public bool b11MotorCompleteMotion;           //标志_电机位置到达
    }
    //运动卡的全局参数
    public static class GlobalVarAndFunc
    {
        public const string cst_default_GTS800_Cfg_FileName = "GT800_test.cfg";   //GTS配置文件
        public const int cst_MaxAxisNum = 4;//轴的数量
    }

    //轴的参数
    public class AxisParam
    {
        public int Start=0;        //开始位置
        public int End = 1000000; //最大脉冲数
        public double MaxVel=50;//轴最大速度
        public double Vel=30;//轴理想速度
        public double Distance;//轴距离，豪米做单位
        public double uCount;//每豪米的脉冲数，End=Distance*uCount

        public double GetLength(int pos)
        {
            if (uCount == 0)
                return -1;
            return pos / uCount;
        }
        public void Load()
        {
            End=MyApp.GetValueAsInt(name + "最大脉冲数");
            MaxVel = MyApp.GetValueAsInt(name + "最大速度",50);
            Vel = MyApp.GetValueAsInt(name + "理想速度",30);
            Distance = MyApp.GetValueAsInt(name + "距离");
            uCount = 1000;
            if (Distance!=0)
               uCount = End / Distance;//每豪米的脉冲数
        }
        public void Save()
        {
            if (Distance != 0)
                uCount = End / Distance;//每豪米的脉冲数
            MyApp.SetValue(name + "最大脉冲数", End.ToString());
            MyApp.SetValue(name + "最大速度", MaxVel.ToString());
            MyApp.SetValue(name + "理想速度", Vel.ToString());
            MyApp.SetValue(name + "距离", Distance.ToString());
        }
        public string name;
    }
    public class MCCard
    {

        public AxisParam[] axisParam = new AxisParam[3];//轴数据数组
        public int EndX    //X轴最大脉冲数
        {
            get { return axisParam[0].End; }
            set { axisParam[0].End = value; }
        }
        public int EndY  //Y轴最大脉冲数
        {
            get { return axisParam[1].End; }
            set { axisParam[1].End = value; }
        }
        public int EndZ  //Z轴最大脉冲数
        {
            get { return axisParam[2].End; }
            set { axisParam[2].End = value; }
        }
        public bool bCardOpenOK;//运行卡是否打开
        bool 已做回归零点 = false;
        public MCCard()                                                                     //public构建函数
        {
            bCardOpenOK = false;                                                           //私有字段赋初值 
            axisParam[0]=  new AxisParam();//x轴数组对象
            axisParam[0].name = "X轴";
            axisParam[1] = new AxisParam();//y轴数组对象
            axisParam[1].name = "Y轴";
            axisParam[2] = new AxisParam();//z轴数组对象
            axisParam[2].name = "Z轴";

            axisParam[0].Load();
            axisParam[1].Load();
            axisParam[2].Load();
        }
        public void Save()
        {
            axisParam[0].Save();
            axisParam[1].Save();
            axisParam[2].Save();
        }
        //取得XYZ轴的脉冲位置
        public bool GetCurrentRobotPose(out double x, out double y, out double z)
        {
            if (!bCardOpenOK)
            {
                x = 0; y = 0; z = 0;
                return false;
            }
            int posx, posy, posz;
            gts.mc.GT_GetPos(1, out posx);
            gts.mc.GT_GetPos(2, out posy);
            gts.mc.GT_GetPos(3, out posz);
            x = posx;
            y = posy;
            z = posz;
            return true;
        }
        //称动到XYZ轴的脉冲位置上，不等待动动停止
        public bool MoveXYZ(double X, double Y, double Z)
        {
            MoveAbsolute(1, (int)X, axisParam[0].Vel);
            MoveAbsolute(2, (int)Y, axisParam[1].Vel);
            MoveAbsolute(3, (int)Z, axisParam[2].Vel);
            return true;
        }
        //称动到XYZ轴的脉冲位置上，等待动动停止，轴是XYZ依次运动
        public bool MoveXYZWait2(double X, double Y, double Z)
        {
            MoveAbsoluteWait(1, (int)X, axisParam[0].Vel);
            MoveAbsoluteWait(2, (int)Y, axisParam[1].Vel);
            MoveAbsoluteWait(3, (int)Z, axisParam[2].Vel);
            return true;
        }
        //称动到XYZ轴的脉冲位置上，等待动动停止，轴是XYZ同时运动，但不考虑是否同时到达和直线运动
        public bool MoveXYZWait(double X, double Y, double Z)
        {
            MoveAbsolute(1, (int)X, axisParam[0].Vel);
            MoveAbsolute(2, (int)Y, axisParam[1].Vel);
            MoveAbsolute(3, (int)Z, axisParam[2].Vel);
            while (  GetAxisStatus(1).b10ProfileMoving
                  || GetAxisStatus(2).b10ProfileMoving
                  || GetAxisStatus(3).b10ProfileMoving
                )
            {
                Thread.Sleep(100);
            }
            return true;
        }
        
        //XYZ轴回归到负相位的位置，同时计算出XYZ轴最在脉冲数
        public bool 回归零点(bool redo=false)
        {
            if (已做回归零点& !redo)
                return true;
            已做回归零点 = true;
            for (short axis = 1; axis <= 3; axis++)
            {
                short sRtn = -1;                                                            // 指令返回值变量
                int lAxisStatus;                                                            // 轴状态
                uint clk;
                int d = 10000000;
                while (true)
                {
                    //向正方向走一厘米，50就是每秒5厘米  
                    MoveAbsoluteWait(axis, d, axisParam[axis-1].MaxVel);
                    sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);
                    if ((lAxisStatus & (1 << 5)) != 0)//正限位触发.则退出循环
                    {
                        break;
                    }

                }
                gts.mc.GT_ClrSts(axis, axis);
                gts.mc.GT_ZeroPos(axis, axis);
                while (true)
                {
                    //向负方向走一厘米，50就是每秒5厘米  
                    MoveAbsoluteWait(axis, -d, axisParam[axis - 1].MaxVel);
                    sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);
                    if ((lAxisStatus & (1 << 6)) != 0)//负限位触发.则退出循环
                    {
                        break;
                    }

                }
                int pos = 0;
                gts.mc.GT_GetPos(axis, out pos);
                if (axis == 1)
                    EndX = -pos;//总的脉冲
                if (axis == 2)
                    EndY = -pos;//总的脉冲
                if (axis == 3)
                    EndZ = -pos;//总的脉冲

            }
            gts.mc.GT_ClrSts(1, 4);
            gts.mc.GT_ZeroPos(1, 4);
            Save();
            return true;
        }

        //梯形运动数据？？？？？？？
        gts.mc.TTrapPrm trap = new gts.mc.TTrapPrm()                                          //梯形模式：给予默认参数
        {
            acc = 0.5,
            dec = 0.5,
            smoothTime = 0,
            velStart = 0
        };
        //初始运动控制卡、伺服使用能、
        public bool Open(string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)                                                                    //打开控制卡并初始化
        {
            //  sRtn += mc.GT_Close();                                            //关闭控制卡
            if (bCardOpenOK)
                return true;

            short sRtn = mc.GT_Open(0, 1);                                             //打开运动控制卡
            Thread.Sleep(300);
            sRtn += gts.mc.GT_Reset();                                            //复位控制卡
            sRtn += gts.mc.GT_LoadConfig(ConfigFileName);                         //下载配置文件,必须保证配置文件与设备完全符合，限位正常
            sRtn += gts.mc.GT_ClrSts(1, 8);                                       //清除各轴报警和限位
            for (short axis = 1; axis <= GlobalVarAndFunc.cst_MaxAxisNum; axis++)
            {
                sRtn += gts.mc.GT_PrfTrap(axis);//设定为点位运动模式
                sRtn += gts.mc.GT_SetTrapPrm(axis, ref trap);   //设置点位运动参数，在创建:trap时，已经赋值
                sRtn += gts.mc.GT_AxisOn(axis);                //轴上伺服
            }
            bCardOpenOK = (0 == sRtn);
            return bCardOpenOK;
        }
        public void Close()
        {
            mc.GT_Close();
            已做回归零点 = false;
        }
        public TAxisStatus GetAxisStatus(short axis)
        {
            TAxisStatus axisStatus = new TAxisStatus();
            axisStatus.sRtn = -1;                                                            // 指令返回值变量
            int lAxisStatus;                                                            // 轴状态
            uint clk;
            if (!bCardOpenOK) return axisStatus;
            axisStatus.sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);

            axisStatus.b1Alarm = (lAxisStatus & (1 << 1)) != 0;                 // 伺服报警标志       bit_1
            axisStatus.b4PosFlowError = (lAxisStatus & (1 << 4)) != 0;          // 跟随误差越限标志   bit_4
            axisStatus.b5Trig_PosLmt = (lAxisStatus & (1 << 5)) != 0;           // 正向限位           bit_5
            axisStatus.b6Trig_NegLmt = (lAxisStatus & (1 << 6)) != 0;           // 负向限位           bit_6
            axisStatus.b7Trig_SmoothStop = (lAxisStatus & (1 << 7)) != 0;       // 平滑停止           bit_7

            axisStatus.b8Trig_AbruptStop = (lAxisStatus & (1 << 8)) != 0;       //急停触发            bit_8
            axisStatus.b9AxisOn = (lAxisStatus & (1 << 9)) != 0;                // 伺服使能           bit_9
            axisStatus.b10ProfileMoving = (lAxisStatus & (1 << 10)) != 0;       // 规划运动中         bit_10
            axisStatus.b11MotorCompleteMotion = (lAxisStatus & (1 << 11)) != 0; // 电机位置到达       bit_11
            return axisStatus;
        }
        //移动到清零后的绝对位置
        public short MoveAbsolute(short axis, int pos, double vel, double acc = 0.1, double dec = 0.1, short smoothTime = 0, double velStart = 0)
        {
            short sRtn = 0;                                              // 指令返回值变量
            /* double[] num = new double[10];
             short myAxis = Convert.ToInt16(num[0]);
             int myPos = Convert.ToInt32(num[1]);
             double myVel = Convert.ToDouble(num[2]);*/

            if (axis < 1 || axis > 4)
            {
                return sRtn;
            }

            trap.acc = acc;
            trap.dec = dec;
            trap.smoothTime = smoothTime;
            trap.velStart = velStart;
            sRtn += gts.mc.GT_ClrSts(axis, 1);
            sRtn += gts.mc.GT_SetTrapPrm(axis, ref trap);
            sRtn += gts.mc.GT_ClrSts(axis, 1);                          //清除状态
            sRtn += gts.mc.GT_PrfTrap(axis);                            //梯形模式
            sRtn += gts.mc.GT_SetPos(axis, pos);                        //设置目标位置
            sRtn += gts.mc.GT_SetVel(axis, vel);                        //设置目标速度
            sRtn += gts.mc.GT_Update(1 << (axis - 1));                  //更新轴运动
                                                                        // Thread.Sleep(100);
            return sRtn;
        }
        //移动到清零后的绝对位置，停止后返回
        public short MoveAbsoluteWait(short axis, int pos, double vel, double acc = 0.1, double dec = 0.1, short smoothTime = 0, double velStart = 0)
        {
            short sRtn = 0;                                              // 指令返回值变量
            if (axis < 1 || axis > 4)
            {
                return sRtn;
            }
            trap.acc = acc;
            trap.dec = dec;
            trap.smoothTime = smoothTime;
            trap.velStart = velStart;
            sRtn += gts.mc.GT_ClrSts(axis, 1);
            sRtn += gts.mc.GT_SetTrapPrm(axis, ref trap);
            sRtn += gts.mc.GT_ClrSts(axis, 1);                          //清除状态
            sRtn += gts.mc.GT_PrfTrap(axis);                            //梯形模式
            sRtn += gts.mc.GT_SetPos(axis, pos);                        //设置目标位置
            sRtn += gts.mc.GT_SetVel(axis, vel);                        //设置目标速度
            sRtn += gts.mc.GT_Update(1 << (axis - 1));                  //更新轴运动
            while (GetAxisStatus(axis).b10ProfileMoving)
            {
                Thread.Sleep(100);
            }
            return sRtn;
        }
        public void OpenAirPump(bool isOpen)
        {

            if (isOpen)
            {
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, 1, 0); //气泵工作
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, 2, 1); //吸气
            }
            else
            {
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, 2, 0); //放气
                Thread.Sleep(1000);
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, 1, 1); //气泵不工作
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro.ApplicationWizard.Implementation.Internal;
using gts;
using 相机机械臂VisionPro联合编程.MccMode;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static gts.mc;

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
        public const string
            cst_default_GTS800_Cfg_FileName = "GTS800.cfg";   //GTS配置文件
        public const int cst_MaxAxisNum = 4;//轴的数量

        //电源和PWM控制端口
        public static short cstPower = 1;
        public static short cstPWM = 2;

        //输出控制常量
        public static short cstDoOn = 0;
        public static short cstDoOff = 1;
    }

    //轴的参数
    public class AxisParam
    {
        public int Start = 0;        //开始位置
        public int End = 1000000; //最大脉冲数
        public double MaxVel = 50;//轴最大速度
        public double Vel = 20;//轴理想速度
        public double Distance;//轴距离，豪米做单位
        public double uCount;//每豪米的脉冲数，End=Distance*uCount
        public short stage;//阶段标识，1表示处于Home搜索阶段，2表示处于Home回零阶段，3表示处于Index搜索阶段，4表示处于Index回零阶段

        public double GetLength(int pos)
        {
            if (uCount == 0)
                return -1;
            return pos / uCount;
        }
        //存取并初始化设置控制台参数
        public void Load()
        {
            End = MyApp.GetValueAsInt(name + "最大脉冲数");
            MaxVel = MyApp.GetValueAsInt(name + "最大速度", 50);
            Vel = MyApp.GetValueAsInt(name + "理想速度", 30);
            Distance = MyApp.GetValueAsInt(name + "距离");
            uCount = 1000;
            if (Distance != 0)
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
        public bool bStopPWMOut = false;                      //标识:脉冲输出

        public AxisParam[] axisParam = new AxisParam[3];      //轴数据数组

        public double[] encPosList = new double[11];          //编码器数组

        public int EndX                                       //X轴最大脉冲数
        {
            get { return axisParam[0].End; }
            set { axisParam[0].End = value; }
        }
        public int EndY                                       //Y轴最大脉冲数
        {
            get { return axisParam[1].End; }
            set { axisParam[1].End = value; }
        }
        public int EndZ                                       //Z轴最大脉冲数
        {
            get { return axisParam[2].End; }
            set { axisParam[2].End = value; }
        }
        public bool bCardOpenOK;                              //运行卡是否打开
        bool OverZero = false;
        public MCCard()                                       //public构建函数
        {
            bCardOpenOK = false;                              //私有字段赋初值,后续启动判定依据 
            axisParam[0] = new AxisParam();                   //x轴数组对象
            axisParam[0].name = "X轴";
            axisParam[1] = new AxisParam();                  //y轴数组对象
            axisParam[1].name = "Y轴";
            axisParam[2] = new AxisParam();                  //z轴数组对象
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
        //移动到XYZ轴的脉冲位置上，不等待前一轴运动停止
        public bool MoveXYZ(double X, double Y, double Z)
        {
            MoveAbsolute(1, (int)X, axisParam[0].Vel);
            MoveAbsolute(2, (int)Y, axisParam[1].Vel);
            MoveAbsolute(3, (int)Z, axisParam[2].Vel);
            return true;
        }
        //移动到XYZ轴的脉冲位置上，等待前一轴运动停止，轴是XYZ依次运动
        public bool MoveXYZWait2(double X, double Y, double Z)
        {
            MoveAbsoluteWait(1, (int)X, axisParam[0].Vel);
            MoveAbsoluteWait(2, (int)Y, axisParam[1].Vel);
            MoveAbsoluteWait(3, (int)Z, axisParam[2].Vel);
            return true;
        }
        //移动到XYZ轴的脉冲位置上，不等待前一轴运动停止，轴是XYZ同时运动，但不考虑是否同时到达和直线运动
        public bool MoveXYZWait(double X, double Y, double Z)
        {
            MoveAbsolute(1, (int)X, axisParam[0].Vel);
            MoveAbsolute(2, (int)Y, axisParam[1].Vel);
            MoveAbsolute(3, (int)Z, axisParam[2].Vel);
            while (GetAxisStatus(1).b10ProfileMoving
                  || GetAxisStatus(2).b10ProfileMoving
                  || GetAxisStatus(3).b10ProfileMoving
                )
            {
                Thread.Sleep(100);
            }
            return true;
        }

        public void ReturnZeroAb(bool bFlagNegLimit = false)
        {
            short sRtn = -1;               // 指令返回值变量
            int lAxisStatus;               // 轴状态
            uint clk;
            int search_home = 200000;

            int neg = -1000;
            int startFind = 0;
            //保险，到达负相位
            while (!bFlagNegLimit)
            {
                MoveAbsoluteWait(1, neg, axisParam[0].MaxVel);
                sRtn = gts.mc.GT_GetSts(1, out lAxisStatus, 1, out clk);
                if ((lAxisStatus & 0x40) != 0)
                {
                    bFlagNegLimit = true;
                }
                else
                {
                    neg -= 1000;
                }
            }
            bFlagNegLimit = false;
            MessageBox.Show("到达负限位");
            gts.mc.GT_ZeroPos(1, 1);   //位置清零
            //正向找第一个HOME
            sRtn += gts.mc.GT_SetCaptureMode(1, gts.mc.CAPTURE_HOME);
            short capture; int pos;
            sRtn += gts.mc.GT_GetCaptureStatus(1, out capture, out pos, 1, out clk);
            while (1 != capture)
            {
                startFind += 10000;
                if (startFind >= search_home)
                {
                    MessageBox.Show("没找到原点");
                    break;
                }
                MoveAbsolute(1, startFind, axisParam[0].MaxVel);

                WaitStop(1);

                gts.mc.GT_GetCaptureStatus(1, out capture, out pos, 1, out clk);
            }
            gts.mc.GT_Stop(1 << 0, 0);
            gts.mc.GT_GetCaptureStatus(1, out capture, out pos, 1, out clk);
            MessageBox.Show($"找到了home点,{capture}");

            //阶段标识
            short stage = 1;
        }

        public short WaitStop(short axis)
        {
            TAxisStatus axisStatus = GetAxisStatus(axis);

            while (axisStatus.b10ProfileMoving)
            {
                axisStatus = GetAxisStatus(axis);
                Application.DoEvents();
            }

            return 0;
        }

        public bool ReturnZero(bool redo = false)
        {
            if (OverZero & !redo)
                return true;
            OverZero = true;

            short sRtn = -1;                                // 指令返回值变量
            int lAxisStatus;                                // 轴状态
            uint clk;
            int d = 10000000;

            while (true)
            {
                //向正方向走一厘米，50就是每秒5厘米
                MoveAbsoluteWait(3, d, axisParam[2].MaxVel);
                sRtn = gts.mc.GT_GetSts(3, out lAxisStatus, 1, out clk);
                if ((lAxisStatus & (1 << 5)) != 0)//正限位触发.则退出循环
                {
                    break;
                }
            }

            // 创建事件用于同步线程
            ManualResetEvent axis1And2Finished = new ManualResetEvent(false);

            // 创建两个线程，分别处理1和2轴的运动
            Thread axis1Thread = new Thread(() =>
            {
                MoveAxis(1, d);
                axis1And2Finished.Set(); // 1轴运动完成后通知
            });
            Thread axis2Thread = new Thread(() =>
            {
                MoveAxis(2, d);
                axis1And2Finished.Set(); // 2轴运动完成后通知
            });
            // 启动1和2轴线程
            axis1Thread.Start();
            axis2Thread.Start();
            // 等待1和2轴线程完成
            axis1And2Finished.WaitOne();
            axis1And2Finished.WaitOne();
            // 创建3轴线程，处理3轴的运动
            Thread.Sleep(9000);
            Thread axis3Thread = new Thread(() =>
            {
                MoveAxis(3, d);
            });
            // 启动3轴线程
            axis3Thread.Start();
            axis3Thread.Join();

            // 清理和保存操作
            gts.mc.GT_ClrSts(1, 4);
            gts.mc.GT_ZeroPos(1, 4);
            gts.mc.GT_SetEncPos(9, 0);

            Save();
            return true;
        }

        // 用于移动指定轴的方法
        private void MoveAxis(short axis, int distance)
        {
            int lAxisStatus; // 轴状态
            uint clk;
            short sRtn;

            while (true)
            {
                // 向正方向移动一厘米，50表示每秒5厘米(采用理想速度20)
                MoveAbsoluteWait(axis, distance, axisParam[axis - 1].Vel);
                sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);
                if ((lAxisStatus & (1 << 5)) != 0)// 正限位触发，则退出循环
                {
                    break;
                }
            }

            gts.mc.GT_ClrSts(axis, axis);
            gts.mc.GT_ZeroPos(axis, axis);

            while (true)
            {
                // 向负方向移动一厘米，50表示每秒5厘米(采用理想速度20)
                MoveAbsoluteWait(axis, -distance, axisParam[axis - 1].Vel);
                sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);
                // 负限位触发，则退出循环
                if ((lAxisStatus & (1 << 6)) != 0)
                {
                    break;
                }
            }

            // 所有线程完成后获取位置信息
            int pos1, pos2, pos3;
            gts.mc.GT_GetPos(1, out pos1);
            gts.mc.GT_GetPos(2, out pos2);
            gts.mc.GT_GetPos(3, out pos3);
            if (axis == 1)
                EndX = -pos1;//总的脉冲
            if (axis == 2)
                EndY = -pos2;//总的脉冲
            if (axis == 3)
                EndZ = -pos3;//总的脉冲
        }



        gts.mc.TTrapPrm trap = new gts.mc.TTrapPrm()                //梯形模式：给予默认参数
        {
            acc = 0.5,
            dec = 0.5,
            smoothTime = 0,
            velStart = 0
        };

        gts.mc.TJogPrm Jtrap = new gts.mc.TJogPrm()
        {
            acc = 0.5,
            dec = 0.5,
            smooth = 0
        };

        gts.mc.TCrdPrm Ctrap = new gts.mc.TCrdPrm()
        {
            //坐标轴对应
            dimension = 3,
            profile1 = 1,
            profile2 = 2,
            profile3 = 3,
            //运动参数
            synVelMax = 500,
            synAccMax = 0.5,
            evenTime = 50,
            //坐标系原点
            setOriginFlag = 1,
            originPos1 = 100,
            originPos2 = 100,
            originPos3 = 100
        };

        //初始运动控制卡、伺服使能
        public bool Open
            (string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)                                                                    //打开控制卡并初始化
        {
            if (bCardOpenOK)
                return true;


            short sRtn = mc.GT_Open(0, 1);                        //打开运动控制卡
            Thread.Sleep(300);
            sRtn += gts.mc.GT_Reset();                            //复位控制卡
            sRtn += gts.mc.GT_LoadConfig(ConfigFileName);         //下载配置文件,必须保证配置文件与设备完全符合，限位正常
            sRtn += gts.mc.GT_ClrSts(1, 8);                       //清除各轴报警和限位
            for (short axis = 1; axis <= GlobalVarAndFunc.cst_MaxAxisNum; axis++)
            {
                sRtn += gts.mc.GT_PrfTrap(axis);                 //设定为点位运动模式
                sRtn += gts.mc.GT_SetTrapPrm(axis, ref trap);    //设置点位运动参数，在创建:trap时，已经赋值
                sRtn += gts.mc.GT_AxisOn(axis);                  //轴上伺服
            }                                                    //遍历轴输出点位模式
            bCardOpenOK = (0 == sRtn);
            return bCardOpenOK;
        }
        public void Close()
        {
            mc.GT_Close();
            OverZero = false;
        }
        public bool OpenJog
            (short axis, string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)
        {
            if (bCardOpenOK)
            {
                return true;
            }
            short sRtn = PresRtn;
            //for (short axis = 1; axis <= GlobalVarAndFunc.cst_MaxAxisNum; axis++)
            //{
            //    sRtn += gts.mc.GT_PrfJog(axis);                //设定为JOG运动模式
            //    sRtn += gts.mc.GT_SetJogPrm(axis, ref Jtrap);  //设置点位运动参数，在创建:Jtrap时，已经赋值
            //    sRtn += gts.mc.GT_AxisOn(axis);                //轴上伺服
            //}                                                  //所有轴遍历初始化
            sRtn += gts.mc.GT_PrfJog(axis);                      //设定为JOG运动模式
            sRtn += gts.mc.GT_SetJogPrm(axis, ref Jtrap);        //设置点位运动参数，在创建:Jtrap时，已经赋值
            sRtn += gts.mc.GT_AxisOn(axis);                      //轴上伺服
            return bCardOpenOK;
        }

        private short PresRtn = 0;
        public bool OpenGear
            (short axis, short AxisSlave,
            int masterEven, int slaveEven, int masterSlope,
            string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)
        {
            if (bCardOpenOK)
            {
                return true;
            }
            short sRtn = gts.mc.GT_ClrSts(1, 8);              //清除各轴报警和限位
            sRtn += gts.mc.GT_AlarmOn(axis);
            sRtn += gts.mc.GT_AlarmOn(AxisSlave);             //伺服使能
            //sRtn += gts.mc.GT_PrfJog(axis);                   //主轴设定为JOG模式 
            sRtn += gts.mc.GT_PrfGear(AxisSlave, 0);          //从动轴设定为Gear模式
            sRtn += gts.mc.GT_SetGearMaster(AxisSlave,
                axis, GEAR_MASTER_PROFILE, 0);                //设置主轴，默认跟随主轴规划位置
            sRtn += gts.mc.GT_SetGearRatio(AxisSlave,
                masterEven, slaveEven, masterSlope);          //设置从轴的传动比和离合区
            sRtn += GT_GearStart(1 << (AxisSlave - 1));       //启动从轴

            PresRtn = sRtn;
            return bCardOpenOK;
        }

        public bool CreatAxis
            (string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)
        {
            if (bCardOpenOK)
            {
                return true;
            }
            short sRtnAxis;
            sRtnAxis = gts.mc.GT_SetCrdPrm(1, ref Ctrap);
            return bCardOpenOK;
        }

        public bool OpenIn
    (string ConfigFileName = GlobalVarAndFunc.cst_default_GTS800_Cfg_FileName)
        {
            if (bCardOpenOK)
            {
                return true;
            }
            short sRtn = PresRtn;
            for (short axis = 1; axis <= GlobalVarAndFunc.cst_MaxAxisNum; axis++)
            {
                sRtn = gts.mc.GT_ClrSts(axis, GlobalVarAndFunc.cst_MaxAxisNum);//清除轴状态
                sRtn += gts.mc.GT_AxisOn(axis);                                //使能运动轴
            }
            return bCardOpenOK;
        }

        public TAxisStatus GetAxisStatus(short axis)           //uint对于传值非常重要
        {
            TAxisStatus axisStatus = new TAxisStatus();
            axisStatus.sRtn = -1;                              // 指令返回值变量
            int lAxisStatus;                                   // 轴状态
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

        public double GetEncPos()
        {
            uint clk;
            double enc;
            gts.mc.GT_GetEncPos(9, out enc, 1, out clk);//添加端口监控（光栅尺）,非数组写法
            return enc * 0.05;
            //gts.mc.GT_GetEncPos(9, out encPosList[8], 1, out clk);//数组写法，前端82排有数组定义
            //return encPosList[8] * 0.05;

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
        //编号1控制气泵，编号2控制电磁阀
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

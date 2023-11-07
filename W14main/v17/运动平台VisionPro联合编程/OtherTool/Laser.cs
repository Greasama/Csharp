using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 相机机械臂VisionPro联合编程.OtherTool
    //激光打印相关参数文件
{
    internal class Laser
    {
        int num = 0;//脉冲个数
        int LowTime = 0;//低电平
        int time;//周期时间
        int PWMNum;//总脉冲

        //计算低电平
        public void Cal(float precent)
        {
            int Busytime = 50;
            float frequency = 1000;

            frequency = frequency * precent / 100;
            if (frequency <= 4000)
            {
                num = Convert.ToInt32(100000 / frequency * Busytime / 100 / 25);//需要发送多少个低脉冲
                if (num == 0)
                {
                    num = 1;
                    Busytime = 50;//默认百分之50，输出一个正常的PWM波形
                }
                LowTime = num * 25;//低电平的时间
                time = (int)(LowTime * 100) / Busytime;  //总的一个周期的时间
                Busytime = (int)(LowTime * 100 / time);
            }
            PWMNum = 1000 / time;   //总共有多少个脉冲数
        }

        //I/O输出激光（打开关闭）
        public void laser_print(float precent)
        {
            if ((int)precent != 0)
            {
                Cal(precent);
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO,GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOn);
                gts.mc.GT_SetDoBitReverse(gts.mc.MC_GPO, GlobalVarAndFunc.cstPWM, GlobalVarAndFunc.cstDoOn, (short)num);
                int delay = time / 100;
                DateTime start;
                DateTime tempTime;
                TimeSpan timeSpan = TimeSpan.Zero;
                for (int i = 0; i < PWMNum; i++)
                {
                    gts.mc.GT_SetDoBitReverse(gts.mc.MC_GPO, GlobalVarAndFunc.cstPWM, 0, (short)(num));

                    start = DateTime.Now;
                    timeSpan = TimeSpan.Zero;

                    Application.DoEvents();
                    while (timeSpan.TotalMilliseconds < delay)
                    {
                        tempTime = DateTime.Now;
                        timeSpan = tempTime - start;
                        Application.DoEvents();
                    }
                    Application.DoEvents();
                }
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
            }
        }
    }
}

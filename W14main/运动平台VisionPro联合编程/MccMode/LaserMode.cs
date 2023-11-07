using AForge.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 相机机械臂VisionPro联合编程.MccMode
{
    public partial class LaserMode : Form
    {
        public LaserMode()
        {
            InitializeComponent();
            visionJob.myMCC = myMCC;
            visionJob.Load();
        }

        public MCCard myMCC = new MCCard();

        public VisionJob visionJob = new VisionJob();
        public VideoSourcePlayer vispShoot;

        // 定义变量
        private void btnDoPWM_Click(object sender, EventArgs e)
        {
            short iLowPulseTime = 0;       //低脉冲宽度
            short iCycleTime = 0;         //脉冲周期
            short iHighTime = 0;          //脉冲幅度
            int iPulseNumber = 0;         //脉冲个数
            uint reverseCount = 0;        //变化次数

            try
            {
                timer1.Stop(); // 停止计时器1
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOn); // 打开电源
                // 检查输入的低脉冲宽度、脉冲周期和脉冲个数是否为整数
                if (!short.TryParse(txtPWMLowWidth.Text, out iLowPulseTime))
                {
                    MessageBox.Show("请输入->低脉冲宽度->整数数值");
                }
                if (!short.TryParse(txtBoxCycleTime.Text, out iCycleTime))
                {
                    MessageBox.Show("请输入->脉冲周期->整数数值");
                }
                if (!int.TryParse(txtBoxPulseNum.Text, out iPulseNumber))
                {
                    MessageBox.Show("请输入->脉冲个数->整数数值");
                }
                // 设置低脉冲宽度和脉冲周期的值
                if (iLowPulseTime == 0)
                {
                    iLowPulseTime = 1;
                }
                if (iLowPulseTime == iCycleTime)
                {
                    iLowPulseTime = (short)(iCycleTime - 1);
                }
                if (iLowPulseTime > iCycleTime)
                {
                    short min = iCycleTime;      //min
                    iCycleTime = iLowPulseTime;  //max
                    iLowPulseTime = min;         //min   
                }
                txtPWMLowWidth.Text = iLowPulseTime.ToString();
                txtBoxCycleTime.Text = iCycleTime.ToString();
                // 计算脉冲幅度
                iHighTime = (short)Math.Abs(iCycleTime - iLowPulseTime);//数字信号的脉冲幅度运算
                int num = 0;
                myMCC.bStopPWMOut = false;
                DateTime start;
                DateTime tempTime;
                TimeSpan timeSpan = TimeSpan.Zero;//设定波形时间间隔
                gts.mc.GT_SetDiReverseCount(gts.mc.MC_GPI, 9, ref reverseCount, 1);
                // 循环发送脉冲
                do
                {
                    gts.mc.GT_SetDoBitReverse(gts.mc.MC_GPO, GlobalVarAndFunc.cstPWM, GlobalVarAndFunc.cstDoOn, (short)(iLowPulseTime * 4));

                    start = DateTime.Now;
                    timeSpan = TimeSpan.Zero;//波形时间间隔
                    // 等待脉冲周期结束,重置波形时间间隔
                    while (timeSpan.TotalMilliseconds < iCycleTime)
                    {
                        tempTime = DateTime.Now;
                        timeSpan = tempTime - start;
                        Application.DoEvents();
                    }
                    num++;
                    txtBoxHaveSendPulseNum.Text = num.ToString();

                    Application.DoEvents();//Application类申请访问的传递
                    gts.mc.GT_GetDiReverseCount(gts.mc.MC_GPI, 9, out reverseCount, 1);
                    reverseCount = reverseCount / 2;//取中输出
                    txtBoxInputCout.Text = reverseCount.ToString();
                    // 如果需要停止发送脉冲，跳出循环
                    if (myMCC.bStopPWMOut)
                        break;
                }
                while (num < iPulseNumber);
            }
            finally
            {
                // PWM关闭
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPWM, GlobalVarAndFunc.cstDoOn);
                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
                timer1.Start(); // 启动计时器1
                btnClosePWM.BackColor = Color.Yellow; // 设置按钮颜色为黄色
            }
        }

        private void btnClosePWM_Click(object sender, EventArgs e)//停止输出定时脉冲信号
        {
            myMCC.bStopPWMOut = true;
            Application.DoEvents();
            gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
        }

        private void btnOn_Click(object sender, EventArgs e)//使I/O输出定时脉冲信号
        {
            gts.mc.GT_SetDoBitReverse(gts.mc.MC_GPO, GlobalVarAndFunc.cstPWM, GlobalVarAndFunc.cstDoOn, (short)(100 * 4));
        }

        private void PowerOn_Click(object sender, EventArgs e)//打开I/O输出
        {
            gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOn);
        }

        private void PowerOff_Click(object sender, EventArgs e)//关闭I/O输出
        {
            gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
        }
    }
}

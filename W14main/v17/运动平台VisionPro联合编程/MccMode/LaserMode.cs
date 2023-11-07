using AForge.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using 相机机械臂VisionPro联合编程.OtherTool;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 相机机械臂VisionPro联合编程.MccMode
{
    struct PicUint
    {
        public int Width;
        public int Height;
    }
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

        PicUint PicUint;
        gts.mc.TTrapPrm trap;
        byte[,] IoValue;

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

        private void btnPicIn_Click(object sender, EventArgs e)
        {
            //string pic = "雕刻1.bmp";
            //pri.Image = Image.FromFile(pic);//打开图片
            //pri.SizeMode = PictureBoxSizeMode.Normal;//图片定位方式

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strPic = openFileDialog1.FileName;
                pri.Image = Image.FromFile(strPic);
            }//文件调用界面

            pri.SizeMode = PictureBoxSizeMode.AutoSize;
            PicUint = new PicUint();

            Bitmap bitmap = new Bitmap(pri.Image);//传入像素数据
            pri.Size = bitmap.Size;
            pri.Width = bitmap.Width;
            pri.Height = bitmap.Height;
            IoValue = new byte[bitmap.Width, bitmap.Height];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);//获取像素点RGB
                    IoValue[i, j] = (Byte)((color.R + color.G + color.B) / (3));//像素处理
                    if (IoValue[i, j] < 127)
                    {
                        IoValue[i, j] = 0;
                    }
                    else
                    {
                        IoValue[i, j] = 1;
                    }
                }
            }
            pri.Invalidate();//图像重新显示
        }

        private void btnPicRun_Click(object sender, EventArgs e)
        {

            // 创建一个Laser对象，用于激光打印
            Laser laser = new Laser();
            // 清除指定轴的状态，1表示轴号，8表示轴控制器号
            gts.mc.GT_ClrSts(1, 8);
            // 创建一个画笔，用于绘制扫描痕迹，颜色为绿色，线宽为4
            Pen pen1 = new Pen(Color.Green, 4);
            // 创建一个Graphics对象，用于绘制图像
            Graphics g = pri.CreateGraphics();
            // 调用laser_print方法，设置激光功率为100.00f
            laser.laser_print(100.00f);

            int preX;
            if (PicUint.Width < 2000)
            {
                // 如果图像宽度小于2000像素，设置preX
                preX = (int)(1000 / 2.2);
            }
            else
            {
                preX = 500;
            }
            int preY;
            if (PicUint.Height < 1000)
            {
                // 如果图像高度小于1000像素，设置preY
                preY = (int)(10000 / 72 / 2.2);
            }
            else
            {
                preY = 10000 / 72 / 2;
            }

            for (int j = 0; j < IoValue.GetLength(1); j++)
            {
                // 清除轴的状态，1表示轴号，8表示轴控制器号
                gts.mc.GT_ClrSts(1, 8);
                // 调用MoveAbsoluteWait方法，使第2轴移动到指定位置，preY * j表示移动距离，10表示速度
                myMCC.MoveAbsoluteWait(2, -(preY * j), 10);
                myMCC.WaitStop(2);

                for (int i = 0; i < IoValue.GetLength(0); i++)
                {
                    if ((i != 0 & (i != IoValue.GetLength(0) - 1)) & (j != 0 &
                        (j != IoValue.GetLength(1) - 1)))
                    {
                        if (IoValue[i, j - 1] > 0.5 & IoValue[i, j + 1] > 0.5 &
                            IoValue[i - 1, j] > 0.5 & IoValue[i + 1, j] > 0.5)
                        {
                            // 未执行任何操作
                        }
                        else
                        {
                            if (IoValue[i, j] > 0.5)
                            {
                                // 调用MoveAbsoluteWait方法，使第1轴移动到指定位置，preX * i表示移动距离，10表示速度
                                myMCC.MoveAbsoluteWait(1, preX * i, 10);
                                myMCC.WaitStop(1);
                                // 调用laser_print方法，开始激光打印
                                laser.laser_print(100.00f);
                                // 绘制痕迹线
                                g.DrawLine(pen1, i, j, i, j + 1);
                            }
                            else
                            {
                                // 设置某输出信号为关闭状态，关闭激光打印
                                gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
                            }
                        }
                    }
                    else if (IoValue[i, j] > 0.5)
                    {
                        // 调用MoveAbsoluteWait方法，使第1轴移动到指定位置，preX * i表示移动距离，50表示速度
                        myMCC.MoveAbsoluteWait(1, preX * i, 50);
                        // 开始激光打印
                        laser.laser_print(100.00f);
                        // 绘制痕迹线
                        g.DrawLine(pen1, i, j, i, j + 1);
                    }
                    else
                    {
                        // 设置某输出信号为关闭状态，关闭激光打印
                        gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);
                    }
                }
            }
            // 显示打印完成的消息框
            MessageBox.Show("打印完成");
            // Z轴上抬
            myMCC.MoveAbsoluteWait(3, 30000, 50);
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            gts.mc.GT_Stop(255, 0);
            gts.mc.GT_ClrSts(1, 8);
            gts.mc.GT_SetDoBit(gts.mc.MC_GPO, GlobalVarAndFunc.cstPower, GlobalVarAndFunc.cstDoOff);//关闭激光
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gts.mc.GT_CrdClear(1, 0);
            gts.mc.GT_CrdClear(2, 0);
        }

        private void btnAxis_Click(object sender, EventArgs e)
        {
            myMCC.CreatAxis();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            myMCC.OpenIn();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            myMCC.ReturnZero(true);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            long tempX; long tempY;
            if (long.TryParse(textX.Text, out tempX) && long.TryParse(textY.Text, out tempY))
            {
                //XY二维直线插补代码
                gts.mc.GT_CrdClear(1, 0);
                gts.mc.GT_LnXY(1, (int)tempX, (int)tempY, 20, 0.05, 0, 0);
                gts.mc.GT_BufIO(1, 12, 0XFFFF, 0X55, 0);
                gts.mc.GT_CrdStart(1, 0);
            }
            else
            {
                MessageBox.Show("参数输入错误!" +
    "\n请正确输入X轴，Y轴位置");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            double x = myMCC.GetPrfPos(1);
            this.textX.Text = Math.Round(x, 1).ToString();
            double y = myMCC.GetPrfPos(2);
            this.textY.Text = Math.Round(y, 1).ToString();
        }
    }
}

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

namespace 相机机械臂VisionPro联合编程.MccMode
{
    public partial class InterpolationMode : Form
    {
        public InterpolationMode()
        {
            InitializeComponent();
            visionJob.myMCC = myMCC;
            visionJob.Load();
        }
        public MCCard myMCC = new MCCard();
        public VisionJob visionJob = new VisionJob();
        public VideoSourcePlayer vispShoot;

        short axis;

        public short PresRtn;
        private void InterpolationMode_Load(object sender, EventArgs e)
        {
            btnZero.Enabled = false;
            btnAxis.Enabled = false;
            btnClear.Enabled = false;
            btnStop.Enabled = false;

            btnLineXY.Enabled = false;
            btnCircle.Enabled = false;
            btnZoneXYZ.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)//启动运动
        {
            myMCC.OpenIn();
            btnZero.Enabled = true;
            btnAxis.Enabled = true;
            btnClear.Enabled = true;
            btnStop.Enabled = true;
        }
        private void btnZero_Click(object sender, EventArgs e)//回归零点
        {
            myMCC.ReturnZero(true);
        }
        private void btnStop_Click(object sender, EventArgs e)//停止运动
        {
            for (int i = 1; i <= 4; ++i)
                gts.mc.GT_Stop(1 << (axis - 1), 0);
        }
        private void btnAxis_Click(object sender, EventArgs e)
        {
            myMCC.CreatAxis();
            btnLineXY.Enabled = true;
            btnCircle.Enabled = true;
            btnZoneXYZ.Enabled = true;
        }
        private void btnClear_Click(object sender, EventArgs e)//清除缓冲区
        {
            gts.mc.GT_CrdClear(1, 0);
            gts.mc.GT_CrdClear(2, 0);
        }
        private void btnLineXY_Click(object sender, EventArgs e)
        {
            long tempX; long tempY;
            if (long.TryParse(textBox1.Text, out tempX) && long.TryParse(textBox2.Text, out tempY))
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
    "\n请输入X轴，Y轴位移");
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            long tempXC; long tempYC;
            long Radius;
            long CenterX; long CenterY;
            if (long.TryParse(textBox4.Text, out tempXC) &&
                long.TryParse(textBox5.Text, out tempYC))
            {
                if (tempXC != 0 && tempYC != 0)
                {
                    if (long.TryParse(textBox1.Text, out CenterX) && long.TryParse(textBox2.Text, out CenterY))
                    {
                        if (CenterX != 0 && CenterY != 0)
                        {
                            // Use GT_ArcXYC
                            gts.mc.GT_CrdClear(1, 0);
                            gts.mc.GT_ArcXYC(1, (int)tempXC, (int)tempYC, CenterX, CenterY, 0, 20, 0.05, 0, 0);
                            gts.mc.GT_BufIO(1, 12, 0XFFFF, 0X55, 0);
                            gts.mc.GT_CrdStart(1, 0);
                        }
                        else
                        {
                            MessageBox.Show("参数选择错误!" +
                                "\n圆心描述请输入圆心到X轴位移，Y位移" +
                                "\n半径输入请输入圆弧半径");
                        }
                    }
                    else if (long.TryParse(textBox6.Text, out Radius))
                    {
                        if (Radius != 0)
                        {
                            // Use GT_ArcXYR
                            gts.mc.GT_CrdClear(1, 0);
                            gts.mc.GT_ArcXYR(1, (int)tempXC, (int)tempYC, Radius, 0, 20, 0.05, 0, 0);
                            gts.mc.GT_BufIO(1, 12, 0XFFFF, 0X55, 0);
                            gts.mc.GT_CrdStart(1, 0);
                        }
                        else
                        {
                            MessageBox.Show("参数选择错误!" +
                                "\n圆心描述请输入圆心到X轴位移，Y位移" +
                                "\n半径输入请输入圆弧半径");
                        }
                    }
                    else
                    {
                        MessageBox.Show("参数选择错误!" +
                            "\n圆心描述请输入圆心到X轴位移，Y位移" +
                            "\n半径输入请输入圆弧半径");
                    }
                }
                else
                {
                    MessageBox.Show("参数输入错误!" +
                        "\n请输入X轴，Y轴圆弧终点位置");
                }
            }
            else
            {
                MessageBox.Show("参数输入错误!" +
                    "\n请输入X轴，Y轴圆弧终点位置");
            }
        }

        private void btnZoneXYZ_Click(object sender, EventArgs e)
        {
            long tempX; long tempY; long tempZ;
            if (long.TryParse(textBox1.Text, out tempX) && long.TryParse(textBox2.Text, out tempY)
                && long.TryParse(textBox3.Text, out tempZ))
            {
                //三维直线插补代码
                gts.mc.GT_CrdClear(1, 0);
                gts.mc.GT_LnXYZ(1, (int)tempX, (int)tempY, (int)tempZ, 20, 0.05, 0, 0);
                gts.mc.GT_BufIO(1, 12, 0XFFFF, 0X55, 0);
                gts.mc.GT_CrdStart(1, 0);
            }
            else
            {
                MessageBox.Show("参数输入错误!" +
"\n请输入X轴，Y轴，Z轴位移");
            }
        }
    }
}

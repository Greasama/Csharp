using AForge.Controls;
using AForge.Video.DirectShow;
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
    public partial class JOGMode : Form
    {
        public JOGMode()
        {
            InitializeComponent();
            visionJob.myMCC = myMCC;
            visionJob.Load();
        }
        public MCCard myMCC = new MCCard();

        public VisionJob visionJob = new VisionJob();
        gts.mc.TJogPrm jog;
        double vel; short axis;
        public VideoSourcePlayer vispShoot;
        private void JOGMode_Load(object sender, EventArgs e)
        {
            // 添加轴序号到comboBox1
            for (int axisNumber = 1; axisNumber <= 3; axisNumber++)
            {
                comboBox1.Items.Add(axisNumber.ToString());
            }
            // 设置默认选择项
            comboBox1.SelectedIndex = 0; // 默认选择第一个轴
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            //复位过程的读取轴，涉及初始化不可调整
            myMCC.OpenJog(axis);
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            myMCC.ReturnZero(true);
        }

        private void btnPlus_MouseDown(object sender, MouseEventArgs e)
        {
            if (axis == 0)
            {
                // 处理axis未被初始化的情况
                MessageBox.Show("请先进行启动复位操作");
                return;
            }
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);//读取轴
            vel = Convert.ToDouble(this.textBox1.Text);
            jog.acc = Convert.ToDouble(this.textBox2.Text);
            jog.dec = Convert.ToDouble(this.textBox3.Text);
            gts.mc.GT_SetJogPrm(axis, ref jog);//jog运动参数
            gts.mc.GT_SetVel(axis, vel);//目标速度
            gts.mc.GT_Update(1 << (axis - 1));//更新轴运动
        }

        private void btnPlus_MouseUp(object sender, MouseEventArgs e)
        {
            gts.mc.GT_Stop(1 << (axis - 1), 0);
        }

        private void btnDecrease_MouseDown(object sender, MouseEventArgs e)
        {
            if (axis == 0)
            {
                // 处理axis未被初始化的情况
                MessageBox.Show("请先进行启动复位操作");
                return;
            }
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);//读取轴
            vel = Convert.ToDouble(this.textBox1.Text);
            jog.acc = Convert.ToDouble(this.textBox2.Text);
            jog.dec = Convert.ToDouble(this.textBox3.Text);
            gts.mc.GT_SetJogPrm(axis, ref jog);//jog运动参数
            gts.mc.GT_SetVel(axis, (-vel));//目标速度
            gts.mc.GT_Update(1 << (axis - 1));//更新轴运动
        }

        private void btnDecrease_MouseUp(object sender, MouseEventArgs e)
        {
            gts.mc.GT_Stop(1 << (axis - 1), 0);
        }

    }
}
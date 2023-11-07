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
using 相机机械臂VisionPro联合编程.MccCard;

namespace 相机机械臂VisionPro联合编程.MccMode
{
    public partial class GearMode : Form
    {
        public GearMode()
        {
            InitializeComponent();
            visionJob.myMCC = myMCC;
            visionJob.Load();
        }
        public MCCard myMCC = new MCCard();
        public VisionJob visionJob = new VisionJob();
        public VideoSourcePlayer vispShoot;

        short axis;short AxisSlave;
        int masterEven;int slaveEven;int masterSlope;

        public short PresRtn;

        private void GearMode_Load(object sender, EventArgs e)
        {
            // 添加轴序号到comboBox1,comboBox2
            for (int axisNumber = 1; axisNumber <= 3; axisNumber++)
            {
                comboBox1.Items.Add(axisNumber.ToString());
                comboBox2.Items.Add(axisNumber.ToString());
            }
            // 设置默认选择项
            comboBox1.SelectedIndex = 0; // 默认选择第一个轴为主动轴
            comboBox2.SelectedIndex = 1; // 默认选择第二个轴为从动轴
        }
        private void btnGear_Click(object sender, EventArgs e)
        {
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            AxisSlave = Convert.ToInt16(this.comboBox2.SelectedIndex + 1);
            masterEven = Convert.ToInt16(this.textBox2.Text);
            slaveEven = Convert.ToInt16(this.textBox3.Text);
            masterSlope = Convert.ToInt16(this.textBox1.Text);
            //复位过程的读取参数

            myMCC.OpenGear(axis, AxisSlave, masterEven, slaveEven, masterSlope);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            gts.mc.GT_Stop(255, 0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 相机机械臂VisionPro联合编程
{
    public partial class MainForm : Form
    {
        public MCCard myMCC = new MCCard();
        public VisionJob visionJob= new VisionJob(); 
        public MainForm()
        {
            InitializeComponent();
            visionJob.myMCC = myMCC;
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            CalibrationForm form = new CalibrationForm();
            form.myMCC= myMCC;
            form.visionJob =visionJob;
            form.ShowDialog();

        }

        private void btnJobStart_Click(object sender, EventArgs e)
        {
            visionJob.Run();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (myMCC.Open())
            {
                btnMCC.Enabled = false;
              //  if (videoDeviceIsOpen && armIsOpen)
                {
                    btnCalibration.Enabled = true;
                    btnJobStart.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("打开运动控制卡失败！");
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            myMCC.回归零点(true);
        }
    }
}

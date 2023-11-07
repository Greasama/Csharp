using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 相机机械臂VisionPro联合编程
{
    public partial class MCCardSetupForm : Form
    {
        public MCCard myMCC;
        public MCCardSetupForm()
        {
            InitializeComponent();
        }

        private void MCCardSetupForm_Load(object sender, EventArgs e)
        {
            textBoxEndX.Text = myMCC.EndX.ToString();
            textBoxMaxVelX.Text = myMCC.axisParam[0].MaxVel.ToString();
            textBoxVelX.Text = myMCC.axisParam[0].Vel.ToString();
            textBoxDistanceX.Text = myMCC.axisParam[0].Distance.ToString();

            textBoxEndY.Text = myMCC.EndY.ToString();
            textBoxMaxVelY.Text = myMCC.axisParam[1].MaxVel.ToString();
            textBoxVelY.Text = myMCC.axisParam[1].Vel.ToString();
            textBoxDistanceY.Text = myMCC.axisParam[1].Distance.ToString();

            textBoxEndZ.Text = myMCC.EndZ.ToString();
            textBoxMaxVelZ.Text = myMCC.axisParam[2].MaxVel.ToString();
            textBoxVelZ.Text = myMCC.axisParam[2].Vel.ToString();
            textBoxDistanceZ.Text = myMCC.axisParam[2].Distance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxMaxVelX.Text,out myMCC.axisParam[0].MaxVel);
            double.TryParse(textBoxVelX.Text, out myMCC.axisParam[0].Vel);
            double.TryParse(textBoxDistanceX.Text, out myMCC.axisParam[0].Distance);

            double.TryParse(textBoxMaxVelY.Text, out myMCC.axisParam[1].MaxVel);
            double.TryParse(textBoxVelY.Text, out myMCC.axisParam[1].Vel);
            double.TryParse(textBoxDistanceY.Text, out myMCC.axisParam[1].Distance);

            double.TryParse(textBoxMaxVelZ.Text, out myMCC.axisParam[2].MaxVel);
            double.TryParse(textBoxVelZ.Text, out myMCC.axisParam[2].Vel);
            double.TryParse(textBoxDistanceZ.Text, out myMCC.axisParam[2].Distance);

            myMCC.Save();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

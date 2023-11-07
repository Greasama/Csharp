using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cognex.VisionPro.CalibFix;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 相机机械臂VisionPro联合编程
{
    public partial class CalibrationForm : Form
    {
        public CalibrationForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }
        public MCCard myMCC;
        public VisionJob visionJob;
        public void GetState()
        {
            double x; double y; double z;
            if (myMCC.GetCurrentRobotPose(out x, out y, out z))
            {
                textBoxX.Text = x.ToString();
                textBoxY.Text = y.ToString();
                textBoxZ.Text = z.ToString();
                labelX.Text = myMCC.axisParam[0].GetLength((int)x).ToString("#0.0");
                labelY.Text = myMCC.axisParam[1].GetLength((int)x).ToString("#0.0");
                labelZ.Text = myMCC.axisParam[2].GetLength((int)x).ToString("#0.0");
                try
                {
                    hScrollBarX.Value = (int)x;
                    hScrollBarY.Value = (int)y;
                    hScrollBarZ.Value = (int)z;
                }
                catch
                { }
            }
            else
            {
                labelX.Text = "0.0";
                labelY.Text = "0.0";
                labelZ.Text = "0.0";
            }
        }
        private void hScrollBarX_Scroll(object sender, ScrollEventArgs e)
        {
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
            textBoxY.Text = hScrollBarY.Value.ToString();
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }
        const int posCount = 1000;
        private void button15_Click(object sender, EventArgs e)
        {
            if (hScrollBarX.Value + posCount > hScrollBarX.Maximum)
            {
                return;
            }
            hScrollBarX.Value+= posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (hScrollBarX.Value - posCount < hScrollBarX.Minimum)
            {
                return;
            }
            hScrollBarX.Value -= posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (hScrollBarY.Value + posCount > hScrollBarY.Maximum)
            {
                return;
            }
            hScrollBarY.Value += posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxY.Text = hScrollBarY.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hScrollBarY.Value - posCount < hScrollBarY.Minimum)
            {
                return;
            }
            hScrollBarY.Value -= posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxY.Text = hScrollBarY.Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (hScrollBarZ.Value + posCount > hScrollBarZ.Maximum)
            {
                return;
            }
            hScrollBarZ.Value += posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hScrollBarZ.Value - posCount < hScrollBarZ.Minimum)
            {
                return;
            }
            hScrollBarZ.Value -= posCount;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            myMCC.MoveXYZWait(x, y, z);
            GetState();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myMCC.回归零点(true);
            hScrollBarX.Minimum = 0;
            hScrollBarX.Maximum = (int)myMCC.EndX;

            hScrollBarY.Minimum = 0;
            hScrollBarY.Maximum = (int)myMCC.EndY;

            hScrollBarZ.Minimum =0;
            hScrollBarZ.Maximum = (int)myMCC.EndZ;
            GetState();
        }

//13138，3368
//13138，19562
//129157，19562
//129157，3368
        private void button6_Click(object sender, EventArgs e)
        {
            int x1 = 13138, y1 = 3368,
                x2 = 13138, y2 = 19562, 
                x3 = 129157, y3 = 19562, 
                x4 = 129157, y4 = 3368;
            myMCC.MoveXYZWait(x1, y1, 0);
            Thread.Sleep(1000);
            myMCC.MoveXYZWait(x2, y2, 0);
            Thread.Sleep(1000);
            myMCC.MoveXYZWait(x3, y3, 0);
            Thread.Sleep(1000);
            myMCC.MoveXYZWait(x4, y4, 0);
            Thread.Sleep(1000);
            myMCC.MoveXYZWait(x1, y1, 0);
            Thread.Sleep(1000);
            myMCC.MoveXYZWait(0, 0, 0);
            GetState();
        }
        private void CalibrationForm_Shown(object sender, EventArgs e)
        {
            hScrollBarX.Maximum = (int)myMCC.EndX;

            hScrollBarY.Maximum = (int)myMCC.EndY ;

            hScrollBarZ.Maximum = (int)myMCC.EndZ ;

            GetState();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value=0;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hScrollBarY.Value = 0;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value = 0;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value = myMCC.EndX;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            hScrollBarY.Value = myMCC.EndY;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value = myMCC.EndZ;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            MCCardSetupForm form = new MCCardSetupForm();
            form.myMCC = myMCC;
            if(form.ShowDialog()==DialogResult.OK) 
            {
                //?
            }
        }
        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            int V = 0;
            int.TryParse(textBoxX.Text, out V);
            labelX.Text = myMCC.axisParam[0].GetLength(V).ToString("#0.0");
        }
        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            int V = 0;
            int.TryParse(textBoxY.Text, out V);
            labelY.Text = myMCC.axisParam[1].GetLength(V).ToString("#0.0");
        }
        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {
            int V = 0;
            int.TryParse(textBoxZ.Text, out V);
            labelZ.Text = myMCC.axisParam[2].GetLength(V).ToString("#0.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

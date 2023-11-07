using AForge.Controls;
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
        public VideoSourcePlayer vispShoot;
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
                hScrollBarX.Value = (int)x;
                hScrollBarY.Value = (int)y;
                hScrollBarZ.Value = (int)z;
            }
        }
        public void init()
        {
            GetState();
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }
        public void RunVPP()
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            string VppFile = Application.StartupPath + "\\多点定位.vpp";
            CogJobManager CogJobManager1 = (CogJobManager)CogSerializer.LoadObjectFromFile(VppFile);
            CogToolGroup CogToolGroup1 = CogJobManager1.Job(0).VisionTool as CogToolGroup;//获取job中的工
            CogImageConvertTool CogImageConvertTool1 = (CogImageConvertTool)CogToolGroup1.Tools["CogImageConvertTool1"];
            CogPMAlignTool CogPMAlignTool1 = (CogPMAlignTool)CogToolGroup1.Tools["CogPMAlignTool1"];
            CogImageConvertTool1.InputImage = new CogImage8Grey(img);
            CogToolGroup1.Run();

            dataGridView1.Rows.Clear();//删除网络所有行
            if (CogPMAlignTool1.Results.Count >= 5)
            {
                for (int i = 0; i < CogPMAlignTool1.Results.Count; i++)
                {
                    CogTransform2DLinear linear = CogPMAlignTool1.Results[i].GetPose();
                    string str = string.Format("第{0}点", i + 1);
                    string strx = linear.TranslationX.ToString("#0.00");
                    string stry = linear.TranslationY.ToString("#0.00");
                    dataGridView1.Rows.Add(str, strx, stry, 0, 0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunVPP();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            int index = dataGridView1.SelectedCells[0].RowIndex;
            if (index != -1)
            {
                string strx = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
                string stry = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                Pen pen = new Pen(Color.Green, 5);
                double x ;
                if (!double.TryParse(strx, out x))
                {
                    return ;
                }
                double y;
                if (!double.TryParse(stry, out y))
                {
                    return;
                }
                int picx = (int)((double)pictureBox1.Width / pictureBox1.Image.Width * x);
                int picy = (int)((double)pictureBox1.Height / pictureBox1.Image.Height * y);
                Rectangle rect = new Rectangle(picx - 15, picy - 15, 30, 30);
                e.Graphics.DrawEllipse(pen, rect);

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void hScrollBarX_Scroll(object sender, ScrollEventArgs e)
        {
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
            textBoxY.Text = hScrollBarY.Value.ToString();
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }
        const int posCount = 100;
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
            hScrollBarX.Value--;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (hScrollBarY.Value + posCount > hScrollBarY.Maximum)
            {
                return;
            }
            hScrollBarY.Value++;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxY.Text = hScrollBarY.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hScrollBarY.Value - posCount < hScrollBarY.Minimum)
            {
                return;
            }
            hScrollBarY.Value--;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxY.Text = hScrollBarY.Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (hScrollBarZ.Value + posCount > hScrollBarZ.Maximum)
            {
                return;
            }
            hScrollBarZ.Value++;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hScrollBarZ.Value - posCount < hScrollBarZ.Minimum)
            {
                return;
            }
            hScrollBarZ.Value--;
            myMCC.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            myMCC.MoveXYZ(x, y, z);
            hScrollBarX.Value = (int)x;
            hScrollBarY.Value = (int)y;
            hScrollBarZ.Value = (int)z;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            int Rowindex = dataGridView1.SelectedCells[0].RowIndex;
            if (Rowindex != -1)
            {
                GetState();
                dataGridView1.Rows[Rowindex].Cells[3].Value = hScrollBarX.Value;
                dataGridView1.Rows[Rowindex].Cells[4].Value = hScrollBarY.Value;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myMCC.回归零点();
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

        private void button23_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string pix_x_str = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    double x1;
                    if (!double.TryParse(pix_x_str, out x1))
                    {
                        continue;
                    }
                    string pix_y_str = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    string armx_str = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    string army_str = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    str += pix_x_str + "," + pix_y_str + "," + armx_str + "," + army_str + "\n";
                }
                File.WriteAllText(saveFileDialog1.FileName, str);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = File.ReadAllText(openFileDialog1.FileName);
                string[] lines = str.Split('\n');
                dataGridView1.Rows.Clear();
                foreach (string line in lines)
                {
                    string[] cells = line.Split(',');
                    if (cells.Length >= 4)
                    {
                        int row = dataGridView1.Rows.Add();
                        string temp = string.Format("第{0}点", row + 1);
                        dataGridView1.Rows[row].Cells[0].Value = temp;
                        dataGridView1.Rows[row].Cells[1].Value = cells[0];
                        dataGridView1.Rows[row].Cells[2].Value = cells[1];
                        dataGridView1.Rows[row].Cells[3].Value = cells[2];
                        dataGridView1.Rows[row].Cells[4].Value = cells[3];
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CogFixtureNPointToNPointTool tool = new CogFixtureNPointToNPointTool();
            for (int i = tool.RunParams.NumPoints - 1; i >= 0; i--)
            {
                tool.RunParams.DeletePointPair(i);
            }
            tool.RunParams.DOFsToCompute = CogNPointToNPointDOFConstants.ScalingAspectRotationSkewAndTranslation;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double x1, y1, x2, y2;
                string strx1 = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                string stry1 = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                string strx2 = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                string stry2 = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                if (!double.TryParse(strx1, out x1))
                {
                    continue;
                }
                if (!double.TryParse(stry1, out y1))
                {
                    continue;
                }
                if (!double.TryParse(strx2, out x2))
                {
                    continue;
                }
                if (!double.TryParse(stry2, out y2))
                {
                    continue;
                }
                tool.RunParams.AddPointPair(x1, y1, x2, y2);
            }
            Bitmap img = new Bitmap(pictureBox1.Image);
            tool.InputImage = new CogImage8Grey(img);
            tool.Run();
            if (tool.Result == null || tool.Result.OutputImage==null)
            {
                MessageBox.Show("转换失败！");
                return;
            }
            ICogImage OutputImage = tool.Result.OutputImage;
            visionJob.form2D1=
                (CogTransform2DLinear)OutputImage.GetTransform
                (OutputImage.SelectedSpaceName, "@");

            visionJob.Save();//保存到配置文件中

            AddStr("平移X=" + visionJob.form2D1.TranslationX.ToString());
            AddStr("平移Y=" + visionJob.form2D1.TranslationY.ToString());
            AddStr("旋转=" + visionJob.form2D1.Rotation.ToString());
            AddStr("缩放=" + visionJob.form2D1.Scaling);
            AddStr("横纵比=" + visionJob.form2D1.Aspect);
            AddStr("倾斜=" + visionJob.form2D1.Skew);
        }
        public void AddStr(string str)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = str;
            }
            else
            {
                richTextBox1.Text += "\r\n" + str;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {

                if (dataGridView1.SelectedCells.Count == 0)
                {
                    return;
                }
                int Rowindex = dataGridView1.SelectedCells[0].RowIndex;
                if (Rowindex != -1)
                {
                    int x1, y1;
                    x1 = (int)((double)pictureBox1.Image.Width / pictureBox1.Width * e.X);
                    y1 = (int)((double)pictureBox1.Image.Height / pictureBox1.Height * e.Y);
                    dataGridView1.Rows[Rowindex].Cells[1].Value = x1;
                    dataGridView1.Rows[Rowindex].Cells[2].Value = y1;
                }
            }
            else
            {
                double x1, y1, x2, y2;
                x1 = (int)((double)pictureBox1.Image.Width / pictureBox1.Width * e.X);
                y1 = (int)((double)pictureBox1.Image.Height / pictureBox1.Height * e.Y);
                visionJob.form2D1.MapPoint(x1, y1, out x2, out y2);//图像坐标转机械坐标
                myMCC.MoveXYZWait(0,0, myMCC.EndZ/2);
                myMCC.MoveXYZ(x2, y2, myMCC.EndZ / 2);
                myMCC.MoveXYZ(x2, y2, 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            int rowindex= dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            double x1, y1, x2, y2;
            x1 = (double)pictureBox1.Image.Width / pictureBox1.Width * e.X;
            y1 = (double)pictureBox1.Image.Height / pictureBox1.Height * e.Y;
            visionJob.form2D1.MapPoint(x1, y1, out x2, out y2);//图像坐标转机械坐标
            string str = string.Format("图像坐标:{0},{1}  机械坐标: {2},{3}",
                      (int)x1, (int)y1, (int)x2, (int)y2);
            label4.Text = str;
        }

        private void CalibrationForm_Shown(object sender, EventArgs e)
        {
            hScrollBarX.Maximum = (int)myMCC.EndX;

            hScrollBarY.Maximum = (int)myMCC.EndY ;

            hScrollBarZ.Maximum = (int)myMCC.EndZ ;
        }
    }
    

}

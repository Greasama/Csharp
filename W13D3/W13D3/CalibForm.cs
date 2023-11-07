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
using Cognex.VisionPro.CalibFix;
using System.Runtime.InteropServices.ComTypes;
using System.IO;

namespace W13D3
{
    public partial class CalibForm : Form
    {
        public VideoSourcePlayer vispShoot;
        public CRobotArm CRobotArm1;
        public VisionJob visionJob;
        public CalibForm()
        {
            InitializeComponent();
        }
        public void init()
        {
            GetState();
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }
        public void GetState()
        {
            float x; float y; float z;
            if (CRobotArm1.GetCurrentRobotPose(out x, out y, out z))
            {
                textBoxX.Text = x.ToString();
                textBoxY.Text = y.ToString();
                textBoxZ.Text = z.ToString();
                hScrollBarX.Value = (int)x;
                hScrollBarY.Value = (int)y;
                hScrollBarZ.Value = (int)z;
            }
        }

        private void btnCut2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }

        public void RunVPP()
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            string VppFile = Application.StartupPath + "\\多点定位.vpp";
            CogJobManager CogJobManager1 = (CogJobManager)CogSerializer.LoadObjectFromFile(VppFile);
            CogToolGroup CogToolGroup1 = CogJobManager1.Job(0).VisionTool as CogToolGroup;
            //获取job中的工
            CogImageConvertTool CogImageConvertTool1 = (CogImageConvertTool)CogToolGroup1.Tools["CogImageConvertTool1"];
            CogPMAlignTool CogPMAlignTool1 = (CogPMAlignTool)CogToolGroup1.Tools["CogPMAlignTool1"];
            CogImageConvertTool1.InputImage = new CogImage8Grey(img);
            CogToolGroup1.Run();
            dataGridView1.Rows.Clear();
            //删除网格所有行
            if (CogPMAlignTool1.Results.Count >= 5)
            {
                for (int i = 0; i < CogPMAlignTool1.Results.Count; i++)
                {
                    CogTransform2DLinear linear = CogPMAlignTool1.Results[i].GetPose();
                    //本身就是个转换类（因为图像本身就有转换）
                    string str = string.Format("第{0}点", i + 1);
                    string strx = linear.TranslationX.ToString("#0.00");
                    //转string保留两位小数
                    string stry = linear.TranslationY.ToString("#0.00");
                    dataGridView1.Rows.Add(str, strx, stry, 0, 0);
                }
            }
        }

        private void btnGetXY_Click(object sender, EventArgs e)
        {

            //CalibNPointToNPointForm form = new CalibNPointToNPointForm();
            //form.ShowDialog();
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
                double x;
                if (!double.TryParse(strx, out x))
                {
                    return;
                }
                double y;
                if (!double.TryParse(stry, out y))
                {
                    return;
                }
                //取得坐标
                int picx = (int)((double)pictureBox1.Width / pictureBox1.Image.Width * x);
                int picy = (int)((double)pictureBox1.Height / pictureBox1.Image.Height * y);
                //图像坐标按照比例转换（缩放）
                Rectangle rect = new Rectangle(picx - 15, picy - 15, 30, 30);
                e.Graphics.DrawEllipse(pen, rect);

            }
            //DrawLine(pen,0, 0, 100, 100);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            //刷新
        }

        private void hScrollBarX_Scroll(object sender, ScrollEventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value++;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value--;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hScrollBarY.Value++;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hScrollBarY.Value--;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value++;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value--;
            CRobotArm1.MoveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            CRobotArm1.MoveXYZ(x, y, z);
            hScrollBarX.Value = (int)x;
            hScrollBarY.Value = (int)y;
            hScrollBarZ.Value = (int)z;
        }

        private void btnSet_Click(object sender, EventArgs e)
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


        private void btnResult_Click(object sender, EventArgs e)
        {
            CogFixtureNPointToNPointTool tool = new CogFixtureNPointToNPointTool();
            for (int i = tool.RunParams.NumPoints - 1; i >= 0; i--)
            {
                tool.RunParams.DeletePointPair(i);
            }//倒序删除，防止删除影响记录数
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
            //tool.RunParams.AddPointPair();
            tool.RunParams.DOFsToCompute = CogNPointToNPointDOFConstants.ScalingAspectRotationSkewAndTranslation;
            Bitmap img = new Bitmap(pictureBox1.Image);
            tool.InputImage = new CogImage8Grey(img);
            tool.Run();
            //程序可能为空，处理如下
            if (tool.Result == null || tool.Result.OutputImage == null)
            {
                MessageBox.Show("生成转换公式失败");
                return;
            }
            ICogImage OutputImage = tool.Result.OutputImage;
            visionJob.form2D1 =
                (CogTransform2DLinear)OutputImage.GetTransform
                (OutputImage.SelectedSpaceName, "@");
            //CogTransform2DLinear form2D1
            // = (CogTransform2DLinear)OutputImage.GetTransform(OutputImage.SelectedSpaceName, "@");
            //TranslationX = form2D1.TranslationX;
            //TranslationY = form2D1.TranslationY;
            //Rotation = form2D1.Rotation;
            //Scaling = form2D1.Scaling;
            //Aspect = form2D1.Aspect;
            //Skew = form2D1.Skew;
            ////原型含义，已经封装到VisionJob中
            visionJob.SaveArm();
            //设置一个保存到配置文件
            AddStr("平移X=" + visionJob.form2D1.TranslationX.ToString());
            AddStr("平移Y=" + visionJob.form2D1.TranslationY.ToString());
            AddStr("旋转=" + visionJob.form2D1.Rotation.ToString());
            AddStr("缩放=" + visionJob.form2D1.Scaling);
            AddStr("横纵比=" + visionJob.form2D1.Aspect);
            AddStr("倾斜=" + visionJob.form2D1.Skew);
            //tool.RunParams.AddPointPair()
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

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //CogTransform2DLinear Linear = new CogTransform2DLinear();
            //Linear.SetScalingAspectRotationSkewTranslation(Scaling, Aspect, Rotation, Skew, TranslationX, TranslationY);
            //图像坐标转机械坐标
            //Linear.MapVector(x2, y2, out x1, out y1);
            ////机械坐标转图像坐标
            double x1, y1, x2, y2;
            x1 = (int)((double)pictureBox1.Image.Width / pictureBox1.Width * e.X);
            y1 = (int)((double)pictureBox1.Image.Height / pictureBox1.Height * e.Y);

            visionJob.form2D1.MapPoint(x1, y1, out x2, out y2);
            //前面的机械坐标转化，由封装工具直接完成
            CRobotArm1.MoveXYZ(100, 100, 100);
            CRobotArm1.MoveXYZ((float)x2, (float)y2, 100);
            CRobotArm1.MoveXYZ((float)x2, (float)y2, 40);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            CRobotArm1.RobotArmPowerOn(false);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            CRobotArm1.RobotArmPowerOn(true);
        }

        private void btnGetArmPos_Click(object sender, EventArgs e)
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

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            int Rowindex = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(Rowindex);
        }
    }
}

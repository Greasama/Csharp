using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W13D4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0));
            //画笔（默认一个像素）
            e.Graphics.DrawLine(pen, 0, 0, 200, 200);
            //接续使用或者新建
            pen = new Pen(Color.FromArgb(255, 255, 255), 16);
            e.Graphics.DrawLine(pen, 200, 200, 400, 400);
            //画线
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            //画刷(填充底色，无像素概念)
            e.Graphics.FillRectangle(brush, 50, 50, 400, 400);
            //绘制矩形填充
            e.Graphics.DrawEllipse(pen, 100, 400, 100, 200);
            //绘制椭圆/圆边框，用外接长方形确定椭圆（即长轴短轴）
            pen = new Pen(Color.FromArgb(0, 0, 255), 10);
            //设定画笔宽度(中间向两边扩散)
            e.Graphics.DrawEllipse(pen, 100, 400, 100, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Black, 5);
            graphics.DrawLine(pen, 300, 10, 0, 300);

            dataGridView1.Rows.Add("第一行", 1, 2, 3, 4);
            int rowindex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowindex].Cells[0].Value = "第二行";
            dataGridView1.Rows[rowindex].Cells[1].Value = 5;
            dataGridView1.Rows[rowindex].Cells[2].Value = 6;
            dataGridView1.Rows[rowindex].Cells[3].Value = 7;
            dataGridView1.Rows[rowindex].Cells[4].Value = 8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                return;
            }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                string str =
                    Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                int.Parse(str);
                sum += int.Parse(str);
            }
            string temp = sum.ToString();
            MessageBox.Show(temp);
        }
    }
}

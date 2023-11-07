using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W14D1
{
    public partial class CurveControl : UserControl
    {
        public CurveControl()
        {
            InitializeComponent();
        }
        int m_0X = 0, m_0Y = 0;
        //坐标轴原点相对于客户区的位置，要在WM_SIZE上计算
        private void CurveControl_Resize(object sender, EventArgs e)
        {
            m_0X = Width / 2;
            m_0Y = Height / 2;
            Invalidate();
        }

        void DrawAxes(Graphics g)
        {
            Pen pen1 = new Pen(Color.Black);
            int penleft = 50;//端边距
            Font font = new Font("宋体", 12);
            g.DrawLine(pen1, penleft, m_0Y, Width - penleft, m_0Y);
            g.DrawLine(pen1, m_0X, penleft, m_0X, Height - penleft);
            //绘制X,Y轴直线
            int xCount = (int)(((Width - penleft) / 2) / m_Rate);
            //定区间点
            for (int i = 1; i < xCount; i++)
            {
                int x = (int)(m_0X + i * m_Rate);
                int x1 = (int)(m_0X - i * m_Rate);
                g.DrawLine(pen1, x, m_0Y, x, m_0Y - 5);
                g.DrawLine(pen1, x1, m_0Y, x1, m_0Y - 5);
                //绘制x轴坐标
                Rectangle rect = new Rectangle((int)(x - m_Rate / 2), m_0Y + 6, (int)m_Rate, 20);
                string str = i.ToString();
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(str, font, Brushes.Black, rect, sf);
                //绘制正向轴
                Rectangle rectL = new Rectangle((int)(x1 - m_Rate / 2), m_0Y + 6, (int)m_Rate, 20);
                str = (-i).ToString();
                g.DrawString(str, font, Brushes.Black, rectL, sf);
                //绘制负向轴
                //使用水平置中完成对齐
            }
            int yCount = (int)(((Height - penleft) / 2) / m_Rate);
            for (int i = 1; i < yCount; i++)
            {
                int y = (int)(m_0Y + i * m_Rate);
                int y1 = (int)(m_0Y - i * m_Rate);
                g.DrawLine(pen1, m_0X, y, m_0X + 5, y);
                g.DrawLine(pen1, m_0X, y1, m_0X + 5, y1);
                //绘制y轴坐标
                Rectangle rect = new Rectangle(m_0X - 40, y - 10, 30, 20);
                string str = (-i).ToString();
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(str, font, Brushes.Black, rect, sf);
                //绘制正向轴
                Rectangle rectL = new Rectangle(m_0X - 40, y1 - 10, 30, 20);
                str = (i).ToString();
                g.DrawString(str, font, Brushes.Black, rectL, sf);
                //绘制负向轴
            }
            int d = (int)(m_Rate / 5);
            Point[] pointX =
            {
                new Point(Width-penleft,m_0Y-d),
                new Point(Width-penleft+d,m_0Y),
                new Point(Width-penleft,m_0Y+d)
            };
            Brush brushBlackX = new SolidBrush(Color.Black);
            g.FillPolygon(brushBlackX, pointX);

            Point[] pointY =
            {
                new Point(m_0X-d,penleft),
                new Point(m_0X+d,penleft),
                new Point(m_0X,penleft-d)
            };
            Brush brushBlackY = new SolidBrush(Color.Black);
            g.FillPolygon(brushBlackY, pointY);
            //绘制三角形（坐标箭头）
        }

        int TranX(double x)
        {
            return (int)(m_0X + x * m_Rate + 0.5);
        }
        int TranY(double y)
        {
            return (int)(m_0Y - y * m_Rate + 0.5);
        }
        //坐标轴转换

        public void Drawxx(Graphics g)
        {
            double x = -4;
            double y = x * x;
            int Tranx0 = TranX(x);
            int Trany0 = TranY(y);
            Pen pen = new Pen(Color.Red);
            while (x < 4)
            {
                x += 0.01; y = x * x;
                int Tranx1 = TranX(x);
                int Trany1 = TranY(y);
                g.DrawLine(pen, Tranx0, Trany0, Tranx1, Trany1);
                Tranx0 = Tranx1; Trany0 = Trany1;
            }
        }

        public void DrawYXX(Graphics g, Color color,
    double a = 1, double b = 0, double c = 0,
    double startX = -4, double endX = 4)
        {

            double x = startX;
            double y;
            y = a * x * x + b * x + c;
            int Tranx0 = TranX(x);
            int Trany0 = TranY(y);
            Pen pen = new Pen(color);
            while (x < endX)
            {
                x += 0.01;
                y = a * x * x + b * x + c;
                int Tranx1 = TranX(x);
                int Trany1 = TranY(y);
                g.DrawLine(pen, Tranx0, Trany0, Tranx1, Trany1);
                Tranx0 = Tranx1;
                Trany0 = Trany1;
            }
        }

        public void DrawSin(Graphics g, Color color,
    double a = 1, double b = 1, double c = 0,
    double startX = -4, double endX = 4)
        {
            double x = startX;
            double y;
            y = a * Math.Sin(b * x + c);
            int Tranx0 = TranX(x);
            int Trany0 = TranY(y);
            Pen pen = new Pen(color,3);
            while (x < endX)
            {
                x += 0.01;
                y = a * Math.Sin(b * x + c);
                int Tranx1 = TranX(x);
                int Trany1 = TranY(y);
                g.DrawLine(pen, Tranx0, Trany0, Tranx1, Trany1);
                Tranx0 = Tranx1;
                Trany0 = Trany1;
            }
        }

        public void RotateAndDraw(Graphics g, double angle, Action<Graphics> drawAction)
        {
            Matrix originalTransform = g.Transform.Clone(); // 备份原始的图形变换
            g.TranslateTransform((float)m_0X, (float)m_0Y); // 将坐标轴原点设置为旋转中心
            g.RotateTransform((float)angle); // 旋转图形
            g.TranslateTransform(-(float)m_0X, -(float)m_0Y); // 恢复坐标轴原点
            drawAction(g); // 调用传入的绘图方法
            g.Transform = originalTransform; // 恢复原始的图形变换
        }

        private void CurveControl_Paint(object sender, PaintEventArgs e)
        {
            DrawAxes(e.Graphics);//画坐标轴
            Drawxx(e.Graphics);//绘制抛物线
            DrawYXX(e.Graphics, Color.Green, -2, 1, 3, -1, 1);//绘制任意抛物线
            DrawSin(e.Graphics, Color.Blue, 1, 1, 0, -12, 12);//绘制正弦波
            RotateAndDraw(e.Graphics, 45, g => Drawxx(g));
            RotateAndDraw(e.Graphics, 30, g => DrawYXX(g, Color.Green, -2, 1, 3, -1, 1));
            RotateAndDraw(e.Graphics, -15, g => DrawSin(g, Color.Blue, 1, 1, 0, -12, 12));
            //旋转
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_Rate *= 1.2;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Rate /= 1.2;
            Invalidate();
        }
        double m_Rate = 40;//每单位像数的个数
    }
}

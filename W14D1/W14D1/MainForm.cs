using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W14D1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal void drawThread()
        {
            double x = -12;
            Graphics g = curveControl1.CreateGraphics();
            while (x <= 12)
            {
                curveControl1.DrawSin(g, Color.Blue, 1, 1, 0, x, x + 0.1);
                curveControl1.DrawSin(g, Color.White, 1, 1, 0, x + 0.1, x + 1);
                x+= 0.1;
                Thread.Sleep(50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(drawThread);
            thread.Start();
        }
    }
}

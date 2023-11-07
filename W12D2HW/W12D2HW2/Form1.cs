using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace W12D2HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddStr(string str)
        {
            if (string.IsNullOrEmpty(result.Text))
            {
                result.Text = str;
            }
            else
            {
                result.Text += "\r\n" + str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //可以写成类
            double Chi = double.Parse(Chinese.Text);
            double Ma = double.Parse(Maths.Text);
            double Eng = double.Parse(English.Text);
            double Chem = double.Parse(Chemistry.Text);
            double Phy = double.Parse(Physics.Text);

            double Maxc = Math.Max(Chi,Math.Max(Ma,Math.Max(Eng,Math.Max(Chem,Phy))));
            double Sum = Chi + Ma + Eng + Chem + Phy;
            double Ave = Sum / 5;
            AddStr("最高分:" + Maxc + "\n" + "总分:" 
                + Sum + "\n" + "平均分:" + Ave);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Clear();
        }
    }
}

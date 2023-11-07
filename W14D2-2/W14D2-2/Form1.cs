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

namespace W14D2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddStr(string str)
        {
            BeginInvoke(
         new Action(
        delegate
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = str;
            }
            else
            {
                richTextBox1.Text += str;
            }
        }
      ));

        }
        bool runing = true;
        void threadA()
        {
            while (runing)
            {
                EventA.WaitOne();//等待事件A发生
                AddStr("A");
                Thread.Sleep(100);
                EventB.Set();//触发事件B
            }
        }

        void threadB()
        {
            while (runing)
            {
                EventB.WaitOne();
                AddStr("B");
                Thread.Sleep(50);
                EventC.Set();
            }
        }

        void threadC()
        {
            while (runing)
            {
                EventC.WaitOne();//等待事件C发生
                AddStr("C");
                Thread.Sleep(75);
                EventA.Set();//触发事件A
            }
        }

        Thread Ta;
        Thread Tb;
        Thread Tc;
        AutoResetEvent EventA = new AutoResetEvent(false);//自动事件A
        AutoResetEvent EventB = new AutoResetEvent(false);//自动事件B
        AutoResetEvent EventC = new AutoResetEvent(false);//自动事件C

        //事件的交互
        private void btnStart_Click(object sender, EventArgs e)
        {
            runing = true;
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            EventA.Set();
            Ta = new Thread(threadA);
            Tb = new Thread(threadB);
            Tc = new Thread(threadC);
            Ta.Start();
            Tb.Start();
            Tc.Start();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            runing = false;
            Ta.Join();
            Tb.Join();
            Tc.Join();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }
    }
}

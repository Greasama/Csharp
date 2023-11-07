using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W14D2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool stopThread = false;
        //终止变量
        Thread thread;
        int autoid = 1;
        object locker = new object();
        public void ThreadStart()
        {
            for (int i = 0; i < 1000; i++)
            {
                ////转到主线程运行，更新控件的内容
                ////主线程：刷新界面，响应界面操作
                //BeginInvoke(new Action(delegate
                //{
                //    try
                //    {
                //        btnCreate.Text = Convert.ToString(i);
                //    }
                //    catch { }
                //}));
                ////Invoke:同步执行（后面会等待，在这个程序中会出现互锁），它会阻塞当前线程，直到委托中的方法执行完成。
                ////BeginInvoke:异步执行，它会立即返回，不会阻塞当前线程，并且在后台线程上执行委托中的方法。
                //if (stopThread)
                //    break;
                //Thread.Sleep(100);
                int a;
                lock (locker)
                {
                    a = autoid++;
                }
                BeginInvoke(new Action(delegate
                {
                    try
                    {
                        ShowList.Items.Add(a);
                    }
                    catch { }
                }));
                Thread.Sleep(100);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            thread = new Thread(ThreadStart);
            thread.Start();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            thread.Suspend();
        }

        private void btnAwake_Click(object sender, EventArgs e)
        {
            thread.Resume();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                stopThread = true;
                thread.Join();//等待线程结束
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null)
            {
                stopThread = true;
                thread.Join();//等待线程结束
            }
        }
    }
}
//线程的并发和同步,并行转串行，事件同步

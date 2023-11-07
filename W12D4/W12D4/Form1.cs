using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Timer的Tick事件
        private void tmrReckon_Tick(object sender, EventArgs e)
        {
            prbTimeBar.Increment(5);  //显示进度条的当前位置

            //进度条的进度以文字显示
            lblInfo.Text = String.Format
               ($"{prbTimeBar.Value}% 已经完成");

            //判断最大值与实际进度值相等时表示完成
            if (prbTimeBar.Value == prbTimeBar.Maximum)
            {
                btnStart.Enabled = true;//恢复按钮的作用
                btnExit.Enabled = true;
                //停止定时器
                tmrReckon.Stop();
            }
        }
        //计时按钮
        private void btnStart_Click(object sender, EventArgs e)
        {
            //单击按钮启动定时器
            tmrReckon.Start();
            //让“开始计时”和“结束”按钮暂时不起作用
            btnStart.Enabled = false;
            btnExit.Enabled = false;
        }
        //结束按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        

    }
}

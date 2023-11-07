using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDialog Form = new FormDialog();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{DateTime.Now}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userAccount = textAcount.Text;
            DateTime showTime = DateTime.Now;//获取当前时间
            //调用ToShortTimeString()方法将获取的时间转换为字符串
            string saveTime = showTime.ToShortTimeString();

            //判断文本框是否有文字
            if (textAcount.Text == "")
                MessageBox.Show("请输入名字");
            else if (textPassword.Text == "")
                MessageBox.Show("请输入密码");
            else
            {
                MessageBox.Show($"Hi! {userAccount}" +
                   $"\n现在的时间：{saveTime}");
            }
        }
    }
}

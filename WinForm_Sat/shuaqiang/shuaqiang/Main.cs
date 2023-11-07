using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shuaqiang
{
    public partial class Main : Form
    {
        public bool verify = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //刷枪按钮单击响应函数
        private void button1_Click(object sender, EventArgs e)
        {
            if (verify == false)
            {
                MessageBox.Show("请登陆后再操作", "警告！");
                return;
            }
            else
            {
                //获取ListBox1里面选中的内容
                string str = listBox1.Text;
                if (str == "")
                {
                    MessageBox.Show("请选择武器", "警告！");
                    return;//没有返回值，直接退出
                }

                //恭喜获得...（字符串拼接）
                string str_info = "恭喜您获得" + str + "\n请进入游戏查看";
                MessageBox.Show($"刷取成功" + "\n" + str_info);
                //MessageBox.Show(str_info,"恭喜");//重载
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            //获取账号
            string id = textBox1.Text;
            //获取密码
            string pwd = textBox2.Text;
            //验证登录
            if (id == "123" & pwd == "321")
            {
                MessageBox.Show("登录成功！", "恭喜");
                verify = true;
            }
            else
            {
                MessageBox.Show("登录失败！\n请检查账号密码", "警告");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verify = false;
            MessageBox.Show("注销成功！", "提示");
        }

        //选择大区的响应函数
        private void button4_Click(object sender, EventArgs e)
        {
            //新建CHIOCE对象
            CHIOCE form = new CHIOCE();
            //弹出对话框,程序“阻塞”在此
            form.ShowDialog();
            //app内region赋值
            label3.Text = app.region;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

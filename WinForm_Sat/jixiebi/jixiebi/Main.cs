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

namespace jixiebi
{
    public partial class Main : Form
    {
        //实例化机械臂对象
        CRobotArm CRobotArm1 = new CRobotArm();
        int change = 1;
        public Main()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (CRobotArm1.ConnectRobot(comboBox1.Text) )
            {
                MessageBox.Show("机械臂连接成功！", "提示");
                AddStr("打开串口成功");    //写日志信息
            }
            else
            {
                MessageBox.Show("机械臂连接失败！", "提示");
                AddStr("打开串口失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRobotArm1.OpenAirPump(true);
            button3.BackColor = Color.Red;
            AddStr("气泵打开");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRobotArm1.OpenAirPump(false);
            button3.BackColor = Color.Gainsboro;
            AddStr("气泵关闭");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CRobotArm1.MoveRobotXYZ(100, 100, 100);
            CRobotArm1.MoveRobotXYZ(162, -164, 100);
            CRobotArm1.MoveRobotXYZ(162, -164, 40);
            CRobotArm1.MoveRobotXYZ(162, -164, 15, 50);
            Thread.Sleep(1000);
            CRobotArm1.OpenAirPump(true);
            Thread.Sleep(1000);
            CRobotArm1.MoveRobotXYZ(162, -164, 50, 50);
            CRobotArm1.MoveRobotXYZ(162, -164, 100);
            CRobotArm1.MoveRobotXYZ(162, 164, 100);
            CRobotArm1.MoveRobotXYZ(162, 164, 30);
            CRobotArm1.OpenAirPump(false);
            CRobotArm1.MoveRobotXYZ(162, 164, 100);
            CRobotArm1.MoveRobotXYZ(100, 100, 100);
            AddStr("移动测试完成");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CRobotArm1.MoveRobotXYZ(150, 0, 100);
            textBoxX.Text = 150.ToString();
            textBoxY.Text = 0.ToString();
            textBoxZ.Text = 100.ToString();
            AddStr("已完成归位运动");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {

        }

        //X+运动
        private void button7_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            x = x + change;
            textBoxX.Text = x.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //X-运动
        private void button8_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            x = x - change;
            textBoxX.Text = x.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //Y+运动
        private void button9_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            y = y + change;
            textBoxY.Text = y.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //Y-运动
        private void button10_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            y = y - change;
            textBoxY.Text = y.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //Z+运动
        private void button11_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            z = z + change;
            textBoxZ.Text = z.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //Z-运动
        private void button12_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            z = z - change;
            textBoxZ.Text = z.ToString();
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddStr("任意位移动开始");
            float x = float.Parse(textBoxX.Text);
            float y = float.Parse(textBoxY.Text);
            float z = float.Parse(textBoxZ.Text);
            CRobotArm1.MoveRobotXYZ(x, y, z);
            AddStr("X:" + textBoxX.Text + ",Y:" + textBoxY.Text + ",Z:" + textBoxZ.Text);
        }
        //紧急制动按钮（暂未设置）
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

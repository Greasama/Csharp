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

namespace W13D2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = GetKeyValue("PortName");
            Closeed();
        }

        string GetKeyValue(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value;
        }
        void SetKeyValue(string key, string Value)
        {
            try
            {
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (cfa.AppSettings.Settings[key] != null)
                    cfa.AppSettings.Settings[key].Value = comboBox1.Text;
                else
                    cfa.AppSettings.Settings.Add(key, comboBox1.Text);
                cfa.Save();
            }
            catch
            { }
        }

        void Closeed()
        {
            EnableButtons(false);
            comboBox1.Enabled = true;
            button1.Enabled = true;
            richTextBox1.Enabled = true;
        }
        void Opened()
        {
            EnableButtons(true);
            button1.Enabled = false;
            comboBox1.Enabled = false;
        }
        public void EnableButtons(bool enable)
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    if (enable)
                        control.Enabled = Convert.ToString(control.Tag) != "1";
                    else
                        control.Enabled = Convert.ToString(control.Tag) == "1";
                }
                if (control is Panel)
                {
                    foreach (Control controlitem in control.Controls)
                    {
                        if (controlitem is Button)
                        {
                            if (enable)
                                controlitem.Enabled = Convert.ToString(controlitem.Tag) != "1";
                            else
                                controlitem.Enabled = Convert.ToString(controlitem.Tag) == "1";
                        }
                    }
                }
            }
        }
        //问题：将第一个按钮也给灰了；解决：Enabled = true放在开头初始化

        //void SetControlState(Control _parent, bool state)
        //{
        //    foreach (Control item in _parent.Controls)
        //    {
        //        if (item is Panel)
        //        {
        //            SetControlState(item, state);
        //        }
        //        else
        //        {
        //            item.Enabled = state;
        //        }
        //    }
        //}
        ////范例：递归写法，注意comboBox设true,注意代码逻辑

        public void Addstr(string str)
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

        public void OpenAirPump(bool isOpen)
        {
            if (isOpen)
                serialPort1.WriteLine("M2231 V1");
            else
                serialPort1.WriteLine("M2231 V0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                serialPort1.PortName = comboBox1.Text;
                //serialPort1.Open();
                try
                {
                    serialPort1.Open();
                }
                catch
                {
                    Addstr("端口打开失败");
                    return;
                }
                if (!serialPort1.IsOpen)
                {
                    Addstr("端口打开失败");
                    return;
                }
                EnableButtons(true);
                Addstr("端口打开成功");
                serialPort1.WriteLine("\r\n");
                //完成冗余命令的执行
                Opened();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("G0 X100  Y-100 Z100 F500");
            serialPort1.WriteLine("G0 X100  Y100 Z100 F500");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("M2231 V1");
            OpenAirPump(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("M2231 V0");
            OpenAirPump(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("P2220");
            //取得当前位置的G代码
            int index = -1;
            string str = "";
            while (index == -1)
            {
                str = serialPort1.ReadLine();
                index = str.IndexOf("ok X");
            }
            Addstr(str);
            //判定字符串（更严谨）
            //读取X轴的G代码字符串
            index = str.IndexOf('X');
            string strX = str.Substring(index + 1);
            //取X后的字符
            index = strX.IndexOf(' ');
            strX = strX.Substring(0, index);
            //继续检索具体位置
            textBoxX.Text = strX;
            hScrollBarX.Value = (int)(double.Parse(strX) + 0.5);
            //Y轴
            index = str.IndexOf('Y');
            string strY = str.Substring(index + 1);
            index = strY.IndexOf(' ');
            strY = strY.Substring(0, index);
            textBoxY.Text = strY;
            hScrollBarY.Value = (int)(double.Parse(strY) + 0.5);
            //Z轴
            index = str.IndexOf('Z');
            string strZ = str.Substring(index + 1);
            //z轴结尾，无需判定空格
            textBoxZ.Text = strZ;
            hScrollBarZ.Value = (int)(double.Parse(strZ) + 0.5);
        }

        int autoid = 1;
        int GetAutoid()
        {
            return autoid++;
        }
        string readid(int id)
        {
            string substr = "$" + id.ToString() + " ";
            int index = -1;
            string str = "";
            while (index == -1)
            {
                str = serialPort1.ReadLine();

                index = str.IndexOf(substr);
            }
            return str;
        }

        public void moveXYZ(double X, double Y, double Z, int F = 10000)
        {
            string str = "G0 " + "X" + X.ToString()
                + "Y" + Y.ToString()
                + "Z" + Z.ToString()
                + "F" + F.ToString();
            int id = GetAutoid();
            //写的数据（完成分步记录）
            str = "#" + id.ToString() + " " + str;
            serialPort1.WriteLine("");
            //机械臂问题，先发一个空指令让机械臂先处理，减少丢失
            serialPort1.WriteLine(str);
            readid(id);
            //读的数据（识别+分步记录）
        }

        private void hScrollBarX_Scroll(object sender, ScrollEventArgs e)
        {
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
            textBoxY.Text = hScrollBarY.Value.ToString();
            textBoxZ.Text = hScrollBarZ.Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value++;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hScrollBarX.Value--;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxX.Text = hScrollBarX.Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hScrollBarY.Value++;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxY.Text = hScrollBarX.Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value--;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarX.Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value++;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarX.Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hScrollBarZ.Value--;
            moveXYZ(hScrollBarX.Value, hScrollBarY.Value, hScrollBarZ.Value);
            textBoxZ.Text = hScrollBarX.Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double xi = 100; double yi = 100; double zi = 100;
            double.TryParse(textBoxX.Text, out xi);
            double.TryParse(textBoxY.Text, out yi);
            double.TryParse(textBoxZ.Text, out zi);
            moveXYZ(xi, yi, zi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Closeed();
        }
        //移动测试
        private void button14_Click(object sender, EventArgs e)
        {
            double x1, y1, z1, x2, y2, z2;
            x1 = 215.9987;
            y1 = 10.2792;
            z1 = 12.5421;
            //X215.9987 Y10.2792 Z12.5421
            x2 = 319.5403;
            y2 = 108.2871;
            z2 = 27.5081;
            //ok X319.5403 Y108.2871 Z27.5081
            moveXYZ(100, 100, 100);
            moveXYZ(x1, y1, 100);
            moveXYZ(x1, y1, 50, 50);
            moveXYZ(x1, y1, z1);
            OpenAirPump(true);
            Thread.Sleep(1000);
            moveXYZ(x1, y1, 100);
            moveXYZ(x2, y2, 100);
            moveXYZ(x2, y2, z2);
            OpenAirPump(false);
            moveXYZ(x2, y2, 100);
            moveXYZ(100, 100, 100);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //FormUArmScript formUArmScript = new FormUArmScript();
            //formUArmScript.CRobotArm1 = CRobotArm1;
            //formUArmScript.ShowDialog();
        }
    }
}

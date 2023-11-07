using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 相机机械臂VisionPro联合编程
{
    public partial class UarmForm : Form
    {
        public UarmForm()
        {
            InitializeComponent();
            Closeed();
            string PortName = ConfigurationManager.AppSettings["PortName"];
            comboBox1.Text = PortName;
        }
        public CRobotArm CRobotArm1;
        void SetControlState(Control _parent, bool state)
        {
            foreach (Control item in _parent.Controls)
            {
                if (item is Panel)
                {
                    SetControlState(item, state);
                }
                else
                {
                    item.Enabled = state;
                }
            }

        }
        public void Opened()
        {
            SetControlState(this, true);
            button1.Enabled = false;

        }
        void Closeed()
        {
            SetControlState(this, false);
            comboBox1.Enabled = true;
            button1.Enabled = true;
            richTextBox1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CRobotArm1.ConnectRobot(comboBox1.Text))
            {
                Opened();
                AddStr("打开成功");
                GetState();//取得位置
                try
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    if (cfa.AppSettings.Settings["PortName"] != null)
                        cfa.AppSettings.Settings["PortName"].Value = comboBox1.Text;
                    else
                        cfa.AppSettings.Settings.Add("PortName", comboBox1.Text);
                    cfa.Save();
                }
                catch
                { }
            }
            else
            {
                AddStr("打开失败");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CRobotArm1.OpenAirPump(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRobotArm1.OpenAirPump(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CRobotArm1.MoveXYZWait(100, 100, 100);
            CRobotArm1.MoveXYZWait(162, -164, 100);
            CRobotArm1.MoveXYZWait(162,-164,40);
            CRobotArm1.MoveXYZWait(162,-164,15,50);
            Thread.Sleep(1000);
            CRobotArm1.OpenAirPump(true);
            Thread.Sleep(1000);
            CRobotArm1.MoveXYZWait(162, -164, 50,50);
            CRobotArm1.MoveXYZWait(162, -164, 100);
            CRobotArm1.MoveXYZWait(162, 164, 100);
            CRobotArm1.MoveXYZWait(162, 164, 30);
            CRobotArm1.OpenAirPump(false);
            CRobotArm1.MoveXYZWait(162, 164, 100);
            CRobotArm1.MoveXYZWait(100, 100, 100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetState();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CRobotArm1.DisConnectRobot();
            Closeed();
        }

        public void AddStr(string str)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = str;
            }
            else
            {
                richTextBox1.Text +="\r\n"+ str;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            float x = 100; float y = 100; float z=100;
            textBoxX.Text = hScrollBarX.Value.ToString();
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            CRobotArm1.MoveXYZ(x, y, z);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            textBoxY.Text = hScrollBarY.Value.ToString();
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            CRobotArm1.MoveXYZ(x, y, z);
        }
        private void hScrollBarZ_Scroll(object sender, ScrollEventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            textBoxZ.Text = hScrollBarZ.Value.ToString();
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            CRobotArm1.MoveXYZ(x, y, z);
        }
        public void  GetState()
        {
            float x; float y; float z;
            if (CRobotArm1.GetCurrentRobotPose(out x, out y, out z))
            {
                textBoxX.Text = x.ToString();
                textBoxY.Text = y.ToString();
                textBoxZ.Text = z.ToString();
                hScrollBarX.Value = (int)x;
                hScrollBarY.Value = (int)y;
                hScrollBarZ.Value = (int)z;
            }
            AddStr(""+ textBoxX.Text+"," + textBoxY.Text+"," + textBoxZ.Text);
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            CRobotArm1.MoveXYZ(100, -100, 100);
            CRobotArm1.MoveXYZ(100, 100, 100);
            GetState();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            float x = 100; float y = 100; float z = 100;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            string temp = "0123456789.-+ \b";
            if (temp.IndexOf(e.KeyChar)<0)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            float x ; float y ; float z ;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            x++;
            textBoxX.Text = x.ToString();

            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float x; float y; float z;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            x--;
            textBoxX.Text = x.ToString();
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            float x; float y; float z;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            y++;
            textBoxY.Text = y.ToString();
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            float x; float y; float z;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            y--;
            textBoxY.Text = y.ToString();
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            float x; float y; float z;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            z++;
            textBoxZ.Text = z.ToString();
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            float x; float y; float z;
            float.TryParse(textBoxX.Text, out x);
            float.TryParse(textBoxY.Text, out y);
            float.TryParse(textBoxZ.Text, out z);
            z--;
            textBoxZ.Text = z.ToString();
            CRobotArm1.MoveXYZ(x, y, z);
            GetState();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D2HW
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float result = x + y;
            MessageBox.Show($"结果为：" + result);
            string resultN = result.ToString();
            AddStr(resultN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float result = x - y;
            MessageBox.Show($"结果为：" + result);
            string resultN = result.ToString();
            AddStr(resultN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float result = x * y;
            MessageBox.Show($"结果为：" + result);
            string resultN = result.ToString();
            AddStr(resultN);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float result = x / y;
            MessageBox.Show($"结果为：" + result);
            string resultN = result.ToString();
            AddStr(resultN);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

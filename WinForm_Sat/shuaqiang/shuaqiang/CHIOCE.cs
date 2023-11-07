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
    public partial class CHIOCE : Form
    {
        public CHIOCE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Form2确认按钮单击响应函数
        private void button1_Click(object sender, EventArgs e)
        {
            //获取下拉框选择的内容
            string select_region=comboBox1.SelectedItem.ToString();
            //关闭当前对话框
            app.region=select_region;
            Close();
        }
    }
}

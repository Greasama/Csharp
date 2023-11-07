using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //获取文本框输入的名字
            string name = txtName.Text;
            int pay = 1_324;//每张票价
            //获取文本框输入的票数并调用Parse()方法转换为整数类型
            int ticket = int.Parse(txtTicket.Text);
            pay *= ticket;//计算总票价
                          //获取DateTimePicker控件的值再调用ToLongDateString()方法转换为日期
            string order = dtpPreDate.Value.ToLongDateString();
            //使用标签控件配合字符串内插方法显示信息
            lblShow.Text = $"Hi! {name}\n " +
               $"预订日期：{order}\n" +
               $"您订{ticket}张票，共{pay:c0}";
        }

        private void dtpPreDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D1
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frmDialog = new Form();
            frmDialog.Text = "新建窗体——对话框样式";

            //新建按钮并设置其属性
            Button btnCancle = new Button();
            btnCancle.Font = new Font("微软雅黑", 11);
            btnCancle.AutoSize = true;  //自行重设大小
            btnCancle.Text = "取消";
            btnCancle.Location = new Point(70, 60);  //设置位置

            //将窗体设为对话框，单线边框
            frmDialog.FormBorderStyle =
               FormBorderStyle.FixedDialog;
            frmDialog.Opacity = 0.85;     //将窗体变透明一些
            frmDialog.AutoSize = true;
            frmDialog.AutoSizeMode = AutoSizeMode.GrowOnly;
            //不设置最大化、最小化
            frmDialog.MaximizeBox = false;
            frmDialog.MinimizeBox = false;

            //用户单击窗体右上角“X”按钮如同单击“取消”按钮
            frmDialog.CancelButton = btnCancle;
            //设置执行窗体的起始位置在屏幕中央
            frmDialog.StartPosition =
               FormStartPosition.CenterScreen;
            //以Controls类在子窗体上加入“取消”按钮
            frmDialog.Controls.Add(btnCancle);
            frmDialog.ShowDialog();//显示窗体
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

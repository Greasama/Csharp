using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置第一个超链接标签控件的属性，链接网页，设置超链接颜色
            lnkGetIP.LinkColor = Color.DarkOrchid;

            //设置单击超链接且尚未放开鼠标按键之前所显示的颜色
            lnkGetIP.ActiveLinkColor = Color.Yellow;
            lnkGetIP.LinkVisited = true; //如果已被浏览过

            //已被浏览过的超链接会改变颜色
            lnkGetIP.VisitedLinkColor = Color.Maroon;

            //鼠标指针停留时才显示下画线
            lnkGetIP.LinkBehavior = LinkBehavior.HoverUnderline;

            //从第1个字符开始设置超链接，字符长度为6
            lnkGetIP.Text = "Visual Studio Web";
            lnkGetIP.LinkArea = new LinkArea(0, 6);
        }
        //第一个超链接标签控件，进入Visual Studio官方网站
        private void lnkGetIP_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  Process.Start("https://visualstudio.microsoft.com/zh-hans/");
            System.Diagnostics.Process.Start("https:\\www.hao123.com");
        }
        //第二个超链接标签控件，启动前一个范例的可执行文件
        private void lnkOpenApp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("E:\\ProgramData\\learn\\C#\\W12D1\\W12D1\\bin\\Debug\\W12D1.exe");

            //            Process.Start(@"E:\Debug\Ex1102.exe");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //可以执行文本框的撤销操作时
            if (txtNote.CanUndo == true)
            {
                txtNote.Undo();      //撤销文本框的编辑操作
                txtNote.ClearUndo(); //清除撤销缓冲区
                txtNote.Focus();     //获取文本框的输入焦点
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //从文本框选取的字符数大于0时
            if (txtNote.SelectionLength > 0)
            {
                txtNote.Copy();   //将数据复制到缓冲区
                                  //IDataObject提取文字内容并保留，不受接口格式的影响
                IDataObject buff = Clipboard.GetDataObject();

                //检查从系统剪贴板提取的数据，是否为原有格式
                if (buff.GetDataPresent(DataFormats.Text))
                {
                    //提取后显示在另一个文本框（缓冲区）中
                    txtBuffer.Text = (String)
                       (buff.GetData(DataFormats.UnicodeText));
                }
            }
            else
            {
                MessageBox.Show("没有选取一段文字！", "进行复制",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            //必须先判断有选取的一段文字才进行剪切
            if (!txtNote.SelectedText.Equals(""))
            {
                txtNote.Cut(); //将文字剪切到缓冲区
                IDataObject buff2 = Clipboard.GetDataObject();

                //从系统剪贴板提取文字，以原有格式保存
                if (buff2.GetDataPresent(DataFormats.Text))
                {
                    //提取后显示在另一个文本框(缓冲区)中
                    txtBuffer.Text = (String)
                       (buff2.GetData(DataFormats.UnicodeText));
                }
            }
            else
            {
                MessageBox.Show("没有选取的一段文字！", "进行剪切",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNote.Focus();
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtBuffer.Clear();
            btnClear.Enabled = true;

            //第一层if语句——判断是否从剪贴板中提取了文字
            if (Clipboard.GetDataObject().GetDataPresent(
                  DataFormats.Text) == true)
            {

                //第二层if语句——如果文本框内有文字
                if (txtNote.SelectionLength > 0)
                {

                    //第三层if-else语句——使用消息框来显示相关消息
                    if (MessageBox.Show("你确定要在当前的位置粘贴文字吗？",
                          "粘贴文字", MessageBoxButtons.YesNo)
                          == DialogResult.Yes)
                    {
                        //设置文字的起点来粘贴文字
                        txtNote.SelectionStart =
                           txtNote.SelectionStart +
                           txtNote.SelectionLength;
                    }
                    else
                        //如果单击消息框的“否”按钮时，则清除剪贴板的内容
                        Clipboard.Clear();
                } //第二层if语句
                txtNote.Paste();//调用粘贴方法
            }//第一层if语句
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNote.Clear();
            txtNote.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();//清除剪贴板的内容
            Close();
        }
    }
}

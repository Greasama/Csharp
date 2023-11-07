using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace W12D3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Visible = false;   //隐藏按钮控件
                                       //文本框大小根据窗体来填满
            rtxtRTF.Dock = DockStyle.Fill;

            //设置要查找字符串的起始位置
            //string target = "龟山岛";
            string target = TextInput.Text;
            int begin = 0;
            int count = 0;

            //加载文件
            rtxtRTF.LoadFile("E:\\ProgramData\\learn\\C#\\W12D3\\W12D3-2\\Demo.rtf");

            //通过TextLength属性获取加载文件的总字符串长度
            int result = rtxtRTF.TextLength;

            ////字符串总长度是否大于字符位置
            //while (result > begin)
            //{
            //    //调用SearchText()方法来返回第一个字符串的下标位置
            //    int outcome = SearchText(target, begin);
            //    string strHave = //字符串内插方法
            //       $"第 {count} 字符，下标编号：{outcome}";
            //    //MessageBox.Show(strHave);
            //    //begin = outcome;//更改要寻找字符串的下标位置
            //    //count++;
            //    if (outcome == -1 && count > result)
            //    {
            //        TextOutput.Text = "没有查找到该字符！";
            //        break;
            //    }
            //    begin = outcome + TextInput.TextLength;
            //    count++;
            //    TextOutput.Text += strHave;
            //    if (outcome != -1)
            //        break;
            //}

            //字符串总长度是否大于字符位置
            while (result > begin)
            {
                //调用SearchText()方法来返回第一个字符串的下标位置
                int outcome = SearchText(target, begin);

                if (outcome == -1)
                {
                    ++begin;
                }
                else
                {
                    begin = outcome + TextInput.TextLength;//更改要寻找字符串的下标位置
                    string strHave = //字符串内插方法
                  $"第 {count + 1} 字符，下标编号：{outcome}";
                    TextOutput.Text += (strHave + "\n");
                    count++;
                }
            }

            //保持文件
            rtxtRTF.SaveFile("E:\\ProgramData\\learn\\C#\\W12D3\\W12D3-2\\Change.rtf",
               RichTextBoxStreamType.RichText);
        }
        //查找字符串的方法——传入字符串和起始位置
        public int SearchText(string word, int start)
        {
            //没有找到匹配的字符串时返回-1
            int result = -1;
            //有字符串和起始位置才进一步查找
            if (word.Length > 0 && start >= 0)
            {
                //调用Find()方法查找字符串，None表示只要找到相似即可
                int MatchText = rtxtRTF.Find(word, start,
                   RichTextBoxFinds.None);
                //找到匹配的字符串，将字体大小设置为14，字体加粗
                rtxtRTF.SelectionFont = new Font(
                   "楷体", 14, FontStyle.Bold);
                //匹配的字符串重新设置字体颜色
                rtxtRTF.SelectionColor = Color.OrangeRed;
                if (MatchText >= 0)
                    result = MatchText;
            }
            return result;
        }
    }
}

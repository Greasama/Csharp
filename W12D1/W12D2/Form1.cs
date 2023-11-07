using System.Security.Principal;

namespace W12D2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //消息框的消息
            String message = "输入的字符数少于5个，请重新输入";
            //消息框的标题（账号）
            String account = "输入账号";
            //消息框的标题（密码）
            String password = "输入密码";
            //消息框的响应按钮
            MessageBoxButtons btnName = MessageBoxButtons.YesNo;
            MessageBoxButtons btnPwd = MessageBoxButtons.OKCancel;

            //消息框的图标
            MessageBoxIcon iconInfo = MessageBoxIcon.Information;
            MessageBoxIcon iconWarn = MessageBoxIcon.Warning;

            //消息框的返回值
            DialogResult result, confirm;

            //第一层if-else语句，账号的字符数必须大于等于5
            if (txtAccount.Text.Length >= 5)
            {

                /* 第二层if-else语句判断输入的密码字符数是否大于5
                   如果小于5，则调用getMessage()方法清除刚输入的密码*/
                if (txtPwd.Text.Length >= 5)
                {

                    /* 性别被勾选之后，才会显示个人的基本资料
                       RadioButton单选按钮以属性Checked来判断是否被勾选。
                       如果勾选了，就调用MessageBox类的Show()方法
                       显示账号、密码和性别的相关信息。
                    */
                    string verify = $"{txtAccount.Text}，" +
                       $"{(rabMale.Checked ? "帅哥" : "美女")}，你好！" +
                       $"\n密码：{txtPwd.Text}，资料正确。";
                    confirm = MessageBox.Show(verify);
                    ResultMsg(confirm);//传入参数值用于后续处理
                }
                else   //密码字符数小于5个字符时，显示消息
                {
                    //result = MessageBox.Show("密码" + message,
                    //   password, btnPwd, iconWarn,
                    //   MessageBoxDefaultButton.Button2);
                    //ResultMsg(result);
                    if (DialogResult.OK == MessageBox.Show("密码" + message,
                   password, btnPwd, iconWarn,
                   MessageBoxDefaultButton.Button2))
                    {
                        txtPwd.Clear();
                        txtPwd.Focus();
                    }
                }
            }
            else
            {
                //账号字符数小于5时显示消息
                //result = MessageBox.Show("名字" +
                //   message, account, btnName, iconInfo);
                //ResultMsg(result);
                if (DialogResult.OK == MessageBox.Show("名字" + message,
                   password, btnPwd, iconWarn,
                   MessageBoxDefaultButton.Button2))
                {
                    txtAccount.Clear();
                    txtAccount.Focus();
                    txtPwd.Clear();
                    txtPwd.Focus();
                }

            }
        }
        //根据按下的按钮来决定后续执行的程序
        private void ResultMsg(DialogResult outcome)
        {
            if (outcome == DialogResult.OK)
            {
                Application.Exit();//资料正确，退出程序
            }
            else if (outcome == DialogResult.Cancel)
            {
                txtPwd.Clear();//清除文本框内容
                txtPwd.Focus();//获取文本框的输入焦点
            }
            else if (outcome == DialogResult.Yes)
            {
                txtAccount.Clear();//清除文本框内容
                txtAccount.Focus();//获取文本框的输入焦点
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
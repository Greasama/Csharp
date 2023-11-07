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
            //��Ϣ�����Ϣ
            String message = "������ַ�������5��������������";
            //��Ϣ��ı��⣨�˺ţ�
            String account = "�����˺�";
            //��Ϣ��ı��⣨���룩
            String password = "��������";
            //��Ϣ�����Ӧ��ť
            MessageBoxButtons btnName = MessageBoxButtons.YesNo;
            MessageBoxButtons btnPwd = MessageBoxButtons.OKCancel;

            //��Ϣ���ͼ��
            MessageBoxIcon iconInfo = MessageBoxIcon.Information;
            MessageBoxIcon iconWarn = MessageBoxIcon.Warning;

            //��Ϣ��ķ���ֵ
            DialogResult result, confirm;

            //��һ��if-else��䣬�˺ŵ��ַ���������ڵ���5
            if (txtAccount.Text.Length >= 5)
            {

                /* �ڶ���if-else����ж�����������ַ����Ƿ����5
                   ���С��5�������getMessage()������������������*/
                if (txtPwd.Text.Length >= 5)
                {

                    /* �Ա𱻹�ѡ֮�󣬲Ż���ʾ���˵Ļ�������
                       RadioButton��ѡ��ť������Checked���ж��Ƿ񱻹�ѡ��
                       �����ѡ�ˣ��͵���MessageBox���Show()����
                       ��ʾ�˺š�������Ա�������Ϣ��
                    */
                    string verify = $"{txtAccount.Text}��" +
                       $"{(rabMale.Checked ? "˧��" : "��Ů")}����ã�" +
                       $"\n���룺{txtPwd.Text}��������ȷ��";
                    confirm = MessageBox.Show(verify);
                    ResultMsg(confirm);//�������ֵ���ں�������
                }
                else   //�����ַ���С��5���ַ�ʱ����ʾ��Ϣ
                {
                    //result = MessageBox.Show("����" + message,
                    //   password, btnPwd, iconWarn,
                    //   MessageBoxDefaultButton.Button2);
                    //ResultMsg(result);
                    if (DialogResult.OK == MessageBox.Show("����" + message,
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
                //�˺��ַ���С��5ʱ��ʾ��Ϣ
                //result = MessageBox.Show("����" +
                //   message, account, btnName, iconInfo);
                //ResultMsg(result);
                if (DialogResult.OK == MessageBox.Show("����" + message,
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
        //���ݰ��µİ�ť����������ִ�еĳ���
        private void ResultMsg(DialogResult outcome)
        {
            if (outcome == DialogResult.OK)
            {
                Application.Exit();//������ȷ���˳�����
            }
            else if (outcome == DialogResult.Cancel)
            {
                txtPwd.Clear();//����ı�������
                txtPwd.Focus();//��ȡ�ı�������뽹��
            }
            else if (outcome == DialogResult.Yes)
            {
                txtAccount.Clear();//����ı�������
                txtAccount.Focus();//��ȡ�ı�������뽹��
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
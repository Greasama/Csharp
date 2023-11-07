using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12D4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置标签属性——边框线、背景颜色，字体的大小和位置
            lblShow.BorderStyle = BorderStyle.FixedSingle;
            lblShow.BackColor = Color.GreenYellow;
            lblShow.Font = new Font(lblShow.Font.Name, 15.0F);
            lblShow.Location = new Point(50, 200);
            monCalendar.Dock = DockStyle.Top;//填满上方
            // 改变日历的背景颜色、前景颜色 
            monCalendar.ForeColor = Color.FromArgb(192, 0, 0);
            //周一为星期的第一天
            monCalendar.FirstDayOfWeek = Day.Monday;
            //日历显示的期间2022/2/1 ~2023/12/31，最小日期为今天
            monCalendar.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0);
            monCalendar.MinDate = DateTime.Today;
            //同时期只能选取30天
            monCalendar.MaxSelectionCount = 30;
            //显示周数
            monCalendar.ShowWeekNumbers = true;
            this.Text = "Ex0611-简单日历计算租金";
        }
        private void monCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime begin = e.Start;
            DateTime finish = e.End;
            TimeSpan days = finish - begin;
            int duration = days.Days + 1;
            float money = 150.0F;
            switch (duration)
            {
                case 1:
                    money *= 1.00F;
                    break;
                case 2:
                case 3:
                case 4:
                    money *= 0.95F;
                    break;
                case 5:
                case 6:
                    money *= 0.9F;
                    break;
                default:
                    money *= 0.8F;
                    break;
            }
            lblShow.Text = $"{duration.ToString()}天 租金: " +
                       $"{duration * money:C0}";
        }
    }
}

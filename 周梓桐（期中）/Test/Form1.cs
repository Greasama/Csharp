using System;
using System.Threading;
using System.Windows.Forms;

namespace Test
{
    //例程6-1 点位运动
    public partial class Form1 : Form
    {
        short axis;
        bool[] en = new bool[8];
        int pos;
        uint clk;
        double vel, prfvel, encvel, prfpos, encpos;
        gts.mc.TTrapPrm trap;

        bool bFlagAlarm = false;            // 伺服报警标志
        bool bFlagMError = false;           // 跟随误差越限标志
        bool bFlagPosLimit = false;     // 正限位触发标志
        bool bFlagNegLimit = false;     // 负限位触发标志
        bool bFlagSmoothStop = false;       // 平滑停止标志
        bool bFlagAbruptStop = false;       // 急停标志
        bool bFlagServoOn = false;          // 伺服使能标志
        bool bFlagMotion = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gts.mc.GT_Open(0, 1);//打开运动控制卡
            this.comboBox1.SelectedIndex = 0;
        }
        //复位
        public short WaitStop(short axis)
        {
            if (GetStatus(axis) != 0) return -1;
            while (bFlagMotion)
            {
                if (GetStatus(axis) != 0) return -1;
                Application.DoEvents();
            }
            return 0;
        }
        public short GetStatus(short axis)
        {

            //double dPrfPos;                 // 规划位置
            //double dPrfVel;                 // 规划速度
            //double dPrfAcc;                 // 规划加速度
            //int lPrfMode;                   // 运动模式
            short sRtn = -1;                   // 指令返回值变量
            int lAxisStatus;                  // 轴状态


            sRtn = gts.mc.GT_GetSts(axis, out lAxisStatus, 1, out clk);
            if (sRtn != 0)
            {
                return sRtn;
            }

            bFlagAlarm = (lAxisStatus & (1 << 1)) != 0;
            bFlagMError = (lAxisStatus & (1 << 4)) != 0;
            bFlagPosLimit = (lAxisStatus & (1 << 5)) != 0;
            bFlagNegLimit = (lAxisStatus & (1 << 6)) != 0;
            bFlagSmoothStop = (lAxisStatus & (1 << 7)) != 0;
            bFlagAbruptStop = (lAxisStatus & (1 << 8)) != 0;
            bFlagServoOn = (lAxisStatus & (1 << 9)) != 0;
            bFlagMotion = (lAxisStatus & (1 << 10)) != 0;
            return 0;
        }


        private void button6_Click(object sender, EventArgs e)
        {
         //   gts.mc.GT_Reset();
            gts.mc.GT_ClrSts(1, 8);//清除各轴报警和限位
        }
        //初始化
        private void button1_Click(object sender, EventArgs e)
        {
            gts.mc.GT_LoadConfig("GT800_test.cfg");//下载配置文件
            gts.mc.GT_ClrSts(1, 8);//清除各轴报警和限位
        }
        //伺服使能
        private void button5_Click(object sender, EventArgs e)
        {
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            if (!en[axis - 1])
            {
                gts.mc.GT_AxisOn(axis);//上伺服
                this.button5.Text = "伺服关闭";
            }
            if (en[axis - 1])
            {
                gts.mc.GT_AxisOff(axis);//下伺服
                this.button5.Text = "伺服使能";
            }
            en[axis - 1] = !en[axis - 1];

        }
        //启动点位运动
        private void button2_Click(object sender, EventArgs e)
        {
            //读取数据
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            vel = Convert.ToDouble(this.textBox1.Text);
            pos += Convert.ToInt32(this.textBox2.Text);
            trap.acc = Convert.ToDouble(this.textBox3.Text);
            trap.dec = Convert.ToDouble(this.textBox4.Text);
            trap.smoothTime = Convert.ToInt16(this.textBox5.Text);
            trap.velStart = 0;


            gts.mc.GT_PrfTrap(axis);
            gts.mc.GT_SetTrapPrm(axis, ref trap);//设置点位运动参数
            gts.mc.GT_SetVel(axis, vel);//设置目标速度
            gts.mc.GT_SetPos(axis, pos);//设置目标位置
            gts.mc.GT_Update(1 << (axis - 1));//更新轴运动
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox10.Text, out double x))
            {
                MessageBox.Show("您的输入有误");
            }
            if (!double.TryParse(textBox11.Text, out double y))
            {
                MessageBox.Show("您的输入有误");
            }
            gts.mc.GT_AxisOn(1);           //开启一轴的伺服使能
            this.comboBox1.SelectedIndex = 0;
            double slop = x / y;           //斜率的倒数
            double x_uint = 1.05 / 10000;
            double y_uint = 7.25 / 10000;

            double x_loc = 0.0;
            int x_step = 1;        //x的脉冲数
            int y_step = (int)(y / y_uint);


            trap.acc = Convert.ToDouble(this.textBox3.Text);
            trap.dec = Convert.ToDouble(this.textBox4.Text);
            trap.smoothTime = Convert.ToInt16(this.textBox5.Text);
            trap.velStart = 0;

            for (int i = 1; i < (y_step / 10); i++)
            {
                gts.mc.GT_SetTrapPrm(1, ref trap);//设置点位运动参数
                gts.mc.GT_SetTrapPrm(2, ref trap);//设置点位运动参数
                gts.mc.GT_SetPos(1, x_step * 10);
                gts.mc.GT_SetVel(1, Convert.ToInt32(textBox1.Text));
                gts.mc.GT_SetPos(2, i * 10);
                gts.mc.GT_SetVel(2, Convert.ToInt32(textBox1.Text));
                gts.mc.GT_Update(0X03);//更新轴运动
                //WaitStop(1);
                //WaitStop(2);
                gts.mc.GT_GetEncPos(1, out x_loc, 1, out clk);


                while (x_loc < (i * 10 * slop))
                {
                    x_step++;
                    gts.mc.GT_SetTrapPrm(1, ref trap);//设置点位运动参数
                    gts.mc.GT_SetPos(1, x_step * 10);
                    gts.mc.GT_SetVel(1, Convert.ToInt32(textBox1.Text));
                    gts.mc.GT_Update(0X01);//更新轴运动
                    gts.mc.GT_GetEncPos(1, out x_loc, 1, out clk);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int pos = 0;
           
            this.comboBox1.SelectedIndex = 0;
            textBox12.Text = "开始定位1轴原点";
            gts.mc.GT_AxisOn(1);
            gts.mc.GT_ClrSts(1, 8);
            pos = newaxis_Limtelocal(1);
            textBox12.Text = "开始定位2轴原点";
            this.comboBox1.SelectedIndex = 1;
            comboBox1.Text = "2";
            gts.mc.GT_ClrSts(1, 8);
            pos = newaxis_Limtelocal(2);

        }

        //刷新状态
        private void timer1_Tick(object sender, EventArgs e)
        {
            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            if (!en[Convert.ToInt32(this.comboBox1.Text) - 1])
            {
                this.button5.Text = "伺服使能";
            }
            if (en[Convert.ToInt32(this.comboBox1.Text) - 1])
            {
                this.button5.Text = "伺服关闭";
            }
            gts.mc.GT_GetPrfPos(axis, out prfpos, 1, out clk);            //读取规划位置
            this.textBox6.Text = Math.Round(prfpos, 1).ToString();
            gts.mc.GT_GetPrfVel(axis, out prfvel, 1, out clk);             //读取规划速度
            this.textBox7.Text = Math.Round(prfvel, 1).ToString();
            gts.mc.GT_GetEncPos(axis, out encpos, 1, out clk);             //获得实际位置
            this.textBox8.Text = Math.Round(encpos, 1).ToString();
            gts.mc.GT_GetEncVel(axis, out encvel, 1, out clk);             //获得实际速度
            this.textBox9.Text = Math.Round(encvel, 1).ToString();
        }
        //平滑停止
        private void button3_Click(object sender, EventArgs e)
        {
            gts.mc.GT_Stop(1 << (axis - 1), 0);
            pos = 0;
        }
        //位置清零
        private void button4_Click(object sender, EventArgs e)
        {

            //int X_HOME = newaxis_Limtelocal(1);
            //int y_Home = newaxis_Limtelocal(2);


            //gts.mc.GT_SetPos(2, y_Home);
            //gts.mc.GT_SetPos(1, X_HOME);
            gts.mc.GT_ZeroPos(1, 8);
            MessageBox.Show("已重新设置原点");
            gts.mc.GT_ClrSts(1, 8);//清除各轴报警和限位

        }

        private int newaxis_Limtelocal(short newaxis)                 //这是一个获取原点的函数
        {

            double porel_pos;     //定义长度正
            double porel_neg;

            int lAxisStatus;					// 轴状态
            uint clk;
            double set_Home;
            int pos = 1000;
            int Neg = -1000;


            axis = Convert.ToInt16(this.comboBox1.SelectedIndex + 1);
            vel = Convert.ToDouble(this.textBox1.Text);
            pos += Convert.ToInt32(this.textBox2.Text);
            trap.acc = Convert.ToDouble(this.textBox3.Text);
            trap.dec = Convert.ToDouble(this.textBox4.Text);
            trap.smoothTime = Convert.ToInt16(this.textBox5.Text);
            trap.velStart = 0;

            gts.mc.GT_ClrSts(1, 8);
            Thread.Sleep(100);

            while (!(bFlagPosLimit))                   //判断限位
            {

                gts.mc.GT_PrfTrap(newaxis);      //确保GT_SetPos能用
                gts.mc.GT_SetTrapPrm(axis, ref trap);//设置点位运动参数
                gts.mc.GT_SetPos(newaxis, pos);
                gts.mc.GT_SetVel(newaxis, 10);
                gts.mc.GT_Update(1 << (newaxis - 1));//更新轴运动
                                                 //    WaitStop(axis);
                gts.mc.GT_GetSts(newaxis, out lAxisStatus, 1, out clk);
                if ((lAxisStatus & 0x20) != 0)
                {
                    bFlagPosLimit = true;
                    MessageBox.Show($"完成触发{newaxis}正限位");
                    textBox12.Text = Convert.ToString(pos) + "pos";
                }
                else pos = pos + 3000;
                Application.DoEvents();
            }
            bFlagPosLimit=false;
            // 正向限位触发
            //获取负限位
            gts.mc.GT_ClrSts(newaxis, 8);
            Thread.Sleep(100);
            gts.mc.GT_GetPrfPos(axis, out porel_pos, 1, out clk);
            while (!(bFlagNegLimit))
            {
                gts.mc.GT_PrfTrap(newaxis);      //确保GT_SetPos能用
                gts.mc.GT_SetTrapPrm(axis, ref trap);//设置点位运动参数
                gts.mc.GT_SetPos(newaxis, Neg);
                gts.mc.GT_SetVel(newaxis, 10);
                gts.mc.GT_Update(1 << (newaxis - 1));//更新轴运动
                //Thread.Sleep(100);
                //WaitStop(axis);
                gts.mc.GT_GetSts(newaxis, out lAxisStatus, 1, out clk);
                if ((lAxisStatus & 0x40) != 0)
                {
                    bFlagNegLimit = true;
                    MessageBox.Show($"完成触发{newaxis}负限位");
                    textBox12.Text = Convert.ToString(Neg) + "Neg";
                }
                else
                {
                    Neg = Neg - 3000;

                }
                Application.DoEvents();
            }
            bFlagNegLimit=false;
            gts.mc.GT_ClrSts(newaxis,8);
            gts.mc.GT_GetPrfPos(axis, out porel_neg, 1, out clk);
            set_Home = (porel_pos + porel_neg) / 2;
            gts.mc.GT_PrfTrap(newaxis);
            gts.mc.GT_SetTrapPrm(axis, ref trap);//设置点位运动参数
            gts.mc.GT_SetPos(newaxis, Convert.ToInt32(set_Home));    //设置运动到中心位置
            gts.mc.GT_SetVel(newaxis, 10);
            gts.mc.GT_Update(1 << (newaxis - 1));//更新轴运动
      //      gts.mc.GT_Stop(1 << (axis - 1), 0);
       //     WaitStop(axis);
            gts.mc.GT_ZeroPos(newaxis, 1);//设原点
            gts.mc.GT_ClrSts(newaxis, 8);
            return Convert.ToInt32(set_Home);
        }


    }
}

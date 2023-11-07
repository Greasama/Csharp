namespace 相机机械臂VisionPro联合编程.MccMode
{
    partial class LaserMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAxis = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxInputCout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxHaveSendPulseNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPulseNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCycleTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWMLowWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PowerOff = new System.Windows.Forms.Button();
            this.PowerOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnClosePWM = new System.Windows.Forms.Button();
            this.btnDoPWM = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAxis);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 186);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 123);
            this.panel3.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textY);
            this.groupBox4.Controls.Add(this.textX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(728, 123);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "平面加工默认采用XY直线插补，Z轴需手动调整";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(49, 70);
            this.textY.Margin = new System.Windows.Forms.Padding(2);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(76, 24);
            this.textY.TabIndex = 3;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(49, 22);
            this.textX.Margin = new System.Windows.Forms.Padding(2);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(76, 24);
            this.textX.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y轴：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "X轴：";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(422, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 33);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停止运动";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(308, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除缓冲区";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAxis
            // 
            this.btnAxis.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxis.Location = new System.Drawing.Point(196, 9);
            this.btnAxis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAxis.Name = "btnAxis";
            this.btnAxis.Size = new System.Drawing.Size(108, 33);
            this.btnAxis.TabIndex = 7;
            this.btnAxis.Text = "建立坐标系";
            this.btnAxis.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZero.Location = new System.Drawing.Point(101, 9);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(89, 33);
            this.btnZero.TabIndex = 6;
            this.btnZero.Text = "回归零点";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(8, 9);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "启动复位";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 272);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxInputCout);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxHaveSendPulseNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxPulseNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxCycleTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPWMLowWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "低速脉冲输出";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(46, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "注意检查电源，\r\n佩戴眼镜安全作业";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxInputCout
            // 
            this.txtBoxInputCout.Location = new System.Drawing.Point(41, 217);
            this.txtBoxInputCout.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInputCout.Name = "txtBoxInputCout";
            this.txtBoxInputCout.Size = new System.Drawing.Size(98, 21);
            this.txtBoxInputCout.TabIndex = 9;
            this.txtBoxInputCout.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "光栅计数器:";
            // 
            // txtBoxHaveSendPulseNum
            // 
            this.txtBoxHaveSendPulseNum.Location = new System.Drawing.Point(41, 172);
            this.txtBoxHaveSendPulseNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHaveSendPulseNum.Name = "txtBoxHaveSendPulseNum";
            this.txtBoxHaveSendPulseNum.Size = new System.Drawing.Size(98, 21);
            this.txtBoxHaveSendPulseNum.TabIndex = 7;
            this.txtBoxHaveSendPulseNum.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "已发送脉冲个数:";
            // 
            // txtBoxPulseNum
            // 
            this.txtBoxPulseNum.Location = new System.Drawing.Point(41, 127);
            this.txtBoxPulseNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPulseNum.Name = "txtBoxPulseNum";
            this.txtBoxPulseNum.Size = new System.Drawing.Size(98, 21);
            this.txtBoxPulseNum.TabIndex = 5;
            this.txtBoxPulseNum.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "命令脉冲个数:";
            // 
            // txtBoxCycleTime
            // 
            this.txtBoxCycleTime.Location = new System.Drawing.Point(41, 82);
            this.txtBoxCycleTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCycleTime.Name = "txtBoxCycleTime";
            this.txtBoxCycleTime.Size = new System.Drawing.Size(98, 21);
            this.txtBoxCycleTime.TabIndex = 3;
            this.txtBoxCycleTime.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "脉冲周期[ms]:";
            // 
            // txtPWMLowWidth
            // 
            this.txtPWMLowWidth.Location = new System.Drawing.Point(41, 38);
            this.txtPWMLowWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtPWMLowWidth.Name = "txtPWMLowWidth";
            this.txtPWMLowWidth.Size = new System.Drawing.Size(98, 21);
            this.txtPWMLowWidth.TabIndex = 1;
            this.txtPWMLowWidth.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "低脉冲宽度[ms]:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(150, 186);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 272);
            this.panel4.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PowerOff);
            this.groupBox3.Controls.Add(this.PowerOn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(92, 126);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "I/O控制";
            // 
            // PowerOff
            // 
            this.PowerOff.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerOff.Location = new System.Drawing.Point(4, 71);
            this.PowerOff.Margin = new System.Windows.Forms.Padding(2);
            this.PowerOff.Name = "PowerOff";
            this.PowerOff.Size = new System.Drawing.Size(82, 26);
            this.PowerOff.TabIndex = 1;
            this.PowerOff.Text = "关闭";
            this.PowerOff.UseVisualStyleBackColor = true;
            this.PowerOff.Click += new System.EventHandler(this.PowerOff_Click);
            // 
            // PowerOn
            // 
            this.PowerOn.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerOn.Location = new System.Drawing.Point(4, 30);
            this.PowerOn.Margin = new System.Windows.Forms.Padding(2);
            this.PowerOn.Name = "PowerOn";
            this.PowerOn.Size = new System.Drawing.Size(82, 26);
            this.PowerOn.TabIndex = 0;
            this.PowerOn.Text = "打开";
            this.PowerOn.UseVisualStyleBackColor = true;
            this.PowerOn.Click += new System.EventHandler(this.PowerOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOn);
            this.groupBox2.Controls.Add(this.btnClosePWM);
            this.groupBox2.Controls.Add(this.btnDoPWM);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(92, 147);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "脉冲控制";
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOn.Location = new System.Drawing.Point(4, 100);
            this.btnOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(82, 26);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "打开";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnClosePWM
            // 
            this.btnClosePWM.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosePWM.Location = new System.Drawing.Point(4, 61);
            this.btnClosePWM.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePWM.Name = "btnClosePWM";
            this.btnClosePWM.Size = new System.Drawing.Size(82, 26);
            this.btnClosePWM.TabIndex = 1;
            this.btnClosePWM.Text = "停止发送";
            this.btnClosePWM.UseVisualStyleBackColor = true;
            this.btnClosePWM.Click += new System.EventHandler(this.btnClosePWM_Click);
            // 
            // btnDoPWM
            // 
            this.btnDoPWM.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDoPWM.Location = new System.Drawing.Point(4, 23);
            this.btnDoPWM.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoPWM.Name = "btnDoPWM";
            this.btnDoPWM.Size = new System.Drawing.Size(82, 26);
            this.btnDoPWM.TabIndex = 0;
            this.btnDoPWM.Text = "输出脉冲";
            this.btnDoPWM.UseVisualStyleBackColor = true;
            this.btnDoPWM.Click += new System.EventHandler(this.btnDoPWM_Click);
            // 
            // LaserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(728, 458);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LaserMode";
            this.Text = "PTMode";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPWMLowWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInputCout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxHaveSendPulseNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPulseNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCycleTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAxis;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PowerOff;
        private System.Windows.Forms.Button PowerOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnClosePWM;
        private System.Windows.Forms.Button btnDoPWM;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Timer timer1;
    }
}
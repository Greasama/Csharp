namespace 相机机械臂VisionPro联合编程.MccMode
{
    partial class InterpolationMode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAxis = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZoneXYZ = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLineXY = new System.Windows.Forms.Button();
            this.parameter = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.parameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAxis);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(709, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(564, 12);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 41);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止运动";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除缓冲区";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAxis
            // 
            this.btnAxis.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAxis.Location = new System.Drawing.Point(263, 12);
            this.btnAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAxis.Name = "btnAxis";
            this.btnAxis.Size = new System.Drawing.Size(144, 41);
            this.btnAxis.TabIndex = 2;
            this.btnAxis.Text = "建立坐标系";
            this.btnAxis.UseVisualStyleBackColor = true;
            this.btnAxis.Click += new System.EventHandler(this.btnAxis_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZero.Location = new System.Drawing.Point(137, 12);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(119, 41);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "回归零点";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "初始化";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnZoneXYZ);
            this.panel2.Controls.Add(this.btnCircle);
            this.panel2.Controls.Add(this.btnLineXY);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 71);
            this.panel2.TabIndex = 1;
            // 
            // btnZoneXYZ
            // 
            this.btnZoneXYZ.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZoneXYZ.Location = new System.Drawing.Point(490, 12);
            this.btnZoneXYZ.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoneXYZ.Name = "btnZoneXYZ";
            this.btnZoneXYZ.Size = new System.Drawing.Size(193, 41);
            this.btnZoneXYZ.TabIndex = 2;
            this.btnZoneXYZ.Text = "空间直线插补";
            this.btnZoneXYZ.UseVisualStyleBackColor = true;
            this.btnZoneXYZ.Click += new System.EventHandler(this.btnZoneXYZ_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCircle.Location = new System.Drawing.Point(251, 12);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(193, 41);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "XY平面圆弧插补";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLineXY
            // 
            this.btnLineXY.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLineXY.Location = new System.Drawing.Point(12, 12);
            this.btnLineXY.Margin = new System.Windows.Forms.Padding(4);
            this.btnLineXY.Name = "btnLineXY";
            this.btnLineXY.Size = new System.Drawing.Size(193, 41);
            this.btnLineXY.TabIndex = 0;
            this.btnLineXY.Text = "XY二维直线插补";
            this.btnLineXY.UseVisualStyleBackColor = true;
            this.btnLineXY.Click += new System.EventHandler(this.btnLineXY_Click);
            // 
            // parameter
            // 
            this.parameter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.parameter.Controls.Add(this.textBox8);
            this.parameter.Controls.Add(this.label8);
            this.parameter.Controls.Add(this.textBox7);
            this.parameter.Controls.Add(this.label7);
            this.parameter.Controls.Add(this.textBox6);
            this.parameter.Controls.Add(this.label6);
            this.parameter.Controls.Add(this.textBox5);
            this.parameter.Controls.Add(this.label5);
            this.parameter.Controls.Add(this.textBox4);
            this.parameter.Controls.Add(this.label4);
            this.parameter.Controls.Add(this.textBox3);
            this.parameter.Controls.Add(this.label3);
            this.parameter.Controls.Add(this.textBox2);
            this.parameter.Controls.Add(this.label2);
            this.parameter.Controls.Add(this.textBox1);
            this.parameter.Controls.Add(this.label1);
            this.parameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.parameter.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parameter.Location = new System.Drawing.Point(0, 139);
            this.parameter.Margin = new System.Windows.Forms.Padding(4);
            this.parameter.Name = "parameter";
            this.parameter.Padding = new System.Windows.Forms.Padding(4);
            this.parameter.Size = new System.Drawing.Size(267, 516);
            this.parameter.TabIndex = 2;
            this.parameter.TabStop = false;
            this.parameter.Text = "坐标参数";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(43, 472);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(162, 30);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "加速度：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(43, 411);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 30);
            this.textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "速度：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(43, 350);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 30);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "圆弧半径：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 289);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 30);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y轴圆弧终点位置：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 30);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "X轴圆弧终点位置：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 30);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z轴位移：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y轴位移：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X轴位移：";
            // 
            // InterpolationMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(709, 655);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterpolationMode";
            this.Text = "插补模式";
            this.Load += new System.EventHandler(this.InterpolationMode_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAxis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLineXY;
        private System.Windows.Forms.Button btnZoneXYZ;
        private System.Windows.Forms.GroupBox parameter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
    }
}
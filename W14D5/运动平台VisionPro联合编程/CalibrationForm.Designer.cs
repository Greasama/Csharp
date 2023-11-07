namespace 相机机械臂VisionPro联合编程
{
    partial class CalibrationForm
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
            this.button22 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.hScrollBarZ = new System.Windows.Forms.HScrollBar();
            this.hScrollBarY = new System.Windows.Forms.HScrollBar();
            this.hScrollBarX = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 52);
            this.panel1.TabIndex = 1;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(544, 8);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(123, 37);
            this.button22.TabIndex = 76;
            this.button22.Text = "参数设置";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 37);
            this.button6.TabIndex = 75;
            this.button6.Text = "位置测试";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 74;
            this.button4.Text = "回归零点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 37);
            this.button7.TabIndex = 73;
            this.button7.Text = "取得位置";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 8);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 37);
            this.button13.TabIndex = 71;
            this.button13.Text = "到指定位置";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.labelZ);
            this.panel2.Controls.Add(this.labelY);
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.hScrollBarZ);
            this.panel2.Controls.Add(this.hScrollBarY);
            this.panel2.Controls.Add(this.hScrollBarX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxZ);
            this.panel2.Controls.Add(this.textBoxY);
            this.panel2.Controls.Add(this.textBoxX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 153);
            this.panel2.TabIndex = 18;
            // 
            // labelZ
            // 
            this.labelZ.Location = new System.Drawing.Point(185, 117);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(77, 22);
            this.labelZ.TabIndex = 80;
            this.labelZ.Text = "label6";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(185, 72);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(77, 22);
            this.labelY.TabIndex = 79;
            this.labelY.Text = "label5";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(185, 26);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(77, 22);
            this.labelX.TabIndex = 78;
            this.labelX.Text = "label5";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(1014, 112);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 29);
            this.button19.TabIndex = 77;
            this.button19.Text = ">|";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(1014, 65);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 29);
            this.button20.TabIndex = 76;
            this.button20.Text = ">|";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1014, 20);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 29);
            this.button21.TabIndex = 75;
            this.button21.Text = ">|";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(898, 114);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 29);
            this.button14.TabIndex = 74;
            this.button14.Text = "|<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(898, 67);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 29);
            this.button16.TabIndex = 73;
            this.button16.Text = "|<";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(898, 22);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 29);
            this.button18.TabIndex = 72;
            this.button18.Text = "|<";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "取图像位置",
            "移动平台"});
            this.comboBox1.Location = new System.Drawing.Point(1075, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "图像坐标0，0机械坐标0，0";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(940, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 29);
            this.button10.TabIndex = 69;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(977, 113);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 29);
            this.button12.TabIndex = 68;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(940, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 29);
            this.button5.TabIndex = 67;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(977, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 29);
            this.button9.TabIndex = 66;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(940, 21);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 29);
            this.button17.TabIndex = 65;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(977, 21);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 29);
            this.button15.TabIndex = 64;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // hScrollBarZ
            // 
            this.hScrollBarZ.Location = new System.Drawing.Point(269, 115);
            this.hScrollBarZ.Maximum = 200;
            this.hScrollBarZ.Name = "hScrollBarZ";
            this.hScrollBarZ.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarZ.TabIndex = 38;
            this.hScrollBarZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // hScrollBarY
            // 
            this.hScrollBarY.Location = new System.Drawing.Point(269, 68);
            this.hScrollBarY.Maximum = 360;
            this.hScrollBarY.Name = "hScrollBarY";
            this.hScrollBarY.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarY.TabIndex = 37;
            this.hScrollBarY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // hScrollBarX
            // 
            this.hScrollBarX.Location = new System.Drawing.Point(269, 24);
            this.hScrollBarX.Maximum = 360;
            this.hScrollBarX.Name = "hScrollBarX";
            this.hScrollBarX.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarX.TabIndex = 36;
            this.hScrollBarX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y坐标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X坐标";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(65, 117);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(114, 30);
            this.textBoxZ.TabIndex = 2;
            this.textBoxZ.Text = "0";
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBoxZ_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(65, 70);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(114, 30);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.Text = "0";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(65, 23);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(114, 30);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 400);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt|*.txt";
            this.saveFileDialog1.Filter = "txt|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt|*.txt";
            this.openFileDialog1.Filter = "txt|*.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 77;
            this.button1.Text = "气泵测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalibrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalibrationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.CalibrationForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.HScrollBar hScrollBarZ;
        private System.Windows.Forms.HScrollBar hScrollBarY;
        private System.Windows.Forms.HScrollBar hScrollBarX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Panel panel3;
        private AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button button1;
    }
}
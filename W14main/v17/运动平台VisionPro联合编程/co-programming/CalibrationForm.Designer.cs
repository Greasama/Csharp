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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClosePump = new System.Windows.Forms.Button();
            this.btnOpenPump = new System.Windows.Forms.Button();
            this.btnSetMcc = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnZeroCalib = new System.Windows.Forms.Button();
            this.btnGetPos = new System.Windows.Forms.Button();
            this.btnSetPos = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnPicPos = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEn = new System.Windows.Forms.TextBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnLoadFormulas = new System.Windows.Forms.Button();
            this.btnSaveFormulas = new System.Windows.Forms.Button();
            this.btnFormulas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图像X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图像Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.机械X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.机械Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnClosePump);
            this.panel1.Controls.Add(this.btnOpenPump);
            this.panel1.Controls.Add(this.btnSetMcc);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnZeroCalib);
            this.panel1.Controls.Add(this.btnGetPos);
            this.panel1.Controls.Add(this.btnSetPos);
            this.panel1.Controls.Add(this.btnMove);
            this.panel1.Controls.Add(this.btnPicPos);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnClosePump
            // 
            this.btnClosePump.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosePump.Location = new System.Drawing.Point(1296, 8);
            this.btnClosePump.Name = "btnClosePump";
            this.btnClosePump.Size = new System.Drawing.Size(120, 36);
            this.btnClosePump.TabIndex = 78;
            this.btnClosePump.Text = "关闭气泵";
            this.btnClosePump.UseVisualStyleBackColor = true;
            this.btnClosePump.Click += new System.EventHandler(this.btnClosePump_Click);
            // 
            // btnOpenPump
            // 
            this.btnOpenPump.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenPump.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenPump.Location = new System.Drawing.Point(1160, 8);
            this.btnOpenPump.Name = "btnOpenPump";
            this.btnOpenPump.Size = new System.Drawing.Size(120, 36);
            this.btnOpenPump.TabIndex = 77;
            this.btnOpenPump.Text = "打开气泵";
            this.btnOpenPump.UseVisualStyleBackColor = false;
            this.btnOpenPump.Click += new System.EventHandler(this.btnOpenPump_Click);
            // 
            // btnSetMcc
            // 
            this.btnSetMcc.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetMcc.Location = new System.Drawing.Point(1024, 8);
            this.btnSetMcc.Name = "btnSetMcc";
            this.btnSetMcc.Size = new System.Drawing.Size(120, 36);
            this.btnSetMcc.TabIndex = 76;
            this.btnSetMcc.Text = "参数设置";
            this.btnSetMcc.UseVisualStyleBackColor = true;
            this.btnSetMcc.Click += new System.EventHandler(this.btnSetMcc_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTest.Location = new System.Drawing.Point(888, 8);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 36);
            this.btnTest.TabIndex = 75;
            this.btnTest.Text = "位置测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnZeroCalib
            // 
            this.btnZeroCalib.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZeroCalib.Location = new System.Drawing.Point(752, 8);
            this.btnZeroCalib.Name = "btnZeroCalib";
            this.btnZeroCalib.Size = new System.Drawing.Size(120, 36);
            this.btnZeroCalib.TabIndex = 74;
            this.btnZeroCalib.Text = "回归零点";
            this.btnZeroCalib.UseVisualStyleBackColor = true;
            this.btnZeroCalib.Click += new System.EventHandler(this.btnZeroCalib_Click);
            // 
            // btnGetPos
            // 
            this.btnGetPos.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetPos.Location = new System.Drawing.Point(440, 8);
            this.btnGetPos.Name = "btnGetPos";
            this.btnGetPos.Size = new System.Drawing.Size(120, 36);
            this.btnGetPos.TabIndex = 73;
            this.btnGetPos.Text = "取得位置";
            this.btnGetPos.UseVisualStyleBackColor = true;
            this.btnGetPos.Click += new System.EventHandler(this.btnGetPos_Click);
            // 
            // btnSetPos
            // 
            this.btnSetPos.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetPos.Location = new System.Drawing.Point(576, 8);
            this.btnSetPos.Name = "btnSetPos";
            this.btnSetPos.Size = new System.Drawing.Size(160, 36);
            this.btnSetPos.TabIndex = 72;
            this.btnSetPos.Text = "设置当前位置";
            this.btnSetPos.UseVisualStyleBackColor = true;
            this.btnSetPos.Click += new System.EventHandler(this.btnSetPos_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMove.Location = new System.Drawing.Point(301, 8);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(123, 36);
            this.btnMove.TabIndex = 71;
            this.btnMove.Text = "协动测试(疑问，暂存)";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPicPos
            // 
            this.btnPicPos.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPicPos.Location = new System.Drawing.Point(138, 8);
            this.btnPicPos.Name = "btnPicPos";
            this.btnPicPos.Size = new System.Drawing.Size(147, 36);
            this.btnPicPos.TabIndex = 23;
            this.btnPicPos.Text = "取得图像坐标";
            this.btnPicPos.UseVisualStyleBackColor = true;
            this.btnPicPos.Click += new System.EventHandler(this.btnPicPos_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShoot.Location = new System.Drawing.Point(17, 8);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(8);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(105, 36);
            this.btnShoot.TabIndex = 22;
            this.btnShoot.Text = "拍照";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEn);
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
            this.panel2.Size = new System.Drawing.Size(1429, 153);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1075, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "光栅尺：";
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(1152, 116);
            this.btnEn.Name = "btnEn";
            this.btnEn.ReadOnly = true;
            this.btnEn.Size = new System.Drawing.Size(264, 26);
            this.btnEn.TabIndex = 81;
            // 
            // labelZ
            // 
            this.labelZ.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelZ.Location = new System.Drawing.Point(189, 117);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(77, 22);
            this.labelZ.TabIndex = 80;
            this.labelZ.Text = "label6";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelY
            // 
            this.labelY.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelY.Location = new System.Drawing.Point(189, 68);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(77, 22);
            this.labelY.TabIndex = 79;
            this.labelY.Text = "label5";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX
            // 
            this.labelX.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX.Location = new System.Drawing.Point(189, 18);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(77, 22);
            this.labelX.TabIndex = 78;
            this.labelX.Text = "label5";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.Location = new System.Drawing.Point(1026, 114);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 29);
            this.button19.TabIndex = 77;
            this.button19.Text = ">|";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.Location = new System.Drawing.Point(1026, 65);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 29);
            this.button20.TabIndex = 76;
            this.button20.Text = ">|";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button21.Location = new System.Drawing.Point(1026, 15);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 29);
            this.button21.TabIndex = 75;
            this.button21.Text = ">|";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(910, 114);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 29);
            this.button14.TabIndex = 74;
            this.button14.Text = "|<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(910, 65);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 29);
            this.button16.TabIndex = 73;
            this.button16.Text = "|<";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(910, 15);
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
            this.comboBox1.Location = new System.Drawing.Point(1075, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1077, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 70;
            this.label4.Text = "图像坐标0，0\r\n机械坐标0，0";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(952, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 29);
            this.button10.TabIndex = 69;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(989, 114);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 29);
            this.button12.TabIndex = 68;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(952, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 29);
            this.button5.TabIndex = 67;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(989, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 29);
            this.button9.TabIndex = 66;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(952, 15);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 29);
            this.button17.TabIndex = 65;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(989, 15);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 29);
            this.button15.TabIndex = 64;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // hScrollBarZ
            // 
            this.hScrollBarZ.Location = new System.Drawing.Point(281, 116);
            this.hScrollBarZ.Maximum = 200;
            this.hScrollBarZ.Name = "hScrollBarZ";
            this.hScrollBarZ.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarZ.TabIndex = 38;
            this.hScrollBarZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // hScrollBarY
            // 
            this.hScrollBarY.Location = new System.Drawing.Point(281, 67);
            this.hScrollBarY.Maximum = 360;
            this.hScrollBarY.Name = "hScrollBarY";
            this.hScrollBarY.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarY.TabIndex = 37;
            this.hScrollBarY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // hScrollBarX
            // 
            this.hScrollBarX.Location = new System.Drawing.Point(281, 17);
            this.hScrollBarX.Maximum = 360;
            this.hScrollBarX.Name = "hScrollBarX";
            this.hScrollBarX.Size = new System.Drawing.Size(618, 25);
            this.hScrollBarX.TabIndex = 36;
            this.hScrollBarX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y坐标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "X坐标";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(76, 113);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(114, 26);
            this.textBoxZ.TabIndex = 2;
            this.textBoxZ.Text = "0";
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBoxZ_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(76, 64);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(114, 26);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.Text = "0";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(76, 14);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(114, 26);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1429, 400);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(576, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 400);
            this.panel4.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 299);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 101);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.btnDeleteLine);
            this.panel5.Controls.Add(this.btnAddLine);
            this.panel5.Controls.Add(this.btnLoadFormulas);
            this.panel5.Controls.Add(this.btnSaveFormulas);
            this.panel5.Controls.Add(this.btnFormulas);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(576, 299);
            this.panel5.TabIndex = 0;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteLine.Location = new System.Drawing.Point(138, 264);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(110, 29);
            this.btnDeleteLine.TabIndex = 78;
            this.btnDeleteLine.Text = "删除一行";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddLine.Location = new System.Drawing.Point(14, 264);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(110, 29);
            this.btnAddLine.TabIndex = 77;
            this.btnAddLine.Text = "增加一行";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnLoadFormulas
            // 
            this.btnLoadFormulas.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadFormulas.Location = new System.Drawing.Point(397, 222);
            this.btnLoadFormulas.Name = "btnLoadFormulas";
            this.btnLoadFormulas.Size = new System.Drawing.Size(106, 34);
            this.btnLoadFormulas.TabIndex = 76;
            this.btnLoadFormulas.Text = "装载坐标";
            this.btnLoadFormulas.UseVisualStyleBackColor = true;
            this.btnLoadFormulas.Click += new System.EventHandler(this.btnLoadFormulas_Click);
            // 
            // btnSaveFormulas
            // 
            this.btnSaveFormulas.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveFormulas.Location = new System.Drawing.Point(249, 222);
            this.btnSaveFormulas.Name = "btnSaveFormulas";
            this.btnSaveFormulas.Size = new System.Drawing.Size(128, 34);
            this.btnSaveFormulas.TabIndex = 75;
            this.btnSaveFormulas.Text = "保存坐标";
            this.btnSaveFormulas.UseVisualStyleBackColor = true;
            this.btnSaveFormulas.Click += new System.EventHandler(this.btnSaveFormulas_Click);
            // 
            // btnFormulas
            // 
            this.btnFormulas.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFormulas.Location = new System.Drawing.Point(12, 222);
            this.btnFormulas.Name = "btnFormulas";
            this.btnFormulas.Size = new System.Drawing.Size(217, 34);
            this.btnFormulas.TabIndex = 74;
            this.btnFormulas.Text = "生成转换公式并保存";
            this.btnFormulas.UseVisualStyleBackColor = true;
            this.btnFormulas.Click += new System.EventHandler(this.btnFormulas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.位置,
            this.图像X,
            this.图像Y,
            this.机械X,
            this.机械Y});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(576, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // 位置
            // 
            this.位置.HeaderText = "位置";
            this.位置.MinimumWidth = 6;
            this.位置.Name = "位置";
            this.位置.Width = 125;
            // 
            // 图像X
            // 
            this.图像X.HeaderText = "图像X";
            this.图像X.MinimumWidth = 6;
            this.图像X.Name = "图像X";
            this.图像X.Width = 110;
            // 
            // 图像Y
            // 
            this.图像Y.HeaderText = "图像Y";
            this.图像Y.MinimumWidth = 6;
            this.图像Y.Name = "图像Y";
            this.图像Y.Width = 110;
            // 
            // 机械X
            // 
            this.机械X.HeaderText = "机械X";
            this.机械X.MinimumWidth = 6;
            this.机械X.Name = "机械X";
            this.机械X.Width = 110;
            // 
            // 机械Y
            // 
            this.机械Y.HeaderText = "机械Y";
            this.机械Y.MinimumWidth = 6;
            this.机械Y.Name = "机械Y";
            this.机械Y.Width = 110;
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
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalibrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相机--控制台标定";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.CalibrationForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetPos;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnPicPos;
        private System.Windows.Forms.Button btnShoot;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图像X;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图像Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn 机械X;
        private System.Windows.Forms.DataGridViewTextBoxColumn 机械Y;
        private System.Windows.Forms.Button btnLoadFormulas;
        private System.Windows.Forms.Button btnSaveFormulas;
        private System.Windows.Forms.Button btnFormulas;
        private System.Windows.Forms.Button btnGetPos;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnZeroCalib;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnSetMcc;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button btnClosePump;
        private System.Windows.Forms.Button btnOpenPump;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btnEn;
    }
}
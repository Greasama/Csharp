namespace W13D3
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnJobStart = new System.Windows.Forms.Button();
            this.btnArmForm = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComClose = new System.Windows.Forms.Button();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Enabled = false;
            this.btnSetup.Location = new System.Drawing.Point(897, 10);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(120, 31);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "相机设置";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Enabled = false;
            this.btnShoot.Location = new System.Drawing.Point(771, 10);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(120, 31);
            this.btnShoot.TabIndex = 6;
            this.btnShoot.Text = "拍照";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(645, 10);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 31);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(519, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 31);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(359, 11);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(121, 28);
            this.cmbResolution.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "分辨率：";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(103, 11);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(173, 28);
            this.cmbCamera.TabIndex = 1;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择相机：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnSetup);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.cmbResolution);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCamera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 51);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnCalibration);
            this.panel2.Controls.Add(this.btnJobStart);
            this.panel2.Controls.Add(this.btnArmForm);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnComClose);
            this.panel2.Controls.Add(this.btnComOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 61);
            this.panel2.TabIndex = 2;
            // 
            // btnCalibration
            // 
            this.btnCalibration.Enabled = false;
            this.btnCalibration.Location = new System.Drawing.Point(776, 10);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(99, 41);
            this.btnCalibration.TabIndex = 8;
            this.btnCalibration.Text = "标定";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnJobStart
            // 
            this.btnJobStart.Enabled = false;
            this.btnJobStart.Location = new System.Drawing.Point(881, 10);
            this.btnJobStart.Name = "btnJobStart";
            this.btnJobStart.Size = new System.Drawing.Size(138, 41);
            this.btnJobStart.TabIndex = 19;
            this.btnJobStart.Text = "开始作业";
            this.btnJobStart.UseVisualStyleBackColor = true;
            this.btnJobStart.Click += new System.EventHandler(this.btnJobStart_Click);
            // 
            // btnArmForm
            // 
            this.btnArmForm.Enabled = false;
            this.btnArmForm.Font = new System.Drawing.Font("黑体", 12F);
            this.btnArmForm.Location = new System.Drawing.Point(643, 17);
            this.btnArmForm.Name = "btnArmForm";
            this.btnArmForm.Size = new System.Drawing.Size(120, 31);
            this.btnArmForm.TabIndex = 18;
            this.btnArmForm.Text = "操作机械臂";
            this.btnArmForm.UseVisualStyleBackColor = true;
            this.btnArmForm.Click += new System.EventHandler(this.btnArmForm_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "",
            "COM2",
            "",
            "COM3",
            "",
            "COM4",
            "",
            "COM5",
            "",
            "COM6",
            "",
            "COM7",
            "",
            "COM8",
            "",
            "COM9",
            "",
            "COM10",
            "",
            "COM11",
            "",
            "COM12",
            "",
            "COM13",
            "",
            "COM14",
            "",
            "COM15",
            "",
            "COM16",
            "",
            "COM17"});
            this.comboBox1.Location = new System.Drawing.Point(198, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 31);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "选择机械臂COM串口：";
            // 
            // btnComClose
            // 
            this.btnComClose.Enabled = false;
            this.btnComClose.Font = new System.Drawing.Font("黑体", 12F);
            this.btnComClose.Location = new System.Drawing.Point(517, 17);
            this.btnComClose.Name = "btnComClose";
            this.btnComClose.Size = new System.Drawing.Size(120, 31);
            this.btnComClose.TabIndex = 10;
            this.btnComClose.Text = "关闭";
            this.btnComClose.UseVisualStyleBackColor = true;
            this.btnComClose.Click += new System.EventHandler(this.btnComClose_Click);
            // 
            // btnComOpen
            // 
            this.btnComOpen.Font = new System.Drawing.Font("黑体", 12F);
            this.btnComOpen.Location = new System.Drawing.Point(391, 17);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(120, 31);
            this.btnComOpen.TabIndex = 9;
            this.btnComOpen.Text = "打开";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // vispShoot
            // 
            this.vispShoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vispShoot.Location = new System.Drawing.Point(0, 112);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(1039, 509);
            this.vispShoot.TabIndex = 3;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 621);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComClose;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnArmForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnJobStart;
    }
}


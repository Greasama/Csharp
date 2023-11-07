namespace 相机机械臂VisionPro联合编程
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMCC = new System.Windows.Forms.Button();
            this.btnJobStart = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnMode);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnMCC);
            this.panel1.Controls.Add(this.btnJobStart);
            this.panel1.Controls.Add(this.btnCalibration);
            this.panel1.Controls.Add(this.btnSetup);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.cmbResolution);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCamera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 97);
            this.panel1.TabIndex = 1;
            // 
            // btnMode
            // 
            this.btnMode.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMode.Location = new System.Drawing.Point(992, 54);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(162, 35);
            this.btnMode.TabIndex = 77;
            this.btnMode.Text = "其它模式";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(1023, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 33);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "调用VP";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZero.Location = new System.Drawing.Point(234, 54);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(146, 35);
            this.btnZero.TabIndex = 75;
            this.btnZero.Text = "HOME回零";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnMCC
            // 
            this.btnMCC.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMCC.Location = new System.Drawing.Point(7, 54);
            this.btnMCC.Name = "btnMCC";
            this.btnMCC.Size = new System.Drawing.Size(197, 35);
            this.btnMCC.TabIndex = 35;
            this.btnMCC.Text = "初始化运动控制卡";
            this.btnMCC.UseVisualStyleBackColor = true;
            this.btnMCC.Click += new System.EventHandler(this.btnMCC_Click);
            // 
            // btnJobStart
            // 
            this.btnJobStart.Enabled = false;
            this.btnJobStart.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJobStart.Location = new System.Drawing.Point(549, 54);
            this.btnJobStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobStart.Name = "btnJobStart";
            this.btnJobStart.Size = new System.Drawing.Size(416, 35);
            this.btnJobStart.TabIndex = 34;
            this.btnJobStart.Tag = "1";
            this.btnJobStart.Text = "测试：找AB物料识别搬运";
            this.btnJobStart.UseVisualStyleBackColor = true;
            this.btnJobStart.Click += new System.EventHandler(this.btnJobStart_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalibration.Location = new System.Drawing.Point(410, 54);
            this.btnCalibration.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(109, 35);
            this.btnCalibration.TabIndex = 33;
            this.btnCalibration.Tag = "1";
            this.btnCalibration.Text = "标定";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Enabled = false;
            this.btnSetup.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetup.Location = new System.Drawing.Point(848, 9);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(165, 33);
            this.btnSetup.TabIndex = 23;
            this.btnSetup.Text = "相机参数设置";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Enabled = false;
            this.btnShoot.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShoot.Location = new System.Drawing.Point(745, 9);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(5);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(93, 33);
            this.btnShoot.TabIndex = 21;
            this.btnShoot.Text = "拍照";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(542, 9);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 33);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(362, 12);
            this.cmbResolution.Margin = new System.Windows.Forms.Padding(5);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(170, 27);
            this.cmbResolution.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(283, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "分辨率";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(102, 12);
            this.cmbCamera.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(171, 27);
            this.cmbCamera.TabIndex = 10;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择相机";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnect.Location = new System.Drawing.Point(645, 9);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 33);
            this.btnDisconnect.TabIndex = 22;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // vispShoot
            // 
            this.vispShoot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vispShoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vispShoot.Location = new System.Drawing.Point(0, 97);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(1176, 530);
            this.vispShoot.TabIndex = 2;
            this.vispShoot.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 627);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相机--控制台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button btnJobStart;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnMCC;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMode;
    }
}


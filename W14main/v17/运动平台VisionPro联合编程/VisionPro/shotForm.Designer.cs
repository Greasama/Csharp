namespace 相机机械臂VisionPro联合编程
{
    partial class shotForm
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
            this.btnEditVpp = new System.Windows.Forms.Button();
            this.btnRunVpp = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnEditVpp);
            this.panel1.Controls.Add(this.btnRunVpp);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnEditVpp
            // 
            this.btnEditVpp.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditVpp.Location = new System.Drawing.Point(733, 15);
            this.btnEditVpp.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditVpp.Name = "btnEditVpp";
            this.btnEditVpp.Size = new System.Drawing.Size(220, 40);
            this.btnEditVpp.TabIndex = 20;
            this.btnEditVpp.Text = "编辑VPP项目";
            this.btnEditVpp.UseVisualStyleBackColor = true;
            this.btnEditVpp.Click += new System.EventHandler(this.btnEditVpp_Click);
            // 
            // btnRunVpp
            // 
            this.btnRunVpp.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunVpp.Location = new System.Drawing.Point(490, 15);
            this.btnRunVpp.Margin = new System.Windows.Forms.Padding(5);
            this.btnRunVpp.Name = "btnRunVpp";
            this.btnRunVpp.Size = new System.Drawing.Size(234, 40);
            this.btnRunVpp.TabIndex = 19;
            this.btnRunVpp.Text = "运行VPP项目";
            this.btnRunVpp.UseVisualStyleBackColor = true;
            this.btnRunVpp.Click += new System.EventHandler(this.btnRunVpp_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(290, 15);
            this.btnSet.Margin = new System.Windows.Forms.Padding(5);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(191, 40);
            this.btnSet.TabIndex = 18;
            this.btnSet.Text = "相机参数设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(156, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "保存图片";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShoot.Location = new System.Drawing.Point(17, 15);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(5);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(130, 40);
            this.btnShoot.TabIndex = 16;
            this.btnShoot.Text = "重新拍照";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.bmp|*.bmp";
            this.saveFileDialog1.Filter = "*.bmp|*.bmp|所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.vpp|*.vpp";
            this.openFileDialog1.Filter = "*.vpp|*.vpp|所有文件|*.*";
            // 
            // shotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "shotForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相机调用VisionPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRunVpp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEditVpp;
    }
}
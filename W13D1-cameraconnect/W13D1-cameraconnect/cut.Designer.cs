namespace W13D1_cameraconnect
{
    partial class cut
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.btnSetup2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReCut = new System.Windows.Forms.Button();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnApp);
            this.panel1.Controls.Add(this.btnSetup2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReCut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(622, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(218, 58);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑一个VPP项目";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(397, 13);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(218, 58);
            this.btnApp.TabIndex = 3;
            this.btnApp.Text = "运行一个VPP项目";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // btnSetup2
            // 
            this.btnSetup2.Location = new System.Drawing.Point(269, 13);
            this.btnSetup2.Name = "btnSetup2";
            this.btnSetup2.Size = new System.Drawing.Size(122, 58);
            this.btnSetup2.TabIndex = 2;
            this.btnSetup2.Text = "相机设置";
            this.btnSetup2.UseVisualStyleBackColor = true;
            this.btnSetup2.Click += new System.EventHandler(this.btnSetup2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 58);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存图片";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReCut
            // 
            this.btnReCut.Location = new System.Drawing.Point(13, 13);
            this.btnReCut.Name = "btnReCut";
            this.btnReCut.Size = new System.Drawing.Size(122, 58);
            this.btnReCut.TabIndex = 0;
            this.btnReCut.Text = "重新拍照";
            this.btnReCut.UseVisualStyleBackColor = true;
            this.btnReCut.Click += new System.EventHandler(this.btnReCut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 590);
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
            // cut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cut";
            this.ShowInTaskbar = false;
            this.Text = "cut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSetup2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReCut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEdit;
    }
}
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnMCC = new System.Windows.Forms.Button();
            this.btnJobStart = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnMCC);
            this.panel1.Controls.Add(this.btnJobStart);
            this.panel1.Controls.Add(this.btnCalibration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 97);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(269, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 48);
            this.button4.TabIndex = 75;
            this.button4.Text = "回归零点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnMCC
            // 
            this.btnMCC.Location = new System.Drawing.Point(7, 25);
            this.btnMCC.Name = "btnMCC";
            this.btnMCC.Size = new System.Drawing.Size(256, 48);
            this.btnMCC.TabIndex = 35;
            this.btnMCC.Text = "初始化运动控制卡";
            this.btnMCC.UseVisualStyleBackColor = true;
            this.btnMCC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnJobStart
            // 
            this.btnJobStart.Enabled = false;
            this.btnJobStart.Location = new System.Drawing.Point(554, 26);
            this.btnJobStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobStart.Name = "btnJobStart";
            this.btnJobStart.Size = new System.Drawing.Size(135, 47);
            this.btnJobStart.TabIndex = 34;
            this.btnJobStart.Tag = "1";
            this.btnJobStart.Text = "开始作业";
            this.btnJobStart.UseVisualStyleBackColor = true;
            this.btnJobStart.Click += new System.EventHandler(this.btnJobStart_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(411, 25);
            this.btnCalibration.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(135, 48);
            this.btnCalibration.TabIndex = 33;
            this.btnCalibration.Tag = "1";
            this.btnCalibration.Text = "标定";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 627);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJobStart;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnMCC;
        private System.Windows.Forms.Button button4;
    }
}


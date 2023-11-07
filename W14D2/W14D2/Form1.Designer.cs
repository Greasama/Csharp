namespace W14D2
{
    partial class Form1
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnAwake = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.ShowList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(64, 56);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 43);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "创建线程";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnHang
            // 
            this.btnHang.Location = new System.Drawing.Point(64, 128);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(121, 43);
            this.btnHang.TabIndex = 1;
            this.btnHang.Text = "挂起线程";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnAwake
            // 
            this.btnAwake.Location = new System.Drawing.Point(64, 200);
            this.btnAwake.Name = "btnAwake";
            this.btnAwake.Size = new System.Drawing.Size(121, 43);
            this.btnAwake.TabIndex = 2;
            this.btnAwake.Text = "唤醒线程";
            this.btnAwake.UseVisualStyleBackColor = true;
            this.btnAwake.Click += new System.EventHandler(this.btnAwake_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(64, 272);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(121, 43);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "终止线程";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ShowList
            // 
            this.ShowList.FormattingEnabled = true;
            this.ShowList.ItemHeight = 15;
            this.ShowList.Location = new System.Drawing.Point(237, 26);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(231, 394);
            this.ShowList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowList);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAwake);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button btnAwake;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ListBox ShowList;
    }
}


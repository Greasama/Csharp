namespace W12D3_2
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
            this.rtxtRTF = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.TextInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtRTF
            // 
            this.rtxtRTF.Location = new System.Drawing.Point(0, 0);
            this.rtxtRTF.Name = "rtxtRTF";
            this.rtxtRTF.Size = new System.Drawing.Size(621, 382);
            this.rtxtRTF.TabIndex = 0;
            this.rtxtRTF.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 388);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 33);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(401, 388);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(209, 33);
            this.TextOutput.TabIndex = 2;
            this.TextOutput.Text = "";
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(124, 388);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(258, 33);
            this.TextInput.TabIndex = 3;
            this.TextInput.Text = "请输入要查找的字符";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.rtxtRTF);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtRTF;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.RichTextBox TextInput;
    }
}


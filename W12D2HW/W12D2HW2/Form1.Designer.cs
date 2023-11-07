namespace W12D2HW2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.TextBox();
            this.Maths = new System.Windows.Forms.TextBox();
            this.English = new System.Windows.Forms.TextBox();
            this.Chemistry = new System.Windows.Forms.TextBox();
            this.Physics = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "语文：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "数学：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "英语：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "化学：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "物理：";
            // 
            // Chinese
            // 
            this.Chinese.Location = new System.Drawing.Point(99, 28);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(100, 25);
            this.Chinese.TabIndex = 5;
            // 
            // Maths
            // 
            this.Maths.Location = new System.Drawing.Point(99, 83);
            this.Maths.Name = "Maths";
            this.Maths.Size = new System.Drawing.Size(100, 25);
            this.Maths.TabIndex = 6;
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(99, 138);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(100, 25);
            this.English.TabIndex = 7;
            // 
            // Chemistry
            // 
            this.Chemistry.Location = new System.Drawing.Point(99, 193);
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Size = new System.Drawing.Size(100, 25);
            this.Chemistry.TabIndex = 8;
            // 
            // Physics
            // 
            this.Physics.Location = new System.Drawing.Point(99, 248);
            this.Physics.Name = "Physics";
            this.Physics.Size = new System.Drawing.Size(100, 25);
            this.Physics.TabIndex = 9;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(277, 28);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(271, 209);
            this.result.TabIndex = 10;
            this.result.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "清空日志";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Physics);
            this.Controls.Add(this.Chemistry);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Maths);
            this.Controls.Add(this.Chinese);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Chinese;
        private System.Windows.Forms.TextBox Maths;
        private System.Windows.Forms.TextBox English;
        private System.Windows.Forms.TextBox Chemistry;
        private System.Windows.Forms.TextBox Physics;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


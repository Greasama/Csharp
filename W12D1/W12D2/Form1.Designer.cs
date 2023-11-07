namespace W12D2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAccount = new TextBox();
            txtPwd = new TextBox();
            btnCheck = new Button();
            label3 = new Label();
            rabMale = new RadioButton();
            rabFemale = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 69);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(97, 62);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(225, 27);
            txtAccount.TabIndex = 2;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(97, 109);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(225, 27);
            txtPwd.TabIndex = 3;
            txtPwd.UseSystemPasswordChar = true;
            txtPwd.TextChanged += txtPwd_TextChanged;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(340, 69);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "确认";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 154);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "性别：";
            // 
            // rabMale
            // 
            rabMale.AutoSize = true;
            rabMale.Location = new Point(97, 150);
            rabMale.Name = "rabMale";
            rabMale.Size = new Size(45, 24);
            rabMale.TabIndex = 6;
            rabMale.TabStop = true;
            rabMale.Text = "男";
            rabMale.UseVisualStyleBackColor = true;
            // 
            // rabFemale
            // 
            rabFemale.AutoSize = true;
            rabFemale.Location = new Point(229, 150);
            rabFemale.Name = "rabFemale";
            rabFemale.Size = new Size(45, 24);
            rabFemale.TabIndex = 7;
            rabFemale.TabStop = true;
            rabFemale.Text = "女";
            rabFemale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 193);
            Controls.Add(rabFemale);
            Controls.Add(rabMale);
            Controls.Add(label3);
            Controls.Add(btnCheck);
            Controls.Add(txtPwd);
            Controls.Add(txtAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAccount;
        private TextBox txtPwd;
        private Button btnCheck;
        private Label label3;
        private RadioButton rabMale;
        private RadioButton rabFemale;
    }
}
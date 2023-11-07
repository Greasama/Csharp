namespace W14D1
{
    partial class MainForm
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
            this.btntest = new System.Windows.Forms.Button();
            this.curveControl1 = new W14D1.CurveControl();
            this.SuspendLayout();
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(23, 92);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(93, 35);
            this.btntest.TabIndex = 1;
            this.btntest.Text = "线程";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.button1_Click);
            // 
            // curveControl1
            // 
            this.curveControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curveControl1.Location = new System.Drawing.Point(0, 0);
            this.curveControl1.Name = "curveControl1";
            this.curveControl1.Size = new System.Drawing.Size(800, 450);
            this.curveControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.curveControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CurveControl curveControl1;
        private System.Windows.Forms.Button btntest;
    }
}
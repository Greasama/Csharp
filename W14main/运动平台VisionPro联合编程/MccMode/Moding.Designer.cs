namespace 相机机械臂VisionPro联合编程.MccCard
{
    partial class Moding
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
            this.btnJOG = new System.Windows.Forms.Button();
            this.btnGear = new System.Windows.Forms.Button();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.btnPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJOG
            // 
            this.btnJOG.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJOG.Location = new System.Drawing.Point(12, 12);
            this.btnJOG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJOG.Name = "btnJOG";
            this.btnJOG.Size = new System.Drawing.Size(133, 64);
            this.btnJOG.TabIndex = 0;
            this.btnJOG.Text = "JOG模式";
            this.btnJOG.UseVisualStyleBackColor = true;
            this.btnJOG.Click += new System.EventHandler(this.btnJOG_Click);
            // 
            // btnGear
            // 
            this.btnGear.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGear.Location = new System.Drawing.Point(171, 12);
            this.btnGear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGear.Name = "btnGear";
            this.btnGear.Size = new System.Drawing.Size(133, 64);
            this.btnGear.TabIndex = 1;
            this.btnGear.Text = "Gear模式";
            this.btnGear.UseVisualStyleBackColor = true;
            this.btnGear.Click += new System.EventHandler(this.btnGear_Click);
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInterpolation.Location = new System.Drawing.Point(331, 12);
            this.btnInterpolation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(133, 64);
            this.btnInterpolation.TabIndex = 2;
            this.btnInterpolation.Text = "插补模式";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // btnPT
            // 
            this.btnPT.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPT.Location = new System.Drawing.Point(489, 12);
            this.btnPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPT.Name = "btnPT";
            this.btnPT.Size = new System.Drawing.Size(133, 64);
            this.btnPT.TabIndex = 3;
            this.btnPT.Text = "激光调用";
            this.btnPT.UseVisualStyleBackColor = true;
            this.btnPT.Click += new System.EventHandler(this.btnPT_Click);
            // 
            // Moding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 94);
            this.Controls.Add(this.btnPT);
            this.Controls.Add(this.btnInterpolation);
            this.Controls.Add(this.btnGear);
            this.Controls.Add(this.btnJOG);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Moding";
            this.Text = "Moding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJOG;
        private System.Windows.Forms.Button btnGear;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.Button btnPT;
    }
}
﻿namespace W13D1_cameraconnect
{
    partial class Edit
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
            this.cogJobManagerEdit1 = new Cognex.VisionPro.QuickBuild.CogJobManagerEdit();
            this.SuspendLayout();
            // 
            // cogJobManagerEdit1
            // 
            this.cogJobManagerEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogJobManagerEdit1.Location = new System.Drawing.Point(0, 0);
            this.cogJobManagerEdit1.Name = "cogJobManagerEdit1";
            this.cogJobManagerEdit1.ShowLocalizationTab = true;
            this.cogJobManagerEdit1.Size = new System.Drawing.Size(800, 450);
            this.cogJobManagerEdit1.Subject = null;
            this.cogJobManagerEdit1.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cogJobManagerEdit1);
            this.Name = "Edit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.QuickBuild.CogJobManagerEdit cogJobManagerEdit1;
    }
}
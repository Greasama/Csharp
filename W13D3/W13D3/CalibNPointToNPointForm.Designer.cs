namespace W13D3
{
    partial class CalibNPointToNPointForm
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
            this.cogCalibNPointToNPointEditV21 = new Cognex.VisionPro.CalibFix.CogCalibNPointToNPointEditV2();
            ((System.ComponentModel.ISupportInitialize)(this.cogCalibNPointToNPointEditV21)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 100);
            this.panel1.TabIndex = 0;
            // 
            // cogCalibNPointToNPointEditV21
            // 
            this.cogCalibNPointToNPointEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogCalibNPointToNPointEditV21.Location = new System.Drawing.Point(0, 100);
            this.cogCalibNPointToNPointEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogCalibNPointToNPointEditV21.Name = "cogCalibNPointToNPointEditV21";
            this.cogCalibNPointToNPointEditV21.Size = new System.Drawing.Size(990, 557);
            this.cogCalibNPointToNPointEditV21.SuspendElectricRuns = false;
            this.cogCalibNPointToNPointEditV21.TabIndex = 1;
            // 
            // CalibNPointToNPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 657);
            this.Controls.Add(this.cogCalibNPointToNPointEditV21);
            this.Controls.Add(this.panel1);
            this.Name = "CalibNPointToNPointForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cogCalibNPointToNPointEditV21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cognex.VisionPro.CalibFix.CogCalibNPointToNPointEditV2 cogCalibNPointToNPointEditV21;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video.DirectShow;

namespace 相机机械臂VisionPro联合编程
{
    
    public partial class shotForm : Form
    {
        public VideoSourcePlayer vispShoot;
        public shotForm()
        {
            InitializeComponent();
        }
        private void btnShoot_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK) 
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            }
        }

        private void btnRunVpp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenVpp form = new OpenVpp();
                form.Run(openFileDialog1.FileName, pictureBox1.Image);
                form.ShowDialog();
            }
        }

        private void btnEditVpp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EditVpp form = new EditVpp();
                form.Run(openFileDialog1.FileName);
                form.ShowDialog();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
           ((VideoCaptureDevice)(vispShoot.VideoSource)).
                DisplayPropertyPage(IntPtr.Zero); 
            //显示带有摄像头控件的窗口
        }
    }
}

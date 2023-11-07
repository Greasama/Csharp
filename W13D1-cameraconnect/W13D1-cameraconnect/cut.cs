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
using Microsoft.Win32;

namespace W13D1_cameraconnect
{
    public partial class cut : Form
    {
        public VideoSourcePlayer vispShoot;
        public cut()
        {
            InitializeComponent();
        }

        private void btnSetup2_Click(object sender, EventArgs e)
        {
                ((VideoCaptureDevice)(vispShoot.VideoSource)).
                    DisplayPropertyPage(IntPtr.Zero);//强转
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            }
        }

        private void btnReCut_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                open_vpp form = new open_vpp();
                form.Run(openFileDialog1.FileName, pictureBox1.Image);
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit form = new Edit();
                form.Run(openFileDialog1.FileName);
                form.ShowDialog();
            }
        }
    }
}

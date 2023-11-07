using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace W13D3
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection videoDevices
    = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        public VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;
        public CRobotArm CRobotArm1 = new CRobotArm();
        public VisionJob visionJob = new VisionJob();
        //装载功能
        public MainForm()
        {
            InitializeComponent();
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cmbCamera.Items.Add(device.Name);
                }
            }
            visionJob.vispShoot = vispShoot;
            visionJob.CRobotArm1 = CRobotArm1;
            visionJob.LoadArm();
        }
        bool VideoDeviceIsOpen = false;
        bool armIsOpen = false;
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cmbResolution.Items.Clear();
            videoCapabilities = videoCaptureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                cmbResolution.Items.Add($"" +
                    $"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cmbResolution.SelectedIndex = 0;
        }
        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCamera.SelectedIndex != 0)
            {
                videoDevice = new VideoCaptureDevice
                    (videoDevices[cmbCamera.SelectedIndex].MonikerString);
                GetDeviceResolution(videoDevice);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cmbResolution.SelectedIndex];
                    vispShoot.VideoSource = videoDevice;
                    vispShoot.Start();
                    VideoDeviceOpened();
                }
            }
        }
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
            VideoDeviceClosed();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                videoDevice.DisplayPropertyPage(IntPtr.Zero);
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            //实现拍照功能
            cut form = new cut();
            form.vispShoot = vispShoot;
            form.pictureBox1.Image = img;
            form.ShowDialog();
        }

        UarmForm armForm = new UarmForm();
        private void btnArmForm_Click(object sender, EventArgs e)
        {
            armForm.Opened();
            armForm.GetState();
            armForm.ShowDialog();
        }
        private void btnComOpen_Click(object sender, EventArgs e)
        {
            armForm.CRobotArm1 = CRobotArm1;
            //对象在主窗口，位置更合理
            if (CRobotArm1.ConnectRobot(comboBox1.Text))
            {
                ArmOpened();
            }
            else
            {
                MessageBox.Show("串口打开失败");
            }
            //ArmOpened();//测试代码
        }
        void VideoDeviceOpened()
        {
            btnDisconnect.Enabled = true;
            btnShoot.Enabled = true;
            btnSetup.Enabled = true;
            btnConnect.Enabled = false;
            VideoDeviceIsOpen = true;

            if (VideoDeviceIsOpen && armIsOpen)
            {
                btnCalibration.Enabled = true;
                btnJobStart.Enabled = true;
            }
        }
        void VideoDeviceClosed()
        {
            btnDisconnect.Enabled = false;
            btnShoot.Enabled = false;
            btnSetup.Enabled = false;
            btnConnect.Enabled = true;
            VideoDeviceIsOpen = false;
            btnCalibration.Enabled = false;
            btnJobStart.Enabled = false;
        }
        void ArmOpened()
        {
            armIsOpen = true;
            btnComOpen.Enabled = false;
            btnArmForm.Enabled = true;
            btnComClose.Enabled = true;

            if (VideoDeviceIsOpen && armIsOpen)
            {
                btnCalibration.Enabled = true;
                btnJobStart.Enabled = true;
            }
        }
        void ArmClosed()
        {
            armIsOpen = false;
            btnComOpen.Enabled = true;
            btnArmForm.Enabled = false;
            btnComClose.Enabled = false;
            btnCalibration.Enabled = false;
            btnJobStart.Enabled = false;
        }

        private void btnComClose_Click(object sender, EventArgs e)
        {
            CRobotArm1.DisConnectRobot();
            ArmClosed();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            CalibForm form = new CalibForm();
            form.vispShoot = vispShoot;
            form.CRobotArm1 = CRobotArm1;
            form.visionJob = visionJob;
            form.init();
            form.ShowDialog();
        }

        private void btnJobStart_Click(object sender, EventArgs e)
        {
            visionJob.RunArm();
        }
    }
}

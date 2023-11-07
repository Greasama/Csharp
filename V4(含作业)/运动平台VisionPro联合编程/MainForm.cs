using AForge.Video.DirectShow;
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

namespace 相机机械臂VisionPro联合编程
{
    public partial class MainForm : Form
    {
        //相机列表的集合类
        private FilterInfoCollection videoDevices =
            new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //当前选中的相机对象
        public VideoCaptureDevice videoDevice;
        //当前选中的相机的分辨率数组
        private VideoCapabilities[] videoCapabilities;

        public CRobotArm CRobotArm1 = new CRobotArm();
        public MCCard myMCC = new MCCard();
        public VisionJob visionJob= new VisionJob(); 
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
            visionJob.myMCC = myMCC;;
            visionJob.Load();
        }
        bool videoDeviceIsOpen = false;
        bool armIsOpen = false;
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cmbResolution.Items.Clear();
            videoCapabilities = videoCaptureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                cmbResolution.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cmbResolution.SelectedIndex = 0;
        }
        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                //根据所选项，生成相机对象
                videoDevice = new VideoCaptureDevice(videoDevices[cmbCamera.SelectedIndex].MonikerString);
                //取得分辨率数组及设置第一个为所选分辨率
                GetDeviceResolution(videoDevice);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    //设置分辨率
                    videoDevice.VideoResolution = videoCapabilities[cmbResolution.SelectedIndex];
                    //设置相机
                    vispShoot.VideoSource = videoDevice;
                    //开始录像
                    vispShoot.Start();
                    videoDeviceOpended();
                }
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                videoDevice.DisplayPropertyPage(IntPtr.Zero); //这将显示带有摄像头控件的窗
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            shotForm form = new shotForm();
            form.vispShoot = vispShoot;
            form.pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
            form.ShowDialog();
        }
        UarmForm armForm=new UarmForm();
        private void button4_Click(object sender, EventArgs e)
        {
            armForm.Opened();
            armForm.GetState();
            armForm.ShowDialog();
            
        }


        void videoDeviceOpended()
        {
            btnDisconnect.Enabled = true;
            btnShoot.Enabled = true;
            btnSetup.Enabled = true;
            btnConnect.Enabled = false;
            videoDeviceIsOpen = true;

            //if (videoDeviceIsOpen && armIsOpen)
            {
                btnCalibration.Enabled = true;
                btnJobStart.Enabled = true;
            }
        }
        void videoDeviceCloseed()
        {
            btnDisconnect.Enabled = false;
            btnShoot.Enabled = false;
            btnSetup.Enabled = false;
            btnConnect.Enabled = true;
            videoDeviceIsOpen = false;

            btnCalibration.Enabled = false;
            btnJobStart.Enabled = false;
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
            videoDeviceCloseed();
        }



        private void btnCalibration_Click(object sender, EventArgs e)
        {
            CalibrationForm form = new CalibrationForm();
            form.vispShoot= vispShoot;
            form.myMCC= myMCC;
            form.visionJob =visionJob;

            form.init();
            form.ShowDialog();

        }

        private void btnJobStart_Click(object sender, EventArgs e)
        {
            visionJob.Run();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (myMCC.OpenGTSCardAndInit())
            {
                btnMCC.Enabled = false;
                armIsOpen = true;
              //  if (videoDeviceIsOpen && armIsOpen)
                {
                    btnCalibration.Enabled = true;
                    btnJobStart.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("打开运动控制卡失败！");
            }
        }
    }
}

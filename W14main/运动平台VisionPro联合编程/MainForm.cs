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
using 相机机械臂VisionPro联合编程.MccCard;

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
            visionJob.myMCC = myMCC;
            visionJob.Load();
        }
        bool videoDeviceIsOpen = false;
        bool armIsOpen = false;
        //添加设备分辨率到列表的方法
        //添加相机分辨率数组到ComboBox中
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
        //连接相机
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
        //调用相机参数
        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                videoDevice.DisplayPropertyPage(IntPtr.Zero); 
                //这将显示带有摄像头控件的窗口
            }
        }
        //相机拍照
        private void btnShoot_Click(object sender, EventArgs e)
        {
            shotForm form = new shotForm();
            form.vispShoot = vispShoot;
            form.pictureBox1.Image = vispShoot.GetCurrentVideoFrame();
            form.ShowDialog();
        }
        //相机设备启动（可不用安全判断，已注释）
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
        //设备关闭
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
        //设备断开连接
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
            //进入Calib界面
            form.init();
            form.ShowDialog();

        }

        private void btnJobStart_Click(object sender, EventArgs e)
        {
            //VPP联合编程方法
            visionJob.Run();
        }

        private void btnMCC_Click(object sender, EventArgs e)
        {
            //打开运动控制卡（含安全判定）
            if (myMCC.Open())
            {
                btnMCC.Enabled = false;
                armIsOpen = true;
                if (videoDeviceIsOpen && armIsOpen)
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
        //回零
        private void btnZero_Click(object sender, EventArgs e)
        {
            myMCC.ReturnZeroAb(false);
        }
        //调用VisionPro编辑图像
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditVpp form = new EditVpp();
            form.ShowDialog(this);
        }
        //其它运动模式（初步选择JOG和插补）
        private void btnMode_Click(object sender, EventArgs e)
        {
            Moding form = new Moding();
            form.vispShoot=vispShoot;
            form.ShowDialog(this);
        }
    }
}

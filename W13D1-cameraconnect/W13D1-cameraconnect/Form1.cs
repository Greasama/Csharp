using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W13D1_cameraconnect
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices
            = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //所有相机列表的集合类
        public VideoCaptureDevice videoDevice;
        //抓取图像的对象(当前选中的相机对象)
        private VideoCapabilities[] videoCapabilities;
        //分辨率数组（当前选中的相机）
        public Form1()
        {
            InitializeComponent();
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cmbCamera.Items.Add(device.Name);
                }
                //遍历增加相机列表（和下文含义一致）
                //for (int i = 0; i < videoDevices.Count; i++)
                //{
                //    FilterInfo device = videoDevices[i];
                //    cmbCamera.Items.Add(device.Name);
                //}
            }
        }

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
            if (cmbCamera.SelectedIndex != 0) 
            { 
                //根据所选项，生成相机对象
                videoDevice = new VideoCaptureDevice(videoDevices[cmbCamera.SelectedIndex].MonikerString);
                //查阅设备ID（确定设备），查阅分辨率列表
                //取得分辨率数组及设置第一个为所选分辨率
                GetDeviceResolution(videoDevice);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //判定相机连接，分辨率读取
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    //设置分辨率
                    videoDevice.VideoResolution = videoCapabilities[cmbResolution.SelectedIndex];
                    //设置相机
                    vispShoot.VideoSource = videoDevice;
                    //开启录像
                    vispShoot.Start();
                }
            }
        }

        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                //切断信号
                vispShoot.WaitForStop();
                //等待停机
                vispShoot.VideoSource = null;
                //数据清除
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                videoDevice.DisplayPropertyPage(IntPtr.Zero); 
                //这将显示带有摄像头控件的窗口
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
    }
}

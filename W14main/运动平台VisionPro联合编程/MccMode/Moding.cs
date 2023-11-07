using AForge.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 相机机械臂VisionPro联合编程.MccMode;

namespace 相机机械臂VisionPro联合编程.MccCard
{
    public partial class Moding : Form
    {
        public MCCard myMCC;
        public Moding()
        {
            InitializeComponent();
        }
        public VideoSourcePlayer vispShoot;
        public short sRtn;
        private void btnJOG_Click(object sender, EventArgs e)
        {
            JOGMode form = new JOGMode();
            Control oldParent = vispShoot.Parent;
            form.vispShoot = vispShoot;



            vispShoot.Parent = form;


            form.ShowDialog(this);
            vispShoot.Parent = oldParent;
            //镜头的转换位置，从main到JOG
        }

        private void btnGear_Click(object sender, EventArgs e)
        {
            GearMode form = new GearMode();
            Control oldParent = vispShoot.Parent;
            form.vispShoot = vispShoot;
            vispShoot.Parent = form;
            form.ShowDialog(this);
            vispShoot.Parent = oldParent;
            //镜头的转换位置，从main到Gear
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            InterpolationMode form = new InterpolationMode();
            Control oldParent = vispShoot.Parent;
            form.vispShoot = vispShoot;
            vispShoot.Parent = form;
            form.ShowDialog(this);
            vispShoot.Parent = oldParent;
            //镜头的转换位置，从main到Interpolation
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            LaserMode form = new LaserMode();
            Control oldParent = vispShoot.Parent;
            form.vispShoot = vispShoot;
            vispShoot.Parent = form;
            form.ShowDialog(this);
            vispShoot.Parent = oldParent;
            //镜头的转换位置，从main到PT
        }
    }
}

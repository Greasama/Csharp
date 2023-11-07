using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 相机机械臂VisionPro联合编程
{
    public partial class EditVpp : Form
    {
        public EditVpp()
        {
            InitializeComponent();
        }
        public void Run(string VppFile)
        {
            CogJobManager CogJobManager1 = (CogJobManager)CogSerializer.LoadObjectFromFile(VppFile);
            cogJobManagerEdit1.Subject = CogJobManager1;
        }
        //调用Edit界面
    }
}

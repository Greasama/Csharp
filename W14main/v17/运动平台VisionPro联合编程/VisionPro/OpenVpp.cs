using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;
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
    public partial class OpenVpp : Form
    {
        public OpenVpp()
        {
            InitializeComponent();
        }
        CogJobManager CogJobManager1;
        //建立工作向导
        CogToolGroup CogToolGroup1;
        //建立工作组

        public void Run(string VPPFile, Image img)
        {
            CogJobManager1
                = (CogJobManager)CogSerializer.LoadObjectFromFile(VPPFile);
            //获取对应工作
            CogToolGroup1
                = CogJobManager1.Job(0).VisionTool as CogToolGroup;
            //获取job中的工作组
            CogImageConvertTool CogImageConvertTool1
                = (CogImageConvertTool)CogToolGroup1.Tools["CogImageConvertTool1"];
            //依据工作组名称去找到对象
            CogImageConvertTool1.InputImage = new CogImage8Grey(new Bitmap(img));
            //转灰度图处理
            CogToolGroup1.Run();

            ICogRecord ICogRecord1
                = CogToolGroup1.CreateLastRunRecord();
            //由工作组运行产生运行一系列记录
            cogRecordDisplay1.Record
                = ICogRecord1.SubRecords
                ["CogImageConvertTool1.OutputImage"];
            //找到对应所需的output，并进行输出
            cogRecordDisplay1.Fit();
            //显示运行结果

        }
    }
}

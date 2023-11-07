using AForge.Controls;
using AForge.Video.DirectShow;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 相机机械臂VisionPro联合编程
{
    public class VisionJob
    {

        public CogTransform2DLinear form2D1 = new CogTransform2DLinear();
        public VideoSourcePlayer vispShoot;
        public MCCard myMCC = new MCCard();


        public void Save()
        {
            MyApp.SetValue("平移X", form2D1.TranslationX.ToString());
            MyApp.SetValue("平移Y", form2D1.TranslationY.ToString());
            MyApp.SetValue("旋转", form2D1.Rotation.ToString());
            MyApp.SetValue("缩放", form2D1.Scaling.ToString());
            MyApp.SetValue("横纵比", form2D1.Aspect.ToString());
            MyApp.SetValue("倾斜", form2D1.Skew.ToString());
        }
        public void Load()
        {
            form2D1.TranslationX = MyApp.GetValueAsDouble("平移X");
            form2D1.TranslationY = MyApp.GetValueAsDouble("平移Y");
            form2D1.Rotation = MyApp.GetValueAsDouble("旋转");
            form2D1.Scaling = MyApp.GetValueAsDouble("缩放",1);
            form2D1.Aspect = MyApp.GetValueAsDouble("横纵比",1);
            form2D1.Skew = MyApp.GetValueAsDouble("倾斜");
        }
        bool done = false;
        public void Run()
        {
            if (!done)
            {
                myMCC.回归零点();
                done = true;
            }
            myMCC.MoveXYZWait(0, myMCC.EndY, 0);
            string VppFile = Application.StartupPath + "//找AB物体.vpp";
            CogJobManager CogJobManager1 = (CogJobManager)CogSerializer.LoadObjectFromFile(VppFile);
            CogToolGroup CogToolGroup1 = CogJobManager1.Job(0).VisionTool as CogToolGroup;
            //获取job中的工具
            CogImageConvertTool CogImageConvertTool1 = (CogImageConvertTool)CogToolGroup1.Tools["CogImageConvertTool1"];
            CogPMAlignTool CogPMAlignToolA = (CogPMAlignTool)CogToolGroup1.Tools["CogPMAlignTool1"];

            while (true)
            {
               Bitmap img =  vispShoot.GetCurrentVideoFrame();
               CogImageConvertTool1.InputImage = new CogImage8Grey(img);
               CogToolGroup1.Run();
                if (CogPMAlignToolA.Results.Count == 2)
                {
                    double x1, y1, x2, y2;
                    CogTransform2DLinear linearA = CogPMAlignToolA.Results[0].GetPose();
                    x1= linearA.TranslationX;
                    y1 = linearA.TranslationY;
                    CogTransform2DLinear linearB = CogPMAlignToolA.Results[1].GetPose();
                    x2 = linearB.TranslationX;
                    y2 = linearB.TranslationY;

                    moveArm(x1, y1, x2, y2);
                    break;
                }
                Thread.Sleep(3000);
            }
        }
        public void moveArm(double x1, double y1, double x2, double y2)
        {
            double armx1, army1, armx2, army2;
            form2D1.MapPoint(x1, y1,out armx1, out army1);
            form2D1.MapPoint(x2, y2,out armx2, out army2);

            myMCC.MoveXYZWait((armx1 + armx2) /2, (army1 + army2) /2, 0);
        }
    }
}

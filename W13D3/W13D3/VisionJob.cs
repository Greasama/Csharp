using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;

namespace W13D3
{
    public class VisionJob
    {
        //public double TranslationX;
        //public double TranslationY;
        //public double Rotation;
        //public double Scaling;
        //public double Aspect;
        //public double Skew;
        public CogTransform2DLinear form2D1 = new CogTransform2DLinear();
        //上方数据已经全部存入
        public VideoSourcePlayer vispShoot;
        public CRobotArm CRobotArm1;

        public void SetArmValue(string key, string value)
        {
            try
            {
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (cfa.AppSettings.Settings[key] != null)
                    cfa.AppSettings.Settings[key].Value = value;
                else
                    cfa.AppSettings.Settings.Add(key, value);
                cfa.Save();
            }
            catch
            { }
        }

        public string SetArmValue(string key)
        {
            string str = ConfigurationManager.AppSettings[key];
            return str;
        }

        public double SetArmValueAsDouble(string key, double defalut = 0)
        {

            string str = ConfigurationManager.AppSettings[key];
            double value;
            if (double.TryParse(str, out value))
            {
                return value;
            }
            else
            {
                return defalut;
            }
        }

        public void SaveArm()
        {
            SetArmValue("平移X", form2D1.TranslationX.ToString());
            SetArmValue("平移Y", form2D1.TranslationY.ToString());
            SetArmValue("旋转", form2D1.Rotation.ToString());
            SetArmValue("缩放", form2D1.Scaling.ToString());
            SetArmValue("横纵比", form2D1.Aspect.ToString());
            SetArmValue("倾斜", form2D1.Skew.ToString());
        }

        public void LoadArm()
        {
            form2D1.TranslationX = SetArmValueAsDouble("平移X");
            form2D1.TranslationY = SetArmValueAsDouble("平移Y");
            form2D1.Rotation = SetArmValueAsDouble("旋转");
            form2D1.Scaling = SetArmValueAsDouble("缩放", 1);
            form2D1.Aspect = SetArmValueAsDouble("横纵比", 1);
            form2D1.Skew = SetArmValueAsDouble("倾斜");
        }
        public void RunArm()
        {
            CRobotArm1.MoveXYZWait(100, 100, 100);
            string VppFile = Application.StartupPath + "\\找AB物体.vpp";
            CogJobManager CogJobManager1 = (CogJobManager)CogSerializer.LoadObjectFromFile(VppFile);
            CogToolGroup CogToolGroup1 = CogJobManager1.Job(0).VisionTool as CogToolGroup;//获取job中的工具
            CogImageConvertTool CogImageConvertTool1 = (CogImageConvertTool)CogToolGroup1.Tools["CogImageConvertTool1"];
            CogPMAlignTool CogPMAlignToolA = (CogPMAlignTool)CogToolGroup1.Tools["CogPMAlignTool1"];
            CogPMAlignTool CogPMAlignToolB = (CogPMAlignTool)CogToolGroup1.Tools["CogPMAlignTool2"];
            while (true)
            {
                Bitmap img = vispShoot.GetCurrentVideoFrame();
                //System.NullReferenceException
                //HResult = 0x80004003
                //Message = 未将对象引用设置到对象的实例。
                //Source = W13D3
                //StackTrace:
                //at W13D3.VisionJob.RunArm() in E:\ProgramData\learn\C#\W13D3\W13D3\VisionJob.cs:line 102
                CogImageConvertTool1.InputImage = new CogImage8Grey(img);
                CogToolGroup1.Run();
                if (CogPMAlignToolA.Results.Count >= 1 &&
                   CogPMAlignToolB.Results.Count >= 1)
                {
                    double x1, y1, x2, y2;
                    CogTransform2DLinear linearA = CogPMAlignToolA.Results[0].GetPose();
                    x1 = linearA.TranslationX;
                    y1 = linearA.TranslationY;
                    CogTransform2DLinear linearB = CogPMAlignToolB.Results[0].GetPose();
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
            form2D1.MapPoint(x1, y1, out armx1, out army1);
            form2D1.MapPoint(x2, y2, out armx2, out army2);


            CRobotArm1.MoveXYZWait(100, 100, 100);
            CRobotArm1.MoveXYZWait((int)armx1, (int)army1, 100);
            CRobotArm1.MoveXYZWait((int)armx1, (int)army1, 31);
            CRobotArm1.OpenAirPump(true);
            Thread.Sleep(1000);
            CRobotArm1.MoveXYZWait((int)armx1, (int)army1, 100);
            CRobotArm1.MoveXYZWait((int)armx2, (int)army2, 100);
            CRobotArm1.MoveXYZWait((int)armx2, (int)army2, 60);
            CRobotArm1.OpenAirPump(false);
            CRobotArm1.MoveXYZWait((int)armx2, (int)army2, 100);
            CRobotArm1.MoveXYZWait(100, 100, 100);
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;//旋转45°工具所在命名空间

namespace W13D2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(pictureBox1.Image);
            //CogImage8Grey Grey =  new CogImage8Grey(bitmap);
            //pictureBox1.Image = Grey.ToBitmap();
            pictureBox1.Image = new CogImage8Grey(new Bitmap(pictureBox1.Image)).ToBitmap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CogAffineTransformTool tool = new CogAffineTransformTool();
            tool.InputImage = new CogImage8Grey(new Bitmap(pictureBox1.Image));
            //转灰度
            tool.Region.CenterX = pictureBox1.Image.Width / 2;
            tool.Region.CenterY = pictureBox1.Image.Height / 2;
            tool.Region.SideXLength = 500;
            tool.Region.SideYLength = 500;
            //尺寸处理
            tool.Region.Rotation = 45.0 / 180.0 * 3.1415926;
            tool.Run();
            pictureBox1.Image = tool.OutputImage.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            //图像设置，使用控件的默认状态，需要调整
        }

        //VP内设置完成之后导入
        private void button3_Click(object sender, EventArgs e)
        {
            string VppFile = Application.StartupPath + "\\旋转测试.vpp";
            //.vpp文件放在.exe文件所在目录下，查找.vpp
            CogAffineTransformTool tool = 
                (CogAffineTransformTool)CogSerializer.LoadObjectFromFile(VppFile);
            //调用.vpp程序处理
            tool.InputImage = new CogImage8Grey(new Bitmap(pictureBox1.Image));
            tool.Run();
            pictureBox1.Image = tool.OutputImage.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}

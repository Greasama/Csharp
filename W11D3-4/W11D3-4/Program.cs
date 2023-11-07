global using static System.Console;   //全局，适用整个项目
global using Ex0812;   //全局，导入文件范围命名空间
using System.Drawing;


    IShape[] molds = { //初始化各实现类
            new Circle(13.6),//圆
            new Trapezoidal(21.0, 24.0, 27.0), //梯形
            new Rectangle(24.0, 28.0) //矩形
         };
    WriteLine("**计算各形状的面积**");
//读取数组元素
foreach (IShape item in molds)
    WriteLine(item);
    object k = 1;
    string str = k.ToString();
    ReadKey();


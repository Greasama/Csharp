using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

//方法参考：https://developer.aliyun.com/article/678181
//n 阶贝塞尔曲线计算公式——Ts实现：https://blog.csdn.net/lxt610/article/details/105071368
//算法本质：https://pages.mtu.edu/~shene/COURSES/cs3621/NOTES/spline/Bezier/de-casteljau.html
static void Main(string[] args)
{
// 第一个是起点，最后一个是终点，中间的都是控制点，贝赛尔曲线阶数 = 总点数-1
PointF[] pointList = new PointF[] { new PointF(1.3F, 2.4F), new PointF(2, 3), new PointF(12.3F, 13.2F) };


PointF[] aa = Bezier.draw_bezier_curves(pointList, pointList.Length, 0.001F); // 在起点和终点之间画1/0.001=1000个点
foreach (var item in aa)
{
// 绘制曲线点
// 下面是C#绘制到Panel画板控件上的代码
//panel1.CreateGraphics().DrawEllipse(new Pen(Color.Green), new RectangleF(item, new SizeF(2, 2)));
//using System.Windows.Forms;
}
}
public static class Bezier
{
    /// 绘制n阶贝塞尔曲线路径
    /// <param name="points">输入点</param>
    /// <param name="count">点数(n+1)</param>
    /// <param name="step">步长,步长越小，轨迹点越密集</param>
    public static PointF[] draw_bezier_curves(PointF[] points, int count, float step)
    {
        List<PointF> bezier_curves_points = new List<PointF>();
        float t = 0F;
        do
        {
            PointF temp_point = bezier_interpolation_func(t, points, count);    // 计算插值点
            t += step;
            bezier_curves_points.Add(temp_point);
        }
        while (t <= 1 && count > 1);    // 一个点的情况直接跳出.
        return bezier_curves_points.ToArray();  // 曲线轨迹上的所有坐标点
    }
    /// n阶贝塞尔曲线插值计算函数
    /// 根据起点，n个控制点，终点 计算贝塞尔曲线插值
    /// <param name="t">当前插值位置0~1 ，0为起点，1为终点
    /// <param name="points">起点，n-1个控制点，终点
    /// <param name="count">n+1个点
    private static PointF bezier_interpolation_func(float t, PointF[] points, int count)
    {
        PointF PointF = new PointF();
        float[] part = new float[count];
        float sum_x = 0, sum_y = 0;
        for (int i = 0; i < count; i++)
        {
            ulong tmp;
            int n_order = count - 1;    //阶数
            tmp = calc_combination_number(n_order, i);
            sum_x += (float)(tmp * points[i].X * Math.Pow((1 - t), n_order - i) * Math.Pow(t, i));
            sum_y += (float)(tmp * points[i].Y * Math.Pow((1 - t), n_order - i) * Math.Pow(t, i));
        }
        PointF.X = sum_x;
        PointF.Y = sum_y;
        return PointF;
    }
    /// 计算组合数,杨辉三角
    /// <param name="n"></param>/param
    /// <param name="k"></param>/param
    private static ulong calc_combination_number(int n, int k)
    {
        ulong[] result = new ulong[n + 1];
        for (int i = 1; i <= n; i++)
        {
            result[i] = 1;
            for (int j = i - 1; j >= 1; j--)
                result[j] += result[j - 1];
            result[0] = 1;
        }
        return result[k];
    }
}

//namespace YangTri//杨辉三角(补充，类似于De Casteljau's Algorithm)
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] last = new int[n];
//            last[0] = 1;
//            for (int i = 1; i <= n; i++)
//            {
//                int[] array = new int[i];
//                array[0] = 1;
//                Console.Write(array[0] + "   ");
//                for (int j = 1; j < i; j++)
//                {
//                    array[j] = last[j - 1] + last[j];
//                    Console.Write(array[j] + "   ");
//                }
//                for (int j = 0; j < i; j++)
//                {
//                    last[j] = array[j];
//                }
//                Console.WriteLine();
//            }
//            Console.ReadLine();
//        }
//    }
//}


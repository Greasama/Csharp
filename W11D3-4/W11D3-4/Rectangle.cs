using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Rectangle : IShape
{
    private readonly double lineX; //矩形长边长度（长）
    private readonly double lineY; //矩形短边长度（宽）

    //构造函数, 获取本身的长和宽
    public Rectangle(double lineX, double lineY)
    { this.lineX = lineX; this.lineY = lineY; }
    public double IArea
    {
        get => lineX * lineY;
    }
    //表达式主体——覆写ToString()方法
    public override string ToString() =>
       "矩形面积：" + string.Format($"{IArea:F3}");
}

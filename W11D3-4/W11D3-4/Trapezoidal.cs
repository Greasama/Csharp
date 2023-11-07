using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

internal class Trapezoidal : IShape
{
    private readonly double lineX; //梯形长边长度（下底）
    private readonly double lineY; //梯形短边长度（上底）
    private readonly double Height; //梯形高


    //构造函数, 获取本身的长和宽
    public Trapezoidal(double lineX, double lineY, double Height)
    { this.lineX = lineX; this.lineY = lineY; this.Height = Height; }
    public double IArea
    {
        get => (lineX + lineY) * Height * 0.5D;
    }
    //表达式主体——覆写ToString()方法
    public override string ToString() =>
       "梯形面积：" + string.Format($"{IArea:F3}");
}

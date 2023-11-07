using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Circle : IShape
    {
        private readonly double radius; //圆半径

        //构造函数, 获取本身的半径值
        public Circle(double radius) => this.radius = radius;

        //实现接口IShape定义的属性, 返回圆面积的值
        public double IArea
        {
            get => Math.Pow(radius, 2) * Math.PI;
        }
        //表达式主体——覆写ToString()方法
        public override string ToString() =>
           "圆面积：" + string.Format($"{IArea:F3}");
    }


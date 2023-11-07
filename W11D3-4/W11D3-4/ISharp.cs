using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0812//C# 10.0 文件范围命名空间
{
    internal interface IShape //定义接口
    {
        double IArea { get; }
        //只读属性——存储计算得到的面积
    }
}

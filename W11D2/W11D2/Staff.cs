using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//基类以virtual定义虚拟方法，必须由继承的派生类来实现(覆写)
namespace Ex0808;   //C# 10.0 文件范围命名空间

internal class Staff
{
    protected string? Name { get; set; }  //属性, 运算符?表示Name允许null值

    public void ShowMessage()   //方法成员
    {
        Write("ABC公司，");
        CalcMoney();
    }

    //表达式主体定义虚拟方法，计算薪资时可以让子类覆写
    public virtual void CalcMoney() =>
       WriteLine("薪水未知");
}

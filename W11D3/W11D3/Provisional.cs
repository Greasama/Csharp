using Ex0809;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//派生类 兼职员工——时薪 * 时数 * 工作天
//namespace Ex0809;

internal class Provisional : Staff
{
    //属性hrmoney时薪，hrworks时数，workdays工作天数
    private readonly int hrmoney;
    private readonly int hrworks;
    private readonly int workdays;

    //构造函数，调用base()方法获取父类的参数name
    public Provisional(string name, int hrmoney,
       int hrworks, int workdays) : base(name)
    {
        this.hrmoney = hrmoney;
        this.hrworks = hrworks;
        this.workdays = workdays;
    }

    //覆写父类定义的只读属性，获取构造函数的参数值，返回每月薪资
    public override int Salary
    { get => hrmoney * hrworks * workdays; }

    //覆写override父类定义的抽象方法，输出每月薪资信息
    public override void ShowMessage() =>
       WriteLine($"{Name} 是兼职员工，" +
       $"薪水 {hrmoney * hrworks * workdays:C0}");
}

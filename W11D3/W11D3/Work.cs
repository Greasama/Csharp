using Ex0809;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 子类Worker继承了Staff类
   由于父类是抽象类，因此必须实现抽象属性Salary
   和抽象方法showMessage()
*/
//namespace Ex0809;

internal class Worker : Staff
{
    //属性daymoney日薪，dayworks工作天数
    private readonly int daymoney;
    private readonly int dayworks;

    //构造函数，调用base()方法获取父类的参数name
    public Worker(string name, int daymoney, int dayworks) : base(name)
    {
        this.daymoney = daymoney;
        this.dayworks = dayworks;
    }
    //只读属性Daymoney, Dayworks使用表达式主体来获取私有字段daymoney, dayworks返回值
    public int Daymoney => daymoney;
    public int Dayworks => dayworks;

    //覆写父类定义只读属性，获取构造函数的参数值，返回每月薪资
    public override int Salary
    { get => daymoney * dayworks; }

    //覆写override父类定义的抽象方法，输出每月薪资信息
    public override void ShowMessage() => WriteLine(
       $"{Name} 是正式员工，薪水 {daymoney * dayworks:C0}");

}

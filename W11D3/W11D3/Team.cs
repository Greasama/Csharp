using Ex0809;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//派生类  干部——底薪 + 加给
//namespace Ex0809;
internal class Team : Staff
{
    //属性basemoney基本薪，allowance津贴
    private readonly int basemoney;
    private readonly int allowance;
    //构造函数，调用base()方法获取父类的参数name
    public Team(string _name, int _basemoney,
       int _allowance) : base(_name)
    {
        this.basemoney = _basemoney;
        this.allowance = _allowance;
    }
    //覆写父类定义的只读属性，获取构造函数的参数值，返回每月薪资
    public override int Salary
    { get => basemoney * allowance; }
    //覆写override父类定义的抽象方法，输出每月薪资信息
    public override void ShowMessage() => WriteLine(
       $"科长 {Name,11}，薪水 {basemoney + allowance:C0}");
}


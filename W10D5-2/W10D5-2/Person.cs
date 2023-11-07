using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0802;

//Human是一个继承Person的派生类，使用this关键词获取父类的属性值
internal class Human : Person   //继承了Person类
{
    //this获取父类设置的属性值---功能暂无？
    public string this[string Surname]
    { get => Surname; }

    //public new string Surname  { get; set; }
    //派生类的构造函数可以重设属性值
    public Human(string newHair)
    {
        Height = 175;     //设定新的身高
        this.Hair = newHair;   //获取基类的属性值,并刷新新的头发颜色定义
    }

    //表达式主体声明方法
    public void Show() => WriteLine(
       $"我是第二代，但我是{Hair}头发，身高 {Height} cm");
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0802;   //C#10.0 文件范围命名空间

internal class Person   //基类
{
    //Height, Hair自动实现属性
    protected int Height { get; set; }
    protected string Hair { get; set; }

    //使用表达式主体，只用get获取姓氏，return返回其值，形成只读属性
    protected string Surname
    { get => "Cumberbatch"; }   //名字赋值

    //基类的构造函数
    public Person()
    {
        Height = 170;
        Hair = "棕色";
    }

    // 表达式主体声明方法
    public void showMessage() => 
        WriteLine($"父亲 {Surname}，{Hair}头发，身高 {Height} cm");
}
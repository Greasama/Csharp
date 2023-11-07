using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0801;   //C# 10.0 文件范围命名空间
internal class School   //基类
{
    /* 属性分别以public, protected作为访问权限修饰词
       subject： 存放科目名称
       room   ： 获取教室编号
       teacher： 授课教师
    */
    public string Subject { get; set; }//?
    protected int Room { get; set; }
    protected string Teacher { get; set; }
    // private string Teacher { get; set; }

    protected int Student { get; set; }

    //构造函数赋予属性值
    public School()
    {
        Subject = "计算机概论";
        Room = 1205;
        Teacher = "Leia Organa";
        Student = 22;
    }

    //方法主体定义——输出属性值
    public void ShowMsg() => 
        WriteLine($"科目：{Subject}，教室：{Room}，教师：{Teacher}，学生人数：{Student}");
}
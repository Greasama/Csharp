using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0609
{
    internal class Student
    {
        //自动实现属性
        public int Grade { get; set; }
        public string Name { get; set; }

        //用构造函数来初始化属性值
        public Student(string _name, int _grade)
        {
            WriteLine("调用了构造函数！");
            Name = _name;
            judgeFrom(_grade);//调用judgeFrom()方法
        }

        //析构函数
        ~Student()
        {
            WriteLine("析构函数清除对象！");
            ReadKey();
        }

        //声明类方法——判断分数的等级
        public void judgeFrom(int value)
        {
            Write($"Hi! {Name}, ");
            Grade = value;//获取传入的分数
            if (Grade >= 90)
                WriteLine($"分数 {Grade}，表现优良！");
            else if (Grade >= 80)
                WriteLine($"分数 {Grade}，表现不错！");
            else if (Grade >= 70)
                WriteLine($"分数 {Grade}，成绩尚可！");
            else if (Grade >= 60)
                WriteLine($"分数 {Grade}，通过考核！");
            else
                WriteLine($"分数 {Grade}，要多多努力……");
        }
    }
}

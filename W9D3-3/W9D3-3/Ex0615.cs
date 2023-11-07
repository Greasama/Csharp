using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0615
{
    internal class Student
    {
        //只读静态字段，对象共有——获取系统时间
        static readonly DateTime startTime;
        //静态属性——记录生成的对象
        public static int Count { get; private set; } = 0;
        //自动实现成员属性：Name, Age
        public string Name { get; set; } = "";
        public int Age { get; set; } = 20;
        //静态构造函数，只会执行一次
        static Student()
        {
            //获取系统当前的日期和时间, ToLongTimeString()只显示时间
            startTime = DateTime.Now;
            WriteLine($"静态构造函数执行的时间：" +
               $"{startTime.ToLongTimeString()}");
        }
        //含有2个参数的构造函数

        public Student(string _name, int _age)
        {
            //TimeSpae为时间间隔，以毫秒为间隔单位
            TimeSpan initTime = DateTime.Now - startTime;
            Name = _name; Age = _age;
            Count++;   //创建对象时就累计
            WriteLine($"第{Count}位学生，" +
               $"{initTime.TotalMilliseconds / 60,22}" +
               $"{Name,10} {Age,3}");
        }
    }
}

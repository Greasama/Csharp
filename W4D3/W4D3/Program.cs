using System;
using static System.Console;
namespace Ex0307_N7
{
    struct Computer
    {
        public Computer()
        {
        }//完成实例化，初值
        public int Price = 5_288;//可以设定阈值
        public string Serial = "ZCT-20211221309B";
        public DateTime madeDate = DateTime.Today;
    }
    struct Person
    {
        public Person()
        {
            Order = 36_733;
            Name = "张小风";
            Make = DateTime.Now;
        }
        public int Order { get; set; }
        public string Name { get; set; }
        public DateTime Make { get; set; }//规定了权限，只能获取 (get) 和设置 (set) 属性的值
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello,World!");
            Computer personPC = new();
            WriteLine($"计算机价格：{personPC.Price:c0}" +
                $"\n制造日期：{personPC.madeDate:D}" +
                $"\n序列号：{personPC.Serial}");
            Person juddy = new();//juddy.Order=default(int)，
            WriteLine($"\n订购人：{juddy.Name}" +
                $"\n售价：{juddy.Order:c0}" +
                $"\n时间：{juddy.Make:t}");
            var name = "Mary";
            WriteLine(name);
            ReadKey();
        }
    }
}//声明结构体同时赋初值，C#10版本允许以接近定义类的方式声明结构

//namespace Ex0308
//{
//    internal class AutoChange
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 125;
//            float num2 = 64.78F;
//            float result = num1 + num2;
//            //num1转化为float（小空间换大空间，数据无遗失）
//            int num3 = 209_548_3647;
//            long bigNum = num3;
//            //int转化为long
//            char str = 'a';
//            int num4 = str;
//            //char转化为int
//            WriteLine($"{num1}+{num2}={result}");
//            WriteLine($"num3的数据类型为：{bigNum.GetType()}");
//            WriteLine($"num4的数据类型为：{num4.GetType()}" + $"\nnum4={num4}");
//        }
//    }
//}
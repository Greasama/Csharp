using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2//字符串匹配：>=
{
    class 随机数
    {
        static void Main(string[] args)//static属于类本身，不可继承
        {
            Random num = new Random();
            int count = num.Next(0, 100);
            while (true)
            {
                Console.WriteLine("猜吧！");
                int number = Convert.ToInt32(Console.ReadLine());
                if (count == number)
                {
                    Console.WriteLine("猜对了！");
                    break;
                }
                else if (number > count)
                {
                    Console.WriteLine("猜大了!");
                }
                else
                {
                    Console.WriteLine("猜小了！");
                }
            }
        }
    }
}


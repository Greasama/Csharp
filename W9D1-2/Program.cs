using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("请输入名字：");
            string word = ReadLine();
            Write("请输入分数：");
            int score = Convert.ToInt16(ReadLine());
            //创建一个含有参数的Student对象
            Student tomas = new Student(word, score);
            ReadKey();
        }
    }
}

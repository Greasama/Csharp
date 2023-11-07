using System;
using static System.Console;

//namespace W4D1
//{
//    public class Solution
//    {
//        public string MergeAlternately(string word1, string word2)
//        {
//            var str = "";
//            for (var i = 0; i < Math.Max(word1.Length, word2.Length); i++)
//            {
//                str += (i < word1.Length ? word1[i].ToString() : "") + (i < word2.Length ? word2[i].ToString() : "");
//            }
//            return str;
//        }
//        class Program
//        {
//            private static void Main(string[] args)
//            {
//                Solution solution = new Solution(); // 创建 Solution 类的实例（不同点）
//                string word1 = "hlowrd";
//                string word2 = "el ol!";
//                string mergedString = solution.MergeAlternately(word1, word2);
//                Console.WriteLine(mergedString);
//            }
//        }
//    }
//}//LeetCode 75-1

//public class Cone
//{
//    public static double Cal(double r, double h)
//    {
//        double pi = 3.14;
//        double V = (1.00 / 3.00) * pi * Math.Pow(r, 2) * h;
//        return V;
//    }
//    class program
//    {
//        static void Main(string[] args)
//        {
//            double r = 2.00;
//            double h = 5.00;
//            //double volume = Math.Round(Cone.Cal(r, h), 2);
//            double volume = Cone.Cal(r, h);
//            string VO = string.Format("{0:0.00}", volume);
//            Console.WriteLine("圆锥体的体积为：" + VO);
//        }
//    }
//}//课上习题，计算圆锥体体积

class program
{
    static void Main(string[] args)
    {
        //int iNumber = 0;
        //int iLong = sizeof(System.Int32);
        //Console.WriteLine("int在.net系统中的类型名称为" + typeof(int));
        //Console.WriteLine($"整数->占用的内存字节数为：{iLong}");
        //Console.WriteLine("变量iNumber->在.net系统中的数据类型名字为：" + iNumber.GetType());

        //int num1 = 1_23_456;
        //long num2 = 456_789_123L;
        //long max = Int64.MaxValue;
        //long min = Int64.MinValue;
        //int num3 = 0b1011_110;
        //int num4 = 0b_111_110_10;
        //int num5 = 0xFB12;
        //WriteLine($"Number:{num1: N0},{num2:n0}");//输出有千位符号，但不含小数
        //WriteLine($"二进制数转换为十进制数：{num3:D5},{num4:d5},{num5}");//以十进制数输出变量
        //WriteLine($".NET类型：{num1.GetType()}");
        //WriteLine($"最大值：{max},\n最小值：{min}");

        //float num1 = 1.2233445566778899f;
        //double num2 = 1.2233445566778899;
        //decimal num3 = 1.2233445566778899M;
        //double x1 = 0.1, x2 = 0.2;
        //decimal y1 = 0.1M, y2 = 0.2M;
        //float z1 = 0.1f, z2 = 0.2f;
        //WriteLine($"Float:{num1}");
        //WriteLine($"double:{num2}");
        //WriteLine($"decimal:{num3}");
        //WriteLine($"Float:{num1:f4}");
        //WriteLine($"double占<{sizeof(double)}>字节");
        //WriteLine($"decimal占<{sizeof(decimal)}>字节");
        //WriteLine($"double,x1+x2={x1 + x2}");
        //WriteLine($"decimal,y1+y2={y1 + y2}");
        //WriteLine($"float,z1+z2={z1 + z2}");
        //WriteLine($"double,y2-x2={y2 - (decimal)x2}");
        //WriteLine($"decimal,y1-x1={(double)y1 - x1}");
        //WriteLine($"float,y1-z1={(float)y1 - z1}");
        //WriteLine($"float,z1-x1={z1 - x1}");

        //WriteLine($"float默认值为{default(float)}");

        int number = default(int);//default默认表达式
        bool isEmpty = default(bool);
        WriteLine($"int默认值为->{number}");
        WriteLine($"bool默认值为->{isEmpty}");
        Write("输入第一个整数值->");
        int n1 = int.Parse(ReadLine());//parse方法
        Write("输入第二个整数值->");
        int n2 = int.Parse(ReadLine());
        Write("输入第三个整数值->");
        int n3 = Convert.ToInt32(ReadLine());
        int result = n1 + n2;
        WriteLine($"{n1}+{n2}={(result):N0}");//gettype方法
        WriteLine($"n1类型{n1.GetType()}");
        WriteLine($"n3类型{n3.GetType()}");
        string str1 = Convert.ToString(n1);
        string str2 = string.Format($"{n1:D4}");
        WriteLine($"将数字转化为字符：{str1}");
        WriteLine($"将数字转化为字符：{str2}");

        ReadKey();
    }
}


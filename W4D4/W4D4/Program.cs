using System;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Console;
using static System.Math;
//namespace Ex0309//千克转化为磅
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            const double Pound = 2.20462D;
//            Write("请输入千克：");
//            int weight = int.Parse(ReadLine());
//            WriteLine($"{weight}千克={weight * Pound:f4}磅");
//        }
//    }
//}

//namespace Ex0310
//{
//    internal class Program
//    { 
//    static void Main(string[] args)
//        {
//            Write("请输入您的生日：");
//            string brith = ReadLine();
//            DateTime special = Convert.ToDateTime(brith);
//            //字符串转换为日期格式
//            DateTime Atonce = DateTime.Now;
//            string thisDay = Convert.ToString(Atonce);
//            //获取当前日期，再转化为字符串
//            WriteLine($"今天是{thisDay}\n你的生日{special}");
//        }
//    }
//}

//namespace Ex0311
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 10, num2 = 20;
//            WriteLine("----递增运算符----");
//            WriteLine($"num1 = {num1},num2 = {num2}");
//            WriteLine($"前置运算，{++num1}+{num2}={num1 + num2}");//++num1+num2,运算相同但等式不成立
//            //num1++,sum=num1+num2
//            WriteLine($"num1 = {num1},num2 = {num2}");
//            WriteLine($"后置运算，{num1}+{num2}={num1++ + num2}" + $"\nnum1 = {num1}");
//            //sum=num1+num2,num1++
//            WriteLine("----递减运算符----");
//            num1 = 10; num2 = 20;
//            WriteLine($"num1 = {num1}，num2 = {num2}");
//            WriteLine($"前置运算，{--num1}-{num2}={num1 - num2}");
//            WriteLine($"num1={num1},num2={num2}");
//            WriteLine($"后置运算，{num1}-{num2}={num1-- - num2}" + $"\nnum1 = {num1}");
//        }
//    }
//}

//namespace Ex0312
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 32_667, num2 = 7_536;
//            float result = (float)num1 / num2;//浮点除法
//            float result2 = 12.3456f;
//            WriteLine($"{num1}+{num2}={num1 + num2}");
//            WriteLine($"{num1}-{num2}={num1 - num2}");
//            WriteLine($"{num1}*{num2}={num1 * num2}");
//            WriteLine($"整数除法->{num1}/{num2}={num1 / num2}"
//                + $"\n浮点除法->{num1}/{num2}={result:f5}");
//            WriteLine($"{num1}%{num2}={num1 % num2}");
//            WriteLine($"\n浮点取余->{result2}%{result}={(result2 % result):f5}");
//            //区分整除与浮点除
//            ReadKey();
//        }
//    }
//}

//namespace Ex0313
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float num1 = 52.00F;
//            float num2 = 123_788.655F;
//            WriteLine($"num1= {num1},num2={num2}");
//            WriteLine($"num1+=num2,num1={num1 += num2:n3}");
//            WriteLine($"num1-=num2,num1={num1 -= num2:n3}");
//            WriteLine($"num1*=num2,num1={num1 *= num2:n3}");
//            num1 = 123_788.655F; num2 = 52.0F;
//            WriteLine($"num1 /= num2, num1 ={num1 /= num2:n5}");
//            //WriteLine($"num1-=num2,num1={num1 -= num2:n3}");
//            WriteLine($"num1 %= num2, num1 ={num1 %= num2:n5}");
//            ReadKey();
//        }
//    }
//}

//namespace EX0314
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 25, b = 147, c = 67;
//            WriteLine($"a={a},b={b},c={c}");
//            bool result = a + b > a + c;
//            WriteLine($"a+b>a+c,返回{result}");
//            result = (b-c)<(b-a);
//            WriteLine($"b-c<c-a,返回{result}");

//            result = a == 25;
//            WriteLine($"a==25,返回{result}");
//            result = b != 25;
//            WriteLine($"b!=25,返回{result}");
//        }
//    }
//}

//namespace EX2//输入一个数，判断区间输出区间100，90，80，70，60,0
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Write("请输入一个整数：");
//            string input = ReadLine();
//            int score = int.Parse(input);
//            string result =
//                        (score >= 90.0) ? "A" :
//                        (score >= 80.0) ? "B" :
//                        (score >= 70.0) ? "C" :
//                        (score >= 60.0) ? "D" : "F";
//            WriteLine($"您的等级为{result}");
//        }
//    }
//}

//namespace EX3//一些数学运算
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            const double cst_Min_Zero = 1e-10f;
//            double x = 0.6f, y = 0.600_000_01f;
//            WriteLine(Sqrt(4));
//            WriteLine(Pow(2, 4));
//            WriteLine(Abs(-1));
//            ReadKey();
//        }
//    }
//}

//namespace Ex4//输入一段字符，按照ASCII码移动一定位置加密，再解密
//{
//    class Program
//    {
//        static void Main()
//        {
//            WriteLine("---------------------" +
//                "\n-----请选择操作:-----" +
//                "\n-------1. 加密-------" +
//                "\n-------2. 解密-------" +
//                "\n---------------------");
//            string choice = ReadLine();
//            switch (choice)
//            {
//                case "1":
//                    EncryptMessage();
//                    break;
//                case "2":
//                    DecryptMessage();
//                    break;
//                default:
//                    WriteLine("无效的选择");
//                    break;
//            }
//        }

//        static void EncryptMessage()
//        {
//            Write("请输入要加密的字符串：");
//            string input = ReadLine();
//            Write("请输入加密偏移量：");
//            int shift = int.Parse(ReadLine());
//            string encryptedString = Encrypt(input, shift);
//            WriteLine("加密后的字符串：" + encryptedString);
//        }

//        static void DecryptMessage()
//        {
//            Write("请输入要解密的字符串：");
//            string input = ReadLine();
//            Write("请输入解密偏移量：");
//            int shift = int.Parse(ReadLine());
//            string decryptedString = Decrypt(input, shift);
//            WriteLine("解密后的字符串：" + decryptedString);
//        }

//        static string Encrypt(string input, int shift)
//        {
//            char[] chars = input.ToCharArray();
//            if (shift > 26)
//            {
//                shift = shift - 26;
//                for (int i = 0; i < chars.Length; i++)
//                {
//                    chars[i] = (char)(chars[i] + shift);
//                }
//                return new string(chars);
//            }
//            else
//            {
//                for (int i = 0; i < chars.Length; i++)
//                {
//                    chars[i] = (char)(chars[i] + shift);
//                }
//                return new string(chars);
//            }

//        }
//        static string Decrypt(string input, int shift)
//        {
//            char[] chars = input.ToCharArray();
//            if (shift > 26)
//            {
//                shift = shift - 26;
//                for (int i = 0; i < chars.Length; i++)
//                {
//                    chars[i] = (char)(chars[i] - shift);
//                }
//                return new string(chars);
//            }
//            else
//            {
//                for (int i = 0; i < chars.Length; i++)
//                {
//                    chars[i] = (char)(chars[i] - shift);
//                }
//                return new string(chars);
//            }
//        }
//    }
//}

namespace EX4ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入加密前的一个字符：");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char Ch = Convert.ToChar(input);
                char MyCh = Ch;
                ++MyCh;
                double f = double.MaxValue;
                bool bsmallcase = char.IsLower(Ch);
                bool bSmallcase = (Ch >= 'a') && (Ch <= 'z');
                MyCh = ((MyCh > 'z') && bSmallcase) ? 'a' : MyCh;
                MyCh = ((MyCh > 'Z') && (!bSmallcase)) ? 'A' : MyCh;
                Console.WriteLine($"得到加密后的字符：{Convert.ToChar(MyCh)}");
            }
            else
            {
                Console.WriteLine("输入的不是一个字符！");
            }
        }
    }
}


//class Program
//{
//    const double CentimetersToInches = 1.0 / 2.54;
//    const double InchesToFeet = 1.0 / 12.0;
//    static void Main()
//    {
//        Console.Write("请输入厘米值：");
//        string input = Console.ReadLine();
//        double centimeters = Convert.ToDouble(input);
//        double inches = ToInches(centimeters);
//        Console.WriteLine($"{centimeters} 厘米 = {inches:F2} 英寸");
//        double feet = ToFeet(inches);
//        Console.WriteLine($"{inches:F2} 英寸 = {feet:F2} 英尺");
//    }
//    static double ToInches(double centimeters)
//    {
//        return centimeters * CentimetersToInches;
//    }
//    static double ToFeet(double inches)
//    {
//        return inches * InchesToFeet;
//    }
//}//HW3


//class Program
//{
//    enum Week : int 
//    { 
//        Mon=1, Tue=2,Wed=3,Thur=4,Fri=5,Sat=6,Sun=7
//    }
//    static void Main(string[] args)
//    {
//        Week day1,day2,day3,day4,day5,day6,day7;
//        int p1,p2,p3,p4,p5,p6,p7;
//        day1 = Week.Mon;day2 = Week.Tue;day3 = Week.Wed;
//        day4 = Week.Thur;day5 = Week.Fri;day6 = Week.Sat;
//        day7 = Week.Sun;
//        p1=(int)Week.Mon;p2=(int)Week.Tue;p3=(int)Week.Wed;
//        p4=(int)Week.Thur;p5=(int)Week.Fri;p6=(int)Week.Sat;
//        p7=(int)Week.Sun;
//        WriteLine($"{day1} = 周{p1}" +
//            $"\n{day2} = 周{p2}" +
//            $"\n{day3} = 周{p3}" +
//            $"\n{day4} = 周{p4}" +
//            $"\n{day5} = 周{p5}" +
//            $"\n{day6} = 周{p6}" +
//            $"\n{day7} = 周{p7}");
//    }
//}//HW4
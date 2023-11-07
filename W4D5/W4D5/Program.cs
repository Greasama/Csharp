using System;
using static System.Console;
using static System.Math;

//internal class Ex0401
//{
//    static void Main(string[] args)
//    {
//        //Random random = new Random();
//        //Write("请输入分数：");
//        //int score = random.Next(0, 101);
//        //WriteLine("随机生成的分数为: " + score);
//        Write("请输入分数：");
//        int score = Convert.ToInt32(ReadLine());
//        if (score >= 60)
//        {
//            Write("Passed......");
//        }
//        else
//        {
//            Write("better luck next time......");
//        }
//        ReadLine(); //Enter关闭
//    }
//}

//int? number = null;//Ex0402
//if (number is null)
//{
//    WriteLine($"实值类型{number}含有null值");
//}
//else
//{
//    WriteLine($"实值类型{number}不含null值");
//}
////三目运算符
//string result = (number is null) ? "number含有null值" : "number不含null值";
//WriteLine(result);
//string? str2 = null;
//str2 = ReadLine();
//WriteLine((str2==null)?"str2=null":"str2!=null");
//WriteLine((str2 == "") ? "str2=null" : "str2!=null");//NULL和""的区别

//ushort guess = 79;//Ex0403
//Write("请输入1到100的数值：");
//ushort result = Convert.ToUInt16(ReadLine());
//WriteLine(result > guess ?
//    $"result大于默认值{guess}" :
//    $"result小于默认值{guess}");
//WriteLine(result > guess ?
//    $"{guess}的平方根={Sqrt(guess):f6}" :
//    /*$"{guess}的立方={Pow(result,3):N0}"*/
//    $"{result}的立方根={Pow(result, 1.0 / 3.0):N0}");
//ReadKey();

//Write("请输入分数：");//Ex0404,分数分段评级的if...else...语句
//ushort score = Convert.ToUInt16(ReadLine());
//if (score >= 60)
//{
//    if (score >= 70)
//    {
//        if (score >= 80)
//        {
//            WriteLine(score >= 90 ? $"\n分数{score}->A级" : $"\n分数{score}->B级");
//        }
//        else
//        {
//            WriteLine($"\n分数{score}->C级");
//        }
//    }
//    else
//    {
//        WriteLine($"\n分数{score}->D级");
//    }
//}
//else
//{
//    WriteLine($"\n分数{score}->不及格");
//}

Write("请输入你的结算额：");//Ex0405
decimal result = Convert.ToDecimal(ReadLine());
if (result > 4_400_000)
{
    result = result * 0.4M - 805_000;
    WriteLine($"税率40%，缴纳税额={result:N0}");
}
else if (result > 2_350_000 && result < 4_400_000)//减少交叉，避免错误
{
    result = result * 0.3M - 365_000;
    WriteLine($"税率30%，缴纳税额={result:N0}");
}
else if (result > 1_170_000 && result < 2_350_000)
{
    result = result * 0.2M - 130_000;
    WriteLine($"税率20%，缴纳税额={result:N0}");
}
else if (result > 520_000 && result < 1_170_000)
{
    result = result * 0.12M - 36_400;
    WriteLine($"税率12%，缴纳税额={result:N0}");
}
else
{
    result = result * 0.05M;
    WriteLine($"税率5%，缴纳税额={result:N0}");
}
ReadKey();

//namespace Ex0406_N2
//{
//    enum Weeks : byte
//    {
//        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Write("输入0到6的数值，将英语转汉语");
//            byte days = Convert.ToByte(ReadLine());
//            switch (days)
//            {
//                case 0:
//                    WriteLine($"{Weeks.Sunday}是星期日"); break;
//                case 1:
//                    WriteLine($"{Weeks.Monday}是星期一"); break;
//                case 2:
//                    WriteLine($"{Weeks.Tuesday}是星期二"); break;
//                case 3:
//                    WriteLine($"{Weeks.Wednesday}是星期三"); break;
//                case 4:
//                    WriteLine($"{Weeks.Tuesday}是星期四"); break;
//                case 5:
//                    WriteLine($"{Weeks.Friday}是星期五"); break;
//                case 6:
//                    WriteLine($"{Weeks.Saturday}是星期六"); break;
//                default:
//                    WriteLine($"数字不正确，请重新输入！"); break;
//            }
//            ReadKey();
//        }
//    }
//}

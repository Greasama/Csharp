using System;
using static System.Console;
using static System.DateTime;
using System.Linq;
using System.Globalization;

//class switchcaseEx2
//{
//    static void Main(string[] args)
//    {
//        WriteLine("请输入要查询的录取分数线（比如民办本科，艺术类，体育类，二本，一本）：");
//        string strNum = ReadLine();
//        switch (strNum)
//        {
//            case "民办本科":
//                WriteLine("录取分数线：350"); break;
//            case "艺术类":
//                WriteLine("录取分数线：290"); break;
//            case "体育类":
//                WriteLine("录取分数线：280"); break;
//            case "二本":
//                WriteLine("录取分数线：445"); break;
//            case "一本":
//                WriteLine("录取分数线：555"); break;
//            default:
//                WriteLine("您输入的查询信息有误！"); break;
//        }
//        ReadLine();
//    }
//}

//class YearMonthDay1
//{
//    static void Main(string[] args)
//    {
//        WriteLine("请输入年份：");
//        int strYear = Convert.ToInt32(ReadLine());
//        WriteLine("请输入要查询的月份：");
//        string strNum = ReadLine();
//        switch (strNum)
//        {
//            case "1":case "3":case "5":case "7":case "8":case "10":
//            case "12": WriteLine($"{strNum}月有31天"); break;
//            case "4":case "6":case "9":
//            case "11": WriteLine($"{strNum}月有30天"); break;
//            case "2":
//                if ((strYear % 4 == 0 && strYear % 100 != 0) || (strYear % 400 == 0)){
//                    WriteLine($"{strNum}月有29天");
//                }//c#提供DateTime.IsLeapYear()方法直接求
//                else{
//                    WriteLine($"{strNum}月有28天");
//                }break;
//            default:WriteLine("您输入的查询信息有误！(请输入阿拉伯数字，如：1)"); break;
//        }
//        ReadLine();
//    }
//}

//class program//月份天数查询参考
//{
//    static bool fnDaysInMonth(int year, int month, out int days)
//    {
//        days = 0;
//        if (!(Enumerable.Range(1, 12).Contains(month))) return false;
//        if (!(Enumerable.Range(1, 9999).Contains(year))) return false;
//        if ((year < 1) || (year > 9999)) return false;
//        if ((month < 1) || (month > 12)) return false;
//        days = DateTime.DaysInMonth(year, month);
//        return true;
//    }
//    static void Main(string[] args)
//    {
//        bool bLargeYear = false;
//        int iLargeYear = 0;
//        WriteLine("请输入您要查阅的年份：");
//        iLargeYear = int.Parse(Console.ReadLine());
//        bLargeYear = DateTime.IsLeapYear(iLargeYear);//闰年判定函数
//        WriteLine("请输入您要查阅的月份：");
//        int month = int.Parse(Console.ReadLine());
//        int daysResult = 0;
//        if (fnDaysInMonth(iLargeYear, month, out daysResult))
//        {
//            WriteLine($"此月份有：{daysResult}天");
//        }
//        else
//        {
//            WriteLine($"您输入的格式有误......");
//        }
//        if ((month >= 1) && (month <= 12))
//        {
//            switch (month)
//            {
//                case 2:
//                    { WriteLine($"此月份有：{daysResult}天"); }
//                    break;
//                case 1:
//                case 3:
//                case 5:
//                case 7:
//                case 8:
//                case 10:
//                case 12:
//                    {
//                        WriteLine($"此月份有{daysResult}天");
//                    }
//                    break;
//                default:
//                    {
//                        WriteLine($"此月份有{daysResult}天");
//                    }
//                    break;
//            }
//        }
//    }
//}


//Ex0407,区别for循环条件表达式与程序主体在执行过程的先后
//int k, sum = 0;//储存结果
//WriteLine("请输入需要的求解范围：");
//int y = Convert.ToInt32(ReadLine());
//for (k = 1; /*k <= y*/; /*k++*/)
//{
//    WriteLine($"k={k:d2},sum={sum += k:d2}");
//    k++;
//    if (k <= y)
//    {
//        continue;
//    }
//    else
//    {
//        break;
//    }//k <= y; k++ 所起到的作用
//}
//WriteLine($"k={k-1:d2},sum={sum:d2}");//最终结果
//ReadKey();

//class Program//数字拆加
//{
//    static void Main(string[] args)
//    {
//        int sum = 0;
//        while (true)
//        {
//            WriteLine("请输入参数：");
//            string strNum = ReadLine();
//            bool allDigits = true;
//            for (int i = 0; i < strNum.Length; i++)
//            {
//                if (!char.IsDigit(strNum[i])/*strNum[i]<='0'|| strNum[i]>='9'*/)
//                {
//                    allDigits = false;
//                    break;
//                }
//                else
//                {
//                    sum += int.Parse(strNum[i].ToString());
//                }
//            }
//            if (allDigits)
//            {
//                WriteLine($"字符串中每个数字的和为：{sum}");
//                WriteLine($"您输入的字符串总数为：{strNum.Length}");
//            }
//            else
//            {
//                WriteLine("输入的字符串不全为数字。");
//                WriteLine($"您输入的字符串总数为：{strNum.Length}");
//            }
//        }
//        ReadKey();
//    }
//}

//int sum = 0, count = 0;//for无限循环（=while）加法器参考1
//for (; ; )
//{
//    Write("请输入数值进行加总：");
//    /* int number = Convert.ToInt32(ReadLine());*/
//    int number = 0;
//    Write("还要继续吗？（N离开）");
//    string? endkey = ReadLine();
//    // if (endkey != null)
//    if (true)
//    {
//        endkey = endkey.ToUpper();
//        bool bIsDigital = true;

//        for (int i = 0; i < endkey.Length; i++)
//        {
//            bIsDigital = bIsDigital && (char.IsDigit(endkey[i]));
//        }
//        if (bIsDigital)
//        {
//            number = Convert.ToInt32(endkey);
//            count++;         //计数器累计次数
//            sum += number;   //存储数值
//            endkey = null;
//        }
//    }
//    /*if (endkey == "y" || endkey == "Y")
//        continue;   //继续执行
//    else if (endkey == "n" || endkey == "N")
//        break;      //结束循环*/
//    if ((endkey == "N"))
//    {
//        break;
//    }
//    else if (endkey == "Y")
//    {
//        endkey = null;
//        continue;
//    }
//    else
//    {; }
//}
//Console.WriteLine($"累加次数:{count},累加和={sum}");

//int sum = 0, count = 0;//for无限循环（=while）加法器参考2
//for (; ; )
//{
//    Write("请输入数值进行加总：");
//    int number = Convert.ToInt32(ReadLine());
//    count++;
//    sum += number;
//    Write("还要继续吗？（N离开）");
//    string? endkey = ReadLine();
//    if ((endkey == "N") || (endkey == "n"))
//    {
//        break;
//    }
//    else if (endkey == "Y" || endkey == "y")
//    {
//        continue;//goto?
//    }
//    WriteLine($"输入{count}个数值，合计：{sum}");
//    ReadKey();
//}

int sum = 0, count = 0;
int year = DateTime.Now.Year;
WriteLine($"今年为{year}年");
//for (; ; )
//{
//    count++;
//    if (count > year)
//    {
//        break;
//    }
//    else if ((count % 4 == 0 && count % 100 != 0) || (count % 400 == 0)/*DateTime.IsLeapYear(count)*/)
//    {
//        sum++;
//        WriteLine($"{count,4}为闰年，合计{sum,6}个闰年");
//        continue;
//    }
//}
while (count<year)
{
    count++;
    if (DateTime.IsLeapYear(count))
    {
        sum++;
        WriteLine($"{count,4}为闰年，合计{sum,6}个闰年");
    }
}
WriteLine($"{Now.ToLongTimeString()}");
//作用：时间加密辅助--软件写日期，比对超时否
//加密方法：加密狗（多加密软件写入）；硬件软件挂钩；运行次数、运行用户记录；
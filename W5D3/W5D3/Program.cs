using System;
using static System.Console;
using System.Threading;

//internal class Ex1//输出99乘法表
//{
//    int x, y;
//    static void Main(string[] args)
//    {
//        string str = new string('-', 36);
//        for (int x = 1; x < 10; x++)
//        {
//            WriteLine(str);
//            for (int y = 1; y < 10; y++)
//            {
//                Write($"{x * y,3}|");
//                if (y == 9)
//                {
//                    Write("\n");
//                }
//            }
//        }
//        ReadKey();
//    }
//}

//internal class pulse
////输入一个脉冲宽度，高脉冲用“^”,中间用“|”,低脉冲为“_”，高低算一个脉冲周期
////输入内容，脉冲个数，脉冲宽度（时间），脉冲速度
//{
//    static void Main(string[] args)
//    {
//        WriteLine("**********驱动电机脉冲控制模拟程序**********");
//        Write($"请输入发出的脉冲个数：");
//        int number = Convert.ToInt32(ReadLine());
//        Write($"请输入脉冲显示宽度：");
//        int width = Convert.ToInt32(ReadLine());
//        if (width % 2 != 0)
//        {
//            WriteLine($"输入错误，脉冲宽度必须为偶数！");
//            return;
//        }
//        Write($"请输入脉冲速度(单位：ms)：");
//        int velocity = Convert.ToInt32(ReadLine());
//        string up = new string('^', width / 2);
//        string change = new string('|', 1);
//        string down = new string('_', width / 2);
//        WriteLine();
//        for (int i = 1; i <= number; i++)
//        {
//            Write($"{change}");
//            Write($"{up}");
//            Thread.Sleep(velocity / 2);//System.Thread方法
//            Write($"{change}");
//            Write($"{down}");
//            Thread.Sleep(velocity / 2);
//            continue;
//        }
//        WriteLine("\n");
//        Thread.Sleep(1000);
//        string str = new string('_', width);//99以上会出现不对齐情况
//        for (int j = 1; j <= number; j++)
//        {
//            Write($"{j,-2}{str}");
//        }
//        WriteLine("\n\n*** 脉冲发射结束 ***");
//        ReadKey();
//    }
//}

//Ex0501
//int[] grade = new int[4] {78,65,95,83};
//int Index = 0;
//WriteLine("下标 元素");
//foreach (int item in grade)//循环读取数组元素
//{
//    WriteLine($"{Index} = {item,3}");
//    Index++;
//}
//for (Index = 0; Index < grade.Length; Index++)//等效foreach,遍历grade元素
//{
//    WriteLine($"数组{Index}={grade[Index]}");
//}
//ReadKey();  


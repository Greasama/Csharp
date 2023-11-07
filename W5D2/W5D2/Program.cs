using System;
using static System.Console;
using static System.Math;

//Ex0409
//int remain;
//WriteLine("输入两个质数，求取他们的最大公约数");
//Write("输入第一个整数：");
//int divisor = Convert.ToInt32(ReadLine());
//Write("输入第二个整数：");
//int divided = Convert.ToInt32(ReadLine());
//Write($"{divisor}与{divided}的");
//while (divided != 0)
//{
//    remain = divisor % divided;
//    divisor = divided;
//    divided = remain;
//}//辗转相除法（求公约数最简单算法）
//WriteLine($"最大公约数：{divisor}");
//ReadKey();

//求质数
//WriteLine($"请输入查找质数，从1开始的最大数的值：");
//int number = Convert.ToInt32(ReadLine());
//int count = 0;
//int inNum = 0;
//for (int i = 2; i <= number; i++)
//{
//    bool IsPrime = true;
//    for (int j = 2; j < i; j++)
//    {
//        inNum++;
//        if (i % j == 0)
//        {
//            IsPrime = false;
//            break;
//        }
//    }
//    if (IsPrime == true)
//    {
//        count++;
//        WriteLine($"第{count,6}个，质数为{i,6}");
//    }
//}
//WriteLine($"总共进入质数判定排除程序{inNum}次");

//Ex0410,随机生成猜数字
//bool guess = false;
//int counter = 1;
//Random rnd = new Random();
//int value = rnd.Next(1,100);
//do
//{
//    Write("请输入介于1-100之间的一个整数");
//    int keyin=Convert.ToInt32(ReadLine());
//    if(keyin>value)
//        WriteLine($"第{counter}次，{keyin}数字太大了!");
//    else if (keyin < value)
//        WriteLine($"第{counter}次，{keyin}数字太小了!");
//    else
//    {
//        WriteLine($"第{counter}次，终于猜中了" +
//            $"数字是{keyin}!");
//        guess = true;
//    }
//    if(counter==10)
//    {
//        WriteLine($"第{counter}次还未猜中，游戏失败");
//        break;
//    }
//    counter++;
//}
//while (!guess);
//ReadKey();

//Ex0411
//for (int one = 5; one >= 1; one--)
//{
//    for (int two = 1; two <= one; two++)
//    {
//        Write("*");
//    }
//    WriteLine();
//}
//ReadKey();

////continue和break语句
//int counter, sum = 0;
////for循环配合continue, break语句
//for (counter = 0; counter <= 20; counter++)
//{
//    if (counter % 2 == 0)   //找出奇数
//        continue;            //继续循环
//    sum += counter;
//    if (sum > 60)           //第二条if语句
//        break;               //中断循环
//    WriteLine($"Counter = {counter}, Sum = {sum}");
//}
//ReadKey();

//class ForEachTest
//{
//    static void Main(string[] args)
//    {
//        int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
//        foreach (int element in fibarray)
//        {
//           WriteLine(element);
//        }
//       WriteLine();
//        // 类似 foreach 循环
//        for (int i = 0; i < fibarray.Length; i++)
//        {
//           WriteLine(fibarray[i]);
//        }
//       WriteLine();
//        // 设置集合中元素的计算器
//        int count = 0;
//        foreach (int element in fibarray)
//        {
//            count += 1;
//            //WriteLine("Element #{0}: {1}", count, element);
//            WriteLine($"Element #{count}: {element}");
//        }
//       WriteLine("Number of elements in the array: {0}", count);
//    }
//}
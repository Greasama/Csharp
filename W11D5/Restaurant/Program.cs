using System;
using System.Collections.Generic;
using static System.Console;

class RestaurantQueueSystem
{
    static void Main()
    {
        Queue<string> restaurantQueue = new Queue<string>();
        List<string> waitingList = new List<string>();
        int totalCapacity = 3;
        while (true)
        {
            WriteLine("当前排队顾客：");
            foreach (var customer in restaurantQueue)
            {
                WriteLine(customer);
            }

            WriteLine("\n等待中的顾客：");
            foreach (var customer in waitingList)
            {
                WriteLine(customer);
            }

            WriteLine("\n请输入顾客名称 (或输入'完成'退出)：");
            string input = ReadLine().Trim();
            if (input.ToLower() == "完成")
            {
                if (restaurantQueue.Count > 0)
                {
                    string completedCustomer = restaurantQueue.Dequeue();
                    WriteLine($"{completedCustomer} 已完成就餐。");
                    if (waitingList.Count > 0)
                    {
                        string nextCustomer = waitingList[0];
                        waitingList.RemoveAt(0);
                        restaurantQueue.Enqueue(nextCustomer);
                        WriteLine($"{nextCustomer} 开始就餐。");
                    }
                }
                else
                {
                    WriteLine("没有顾客在等待就餐。");
                }
            }
            else
            {
                if (restaurantQueue.Count < totalCapacity)
                {
                    restaurantQueue.Enqueue(input);
                    WriteLine($"{input} 已加入排队。");
                }
                else
                {
                    waitingList.Add(input);
                    WriteLine($"{input} 已加入等待中列表。");
                }
            }
            WriteLine();
        }
    }
}

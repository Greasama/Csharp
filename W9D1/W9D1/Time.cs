using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace W9D1Time
{
    internal class TimeInfo
    {
        //默认构造函数，没有任何参数
        public TimeInfo() { WriteLine("调用时间"); }

        public int Hrs { get; set; } //自动实现属性Hrs

        //定义方法，判断获取的时间是上午还是下午
        public void ShowTime(int tm)
        {
            Hrs = tm;
            if (Hrs > 12)
            {
                Hrs %= 12;
                WriteLine($"时间是下午：{Hrs}点");
            }
            else
                WriteLine($"时间是上午：{Hrs}点");
        }
    }
}

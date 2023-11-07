using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0806;   //C# 10.0 文件范围命名空间

internal class Time   //基类
{
    //定义私有字段——时、分、秒
    private int hour;
    private int minute;
    private int second;

    public int Hour //实现属性 Hour
    {
        get => hour;
        set
        { //小时取值范围在0~24之间
            if (value >= 0 && value < 24)
                hour = value;
        }
    }

    public int Minute   //实现属性 Minute
    {
        get => minute;   //使用表达式主体
        set
        {
            minute = ( //用“?:”取代if语句，进行条件判断
               (value >= 0 && value < 60) ? value : 0);
        }
    }

    public int Second   //实现属性 Second
    {
        get => second;
        set
        {
            second = ((value >= 0 && value < 60) ? value : 0);
        }
    }

    //判断小时值是否大于12来显示上午或下午
    public string ShowTime()
    {
        string am = "上午"; string pm = "下午";
        //采用12小时制
        if (hour == 0 || hour == 12)
            hour = 12;
        else
            hour %= 12;

        //调用Format()方法返回时制格式
        return string.Format($"{(hour < 12 ? am : pm)} " +
           $"父类:{hour:D2}:{minute:D2}:{second}");
    }
}

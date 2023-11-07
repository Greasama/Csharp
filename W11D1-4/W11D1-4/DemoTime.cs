using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0806;
internal class DemoTime : Time   //派生类
{
    private int ExHour { get; set; }
    private int ExMinute { get; set; }
    private int ExSecond { get; set; }

    //定义派生类构造函数，含有3个参数——时、分、秒
    public DemoTime(int hr, int mn, int sc)
    {
        ExHour = hr;
        ExMinute = mn;
        ExSecond = sc;
    }

    //new修饰词会覆盖原有的基类的方法
    new public string ShowTime()
    {
        return string.Format(
           $"子类:{ExHour:D2}:{ExMinute:D2}:{ExSecond:D2}");
    }
}

global using static System.Console;   //全局，适用整个项目
global using Ex0806;   //全局，导入文件范围命名空间

//获取系统时间
DateTime moment = DateTime.Now;

//获取系统时间的时、分、秒
int Hr = moment.Hour;      //时
int Mun = moment.Minute;   //分
int Sed = moment.Second;   //秒

//创建对象以初始值方式设定时间
Time oneTime = new()
{
    Hour = Hr + 8,
    Minute = Mun + 14,
    Second = Sed + 12
};

WriteLine($"特定时间：{oneTime.ShowTime()}");
DemoTime TwentyFour = new(Hr, Mun, Sed);
WriteLine($"当前时间：{TwentyFour.ShowTime()}");

ReadKey();
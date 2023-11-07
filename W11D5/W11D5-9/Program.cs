using static System.Console;

// throw语句抛出错误
int month = 0;
do
{
    try
    {
        CheckMonth(month); //调用静态方法
        break;
    }
    catch (ArgumentOutOfRangeException)
    {
        WriteLine("输入月份不对");
    }
} while (true);
ReadKey();

//检查月份
static int CheckMonth(int mon)
{
    Write("请输入月份：");
    mon = Convert.ToInt32(ReadLine());
    if ((mon > 12) || (mon < 1))
        throw new ArgumentOutOfRangeException();
    else
    {
        switch (mon)
        {
            case 2:
                WriteLine($"{mon} 月只有28天");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                WriteLine($"{mon} 月有30天");
                break;
            default:
                WriteLine($"{mon} 月只有31天");
                break;
        }
    }
    return mon;
}

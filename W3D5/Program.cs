using static System.Console;

internal class Program
{
    static void Main()
    {
        //WriteLine("请输入你的名字：");
        //string name = ReadLine();
        //WriteLine($"Have a good day! {name}");
        Console.Write("请输入名字：");
        string? name = Console.ReadLine();//可NULL，？表示可能为空的字符串，便于回收垃圾
        Console.WriteLine("请输入提款金额：");
        int money = Convert.ToInt32(Console.ReadLine()) ;//将字符串转为整型
        Console.WriteLine($"Hi!{name},提款金额：{money:C0}");//有千位符的货币，小数位数为0
        Console.ReadKey();
    }
}


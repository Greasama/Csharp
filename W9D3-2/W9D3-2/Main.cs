using static System.Console;
using Ex0614;   //导入命名空间
Write("请选择 1.计算圆周长，2.计算圆面积：");
string? wd = ReadLine();//string? 表示允许变量wd含有null和其它数值
switch (wd)
{
    case "1":
        Write("请输入直径：");
        //直接调用类名进行存取，!(null容许运算符)表示输入值可以是null值
        double caliber = Circle.calcPeriphery(ReadLine()!);
        WriteLine($"圆周长 = {caliber:N5}");
        break;
    case "2":
        Write("请输入半径：");
        //C# 8.0使用!(null容许运算符)放在操作数之后
        var ridus = Circle.CalcArea(ReadLine()!);
        WriteLine($"圆面积 = {ridus:N5}");
        break;
    default:
        WriteLine("选择错误");
        break;
}
ReadKey();
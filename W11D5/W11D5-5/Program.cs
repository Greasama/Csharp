using static System.Console;

//修改范例Ex0912.csproj, 使用Func <T, TResult> 
Write("请输入1~100之间的数值：");
int num = Convert.ToInt32(ReadLine());
if (num > 100 || num < 1)
    WriteLine("数值不对");
else
{
    //实例化委托来简化此程序代码
    SquareDelegate mySquare = number => num * number;
    WriteLine($"简化委托 -> {mySquare(num):N0}");
    //搭配匿名方法使用委托(Func需要有一个return)
    Func<int, int> Square2 = delegate (int number)
    { return number * number; };
    WriteLine($"使用匿名委托 -> {Square2(num):N0}");
    //将Lambda表达式直接委托给Func<T, TResult>
    Func<int, int> Square3 = num => num * num;
    WriteLine($"Lambda为参数 -> {Square3(num):N0}");
}
ReadKey();
delegate int SquareDelegate(int number);


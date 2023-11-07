using static System.Console;

Write("请输入1~100之间的数值：");
int num = Convert.ToInt32(ReadLine());
if (num > 100 || num < 1)
    WriteLine("数值不对");
else
{
    //2.Lambda表达式取代委托方法；3.声明委托对象deputation 
    Appoint deputation = number => number * number;
    /* Appoint deputation = new(number => number * number);*/

    //4.调用委托
    WriteLine($"运算结果：{deputation(num):n0}");

    Func<int, int> Square = number => number * number;
    WriteLine($"Lambda_Square -> {Square(num)}");
}
ReadKey();

//1.声明委托
delegate int Appoint(int i);
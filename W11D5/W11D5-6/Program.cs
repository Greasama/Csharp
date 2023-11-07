using static System.Console;

//try...catch例外处理程序
int numA = 56, numB = 0;
//捕获程序错误
try //除数为0时进行错误处理
{
    if (numB == 0)
        WriteLine("除数是0");
    WriteLine(numA / numB);
}
//发生异常情况的处理
catch (DivideByZeroException ex)
{
    WriteLine(ex.ToString());
}
WriteLine($"被除数 {numA} 除以 {numB}");
ReadKey();


// try...catch语句加入when关键词
Write("数值1：");
int num1 = Convert.ToInt32(ReadLine());
Write("数值2：");
int num2 = Convert.ToInt32(ReadLine());
try
{
    double result = num1 / num2;
    WriteLine($"Result = {result}");
}
//配合catch语句进行异常情况的过滤
catch (DivideByZeroException ex) when (num2 == 0)
{
    WriteLine(ex.Message);//输出错误信息
}
ReadKey();
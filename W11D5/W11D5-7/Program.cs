global using static System.Console;
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
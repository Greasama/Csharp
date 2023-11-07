using static System.Console;
//声明两个数组；one为数值，two为字符串
ushort[] one = { 11, 12, 13, 14, 15 };
string[] two = { "Eric", "Andy", "Johon" };
//静态方法读取数组
ShowMessage(one);
ShowMessage(two);
ReadKey();
//读取数组——使用泛型方法
static void ShowMessage<T>(T[] arrData)//顶层语句下，和类平级故可用static
{
    foreach (T item in arrData)
        Write($"{item,-6} ");
    WriteLine();
}
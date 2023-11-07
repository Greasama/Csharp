using static System.Console;

//声明两个不同类型的数组，one为数值，two为字符串
ushort[] one = { 11, 12, 13, 14, 15 };
string[] two = { "Eric", "Andy", "John" };
//静态方法读取数组
ShowMsgNum(one);
ShowMsgString(two);
ReadKey();

//读取数组one--数值
static void ShowMsgNum(ushort[] arrData)
{
    foreach (ushort item in arrData)
        Write($"{item,-6}\n");
}

//读取数组two--字符串
static void ShowMsgString(string[] arrData)
{
    foreach (string item in arrData)
        Write($"{item}\n");
}



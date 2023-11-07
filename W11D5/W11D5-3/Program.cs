global using static System.Console;
using Ex0909;

//创建一个数组
//Int32[] figures = { 21, 35, 67, 142, 117, 125, 317, 488, 292, 420 };
Write("请输入数组的大小：");
int size = int.Parse(ReadLine());
int[] figures = new int[size];
for (int i = 0; i < size; i++)
{
    Write($"请输入数组的第 {i + 1} 个元素：");
    figures[i] = int.Parse(ReadLine());
}
WriteLine("数组的内容是：");
foreach (int num in figures)
{
    Write($"{num} ");
}

//创建对象
Ex0909.FindNums searchNum = new();
WriteLine();
//以对象调用相关方法
searchNum.IsOdd(figures);
searchNum.IsEven(figures);
searchNum.IsDivide3(figures);
ReadKey();


//2.FindNumbers类所列示的方法成员
//3.声明委托对象——单个任务
Speculation evenPredicate = new(searchNum.IsEven);
//3.1 委托多重任务
evenPredicate += searchNum.IsOdd;
evenPredicate += searchNum.IsDivide3;        //增加委托
//evenPredicate -= searchNum.IsDivide3;      //解除委托
evenPredicate += Test;                       //直接调用静态方法
//4.调用委托方法并以数组为参数
evenPredicate(figures);
ReadKey();
static void Test(params Int32[] numerical)
{
    WriteLine("此处可添加替代的功能函数......");
}

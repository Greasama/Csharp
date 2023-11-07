using System;
using System.Data.Common;
using System.Reflection;
using static System.Console;
using static System.Formats.Asn1.AsnWriter;
using static System.Math;

//Ex1--4 多维数组初始化
//int[,] number = new int[3, 3];//3*3数组
//number.SetValue(12, 0, 0);//number[0,0]
//number.SetValue(25, 0, 1);//number[0,1]
//number.SetValue(38, 0, 2);//number[0,2]
//WriteLine(number.GetValue(0, 0));//输出第一个元素（number[0,0]）的值，12
//int[,] number1 = new int[4, 3];
//number1[0, 0] = 64;//number1[0,0]
//number1.SetValue(123, 0, 1);//number1[0,1]
//int[,] number3 = { { 75, 64, 96 }, { 55, 67, 39 }, { 45, 92, 85 }, { 71, 69, 81 } };//声明的同时初始化
//int[,] number4 = new int[4, 3] { { 75, 64, 96 }, { 55, 67, 39 }, { 45, 92, 85 }, { 71, 69, 81 } };//推荐书写
//int[,] number5 = { { 75, 64, 96 }, { 55, 67, 39 } };
//int row = number5.GetLength(0);//获取行数值（第一维数组）
//int col = number5.GetLength(1);//获取列数组（第二维数组）

//Ex2
//int[,] score = new int[4, 3]{ {75,64,96},
//{55,67,39},
//{45,92,85},
//{71,69,81} };
//string[] subject = new string[4] { "Chinese", "Math", "English", "Mechanic" };
//string[] name = { "Mary", "Tomas", "John" };
//Write("#       ");
//for (int m = 0; m < name.Length; m++)
//{
//    Write($"{name[m],10}");
//}
//WriteLine();
////for循环
//for (int i = 0; i < score.GetLength(0); i++)//o为行
//{
//    Write($"{subject[i],-8}");
//    for (int j = 0; j < score.GetLength(1); j++)//1为列
//    {

//        Write($"{score.GetValue(i, j),10}");
//    }
//    WriteLine();
//}
////foreach循环
////int k = -1, l = -1;
////foreach (int value in score)
////{
////    l++;
////    if (l == 0)
////    {
////        k++;
////        Write($"{subject[k],8}");
////    }
////    else if (l > 2)
////    {
////        WriteLine();
////        l = 0;
////        k++;
////        Write($"{subject[k],8}");
////    }
////    Write($"{value,10}");
////}
////WriteLine();
//WriteLine($"{new String('-', 50)}");
//Write("Sum:    ");
//for (int j = 0; j < score.GetLength(1); j++)
//{
//    int Sum = 0;
//    for (int i = 0; i < score.GetLength(0); i++)
//    {
//        Sum += score[i, j];
//    }
//    Write($"{Sum,10}");
//}

////输入任意行列数组进行排列，方法1:for循环遍历
//WriteLine("请输入所需行数：");
//int m = Convert.ToInt32(ReadLine());
//WriteLine("请输入所需列数：");
//int n = Convert.ToInt32(ReadLine());
//int count = 0;
//int[,] Num = new int[m, n];
//for (int i = 0; i < m; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Num[i, j] = count++;
//    }
//}
//for (int i = 0; i < m; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Write($"[{i}][{j}]={Num[i, j],-3}");
//    }
//    WriteLine();
//}

////输入任意行列数组进行排列，方法2:取模运算
//WriteLine("请输入所需行数：");
//int x = Convert.ToInt32(ReadLine());
//WriteLine("请输入所需列数：");
//int y = Convert.ToInt32(ReadLine());
//int[,] Num = new int[x, y];
//int count = 0;
//for (int i = 0; i < x; i++)
//{
//    for (int j = 0; j < y; j++)
//    {
//        Num[i, j] = count;
//        count++;
//    }
//}
//int row = 0, col = 0;
//foreach (int num in Num)
//{
//    Write($"[{row}][{col % y}]={num,-3}");
//    col++;
//    if ((num + 1) % y == 0)
//    {
//        WriteLine();
//        row++;
//    }
//}

////输入任意行列数组进行排列，方法3:取模取余运算找行列(有问题)
//WriteLine("请输入所需行数：");
//int m = Convert.ToInt32(ReadLine());
//WriteLine("请输入所需列数：");
//int n = Convert.ToInt32(ReadLine());
//int count = 0;
//int[,] Num = new int[m, n];
//for (int i = 0; i < m; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Num[i, j] = count++;
//    }
//}
//foreach (var item in Num)
//{
//    int row = (count - 1) / n;
//    int col = (count - 1) % n;
//    Write($"[{row}][{col}]={item,-3}");
//    if (col == n - 1)
//    {
//        WriteLine();
//    }
//}

///******************* 自动输入二维数组:行数/列数 foreach 遍历索引（老师参考） *************/
//WriteLine("请输入行数:");
//int iRowInput = int.Parse(ReadLine());
//WriteLine("请输入列数:");
//int iColomnInput = int.Parse(ReadLine());
//int[,] ScoreArrayList = new int[iRowInput, iColomnInput];
////数组赋予初始
//int iScoreInital = -1;
//for (int i = 0; i < iRowInput; i++)
//{
//    for (int j = 0; j < iColomnInput; j++)
//    {
//        //使用数组索引直接赋值
//        ScoreArrayList[i, j] = ++iScoreInital;
//        //使用SetValue赋值
//        ScoreArrayList.SetValue(iScoreInital, i, j);
//    }
//}
////获取二维数组列的宽度
//int LengthColomnFinally = ScoreArrayList.GetLength(1);
////占位字符'-'的赋值
//string strFinally = new string('-', LengthColomnFinally * 17);
////打印2空行，按照计算的长度打印占位字符'-'
//Write("\n\n" + strFinally);
////打印覆盖的字符
//Write("\r\tRestart-Simple");
//int myRow;           //行号索引:范围[0..行数-1]
//int myColomn;        //行号索引：范围[0..行数-1]
//int myIndex = -1;    //数组元素序号-内存顺序索引:范围[0..数组总元素个数-1],
//                     //设初值为-1,进入后就累加1次,即从0次开始
//foreach (int MyScoreFinally in ScoreArrayList)
//{
//    myIndex++;                                 //数组元素序号累加计次
//    myColomn = myIndex % LengthColomnFinally;  //通过取余计算列号索引
//    myRow = myIndex / LengthColomnFinally;     //通过取模计算行号索引
//    //打印换行符
//    if (myColomn == 0)
//        Write($"\n");
//    Write($"[{myRow,2},{myColomn,2}]={MyScoreFinally,-10}");
//}
//Write("\n" + strFinally);
//Write("\r\t\t\t\n");
//ReadKey();

////三维数组的及其读取
////int[,,] num3D = new int[2, 2, 3] {
////{{11,13,15},{22,24,26}},
////{{33,38,41},{44,48,52}}};
//WriteLine("请输入列表数:");
//int M = int.Parse(ReadLine());
//WriteLine("请输入行数:");
//int N = int.Parse(ReadLine());
//WriteLine("请输入列数:");
//int O = int.Parse(ReadLine());
//int[,,] num3D = new int[M, N, O];
//Write($"元素：{num3D[1, 1, 1]}，" +
//    $"位于第2个表格，位于第2行第2列\n");
//int table = num3D.GetLength(0);
//int row = num3D.GetLength(1);
//int col = num3D.GetLength(2);
//WriteLine($"表格{table}个，二维表格{row}x{col}\n");
////for循环
//for (int i = 0; i < table; i++)
//{
//    WriteLine(new string('-', 32));
//    for (int j = 0; j < row; j++)
//    {
//        for (int k = 0; k < col; k++)
//        {
//            Write($"[{i}][{j}][{k}]={num3D[i, j, k],-5}");
//        }
//        WriteLine();
//    }
//}
////foreach循环
//int myTable; int myRow; int myCol;
//int myIndex = -1;
//foreach (var item in num3D)
//{
//    myIndex++;
//    myTable = myIndex / (row * col);
//    myRow = myIndex % (row * col) / col;
//    myCol = (myIndex % (row * col)) % col;
//    if (myIndex == row * col * myTable)
//    {
//        Write($"\n----------表格{myTable}----------");
//    }
//    if (myCol == 0)
//        Write($"\n");
//    Write($"[{myTable}][{myRow}][{myCol}]={item,-5}");
//}
//Write("\r\t\t\t\n");
//ReadKey();

int[,,,] num4D = new int[2, 3, 4, 5];
int cc = num4D.Length;
int pre = num4D.GetLength(0);
var table = num4D.GetLength(1);
var row = num4D.GetLength(2);
var col = num4D.GetLength(3);
int Count = 0;
for (int i = 0; i < pre; i++)
{
    for (int j = 0; j < table; j++)
    {
        for (int k = 0; k < row; k++)
        {
            for (int l = 0; l < col; l++)
            {
                num4D[i, j, k, l] = Count;
                Count++;
            }
        }
    }
}
WriteLine(cc);
//for循环
for (int i = 0; i < pre; i++)
{
    for (int j = 0; j < table; j++)
    {
        for (int k = 0; k < row; k++)
        {
            for (int l = 0; l < col; l++)
            {
                Write($"[{i}][{j}][{k}][{l}]={num4D[i, j, k, l],-5}");
            }
            WriteLine();
        }
    }
}
//foreach循环
int myFirstC = 0;
int mySecond = 0;
int myThirdC = 0;
int myFourth = 0;
int index = -1;
foreach (int item in num4D)
{
    index++;                                                         //数组元素序号累加计次
    myFirstC = (index / (table * row * col));                        //几个Pre
    mySecond = (index % (table * row * col)) / (row * col);          // 1个Pre以内,几个Table
    myThirdC = (index % (table * row * col)) % (row * col) / col;    // 1个Pre以内, 1个Table内,几个 Row 
    myFourth = (index % (table * row * col)) % (row * col) % col;    // 1个Pre以内, 1个Table内, 1个Row以内,几个col
    //打印换行符
    if (myFourth == 0)
        Write($"\n");
    Write($"[{myFirstC,2},{mySecond,2},{myThirdC,2},{myFourth,2}]={item,-10}");
}

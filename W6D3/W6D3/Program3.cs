using System;
using System.Text;
using System.Xml.Linq;
using static System.Console;

//int[][] Number = new int[3][];      
//Number[0] = new int[4];             
//Number[1] = new int[3];
//Number[2] = new int[5];
//Number[0][1] = 12;                    

//int[][] Number2 = new int[3][];      
//Number2[0] = new int[4] { 11, 12, 13, 14 };
//Number2[1] = new int[3] { 22, 23, 24 };
//Number2[2] = new int[5] { 31, 32, 33, 34, 35 };

//int[][] Number3 = new int[3][]
//{
//    new int[4] { 11, 12, 13, 14 },
//    new int[3] { 22, 23, 24 },
//    new int[5] { 31, 32, 33, 34, 35 }
//};

//int[][] Number4 =
//{
//new int[]{11,12,13,14},
//new int[]{ 22, 23, 24 },
//new int[]{ 31, 32, 33, 34, 35 },
//new int[]{ 31, 32, 33, 34, 35 }
//};

//步骤1：声明不规则数组
string[][] subject = new string[3][]
{
    //步骤2：以new运算符将每行的数组元素初始化
new string[]
   {"Johnson","英语会话","语文","程序设计"},
new string[]
    {"Molly", "语文", "计算机概论"},
new string[]
    {"Peter", "英语", "人工智能", "多媒体论","应用文"},
};

for (var i = 0; i < subject.Length; i++)
{
    for (var j = 0; j < subject[i].Length; j++)
    {
        Write($"{subject[i][j],-10}");
    }
    WriteLine();
}
WriteLine();

WriteLine("--------调整排序后的输出--------");
for (var i = 0; i < subject.Length; i++)
{
    for (var j = 0; j < subject[i].Length; j++)
    {
        Write($"[{i,-2}][{j,-2}]={subject[i][j],-10}\t");
    }
    WriteLine();
}
WriteLine();


int Count = -1;
foreach (var mySubject in subject)
{
    int x = -1;
    foreach (var item in mySubject)
    {
        Write($"{item,-10}");
        x++;
    }
    Count++;
    WriteLine();
}
WriteLine();

WriteLine("--------调整排序后的输出--------");

foreach (var mySubject in subject)
{
    int x = -1;
    foreach (var item in mySubject)
    {
        Write($"[{Count-2,-2}][{x+1,-2}]={item,-10}\t");//\t两个字符和一个字符判定一样
        x++;
    }
    Count++;
    WriteLine();
}
WriteLine();

////隐式不规则数组的定义
//var data = new[] { new[] { 11, 21, 310, 567 } };  //int[]
//var data2 = new[] { 11, 21, 310, 567 };  //int[]
////声明一个隐式类型的不规则数组
//var number = new[]
//   { new[]{68, 135, 83},
//     new[]{75,64,211,37}
//   };
//int Lens = number.Length;
//int lens2 = number[0].Length;
//WriteLine(Lens);
//WriteLine(lens2);

////Ex0510
//var Number = new[]
//{new[]{58,135,83},new[]{75,64,211,37}};
//WriteLine("读取隐式不规则数组：\n");
//for (int i = 0; i < Number.Length; i++)
//{
//    for (int j = 0; j < Number[i].Length; j++)
//    {
//        Write($"{Number[i][j],4}");
//    }
//    WriteLine("\n");
//}

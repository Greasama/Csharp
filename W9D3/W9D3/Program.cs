global using static System.Console;
using System.Text;
using System.Globalization;
using studentNamespace;
using myUserNameSpace;
using System.Reflection;
using System.Xml.Linq;

const int cstPlaceHoder = 12;
WriteLine($"没有实例化，{Student.Count}位学生");
Student Mary = new() { Name = "Mary", Math = 78, Eng = 65 };
Student Tomas = new()
{ Name = "Tomas", Math = 83, Eng = 85, Comp = 61 };
WriteLine("请选择表格格式：Middle=居中 Left=左对齐 Right=右对齐");
string? str = string.Empty;
str = Console.ReadLine();

bool bMiddleAlign = false;
int iPlaceHolder = cstPlaceHoder;
if (str!.StartsWith("M", true, CultureInfo.CurrentCulture))
    bMiddleAlign = true;
if (str.StartsWith("L", true, CultureInfo.CurrentCulture))
    iPlaceHolder = -cstPlaceHoder;
MyUser.UserLib.display(Mary, Tomas, iPlaceHolder, bMiddleAlign);
ReadKey();

//WriteLine($"{"名字|",9}{"数学|",9}{"英语|",9}{"计算机概论|"}{"总分|",9}");
//string line = new('-', 55);
//WriteLine(line);
//WriteLine($"{Mary.Name,10}|{Mary.Math,10}|{Mary.Eng,10}|{"",10}|{Mary.Total(),10}|");
//WriteLine(line);
//WriteLine($"{Tomas.Name,10}|{Tomas.Math,10}|{Tomas.Eng,10}|{Tomas.Comp,10}|{Tomas.Total(),10}|");
//WriteLine(line);
//ReadLine();
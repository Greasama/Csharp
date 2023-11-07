using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Console;
using static System.Math;


/* 交错数组 */
//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[] { 1, 2, 3 };
//jaggedArray[1] = new int[] { 4, 5 };
//jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Write(jaggedArray[i][j] + " ");
//    }
//    WriteLine();
//}
//WriteLine();
//ReadKey();
///* 多维数组 */
//int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
//int k, l;
//for (k = 0; k < 5; k++)
//{
//    for (l = 0; l < 2; l++)
//    {
//        WriteLine("a[{0},{1}] = {2}", k, l, a[k, l]);
//    }
//}
//ReadKey();



//Ex0501
//int[] grade = new int[4] { 78, 65, 95, 83 };
//int Index = 0;
//WriteLine("下标 元素");
//foreach (int item in grade)//循环读取数组元素
//{
//    WriteLine($"{Index} = {item,3}");
//    Index++;
//}
//for (Index = 0; Index < grade.Length; Index++)//等效foreach,遍历grade元素
//{
//    WriteLine($"数组{Index}={grade[Index]}");
//}
//ReadKey();

// Ex0501（×）问题：copy使用
//int[] number = { 78, 125, 43, 67, 18 };
//int lower = number.GetLowerBound(0);
//int upper = number.GetUpperBound(0);//设置为1，会出现IndexOutOfRangeEXception异常
//for(int item = lower; item <= upper; item++)
//    WriteLine($"数组：{item}:{number[item]}");

//Ex0502,数组排序(已封装，自动排序)
//string[] student = {"Vicky","Dell","Score","Mick","Jack","Tom"};
//int[] number = { 27, 36, 25, 47, 91, 62 };
//WriteLine("----------排序前----------");
//foreach (string element in student)
//{
//    Write($"{element,-6}");
//}
//WriteLine();
//foreach (int item in number)
//{
//    Write($"{item,-6}");
//}
//Array.Sort(student,3,3);
//Array.Sort(number);
//WriteLine("\n\n----------排序后----------");
//Write("指定->");
//int lower = student.GetLowerBound(0);
//int upper = student.GetUpperBound(0);
//for (int item = lower; item <= upper; item++)
//    Write($"{student[item],-6}");
//WriteLine();
//Write("升序->");
//for(int item = 0; item < number.Length;item++)
//    Write($"{number[item],-6:N0}");
//WriteLine();
//Array.Reverse(number);
//Write("递减->");
//for (int item = 0; item < number.Length; item++)
//    Write($"{number[item],-6:N0}");
//WriteLine();

//Ex0503,建议实际还是把goto语句换成break和do...while...，减少逻辑问题
struct people//建立个人类
{
    public string Name;
    public int Born;
    public int Score;
}
class Program
{
    static void Main(string[] args)
    {
        people[] students = {
            new people { Name = "Brie", Born = 1974, Score = 700 },
            new people { Name = "Randall", Born = 1981, Score = 580 },
            new people { Name = "Tomas", Born = 1967, Score = 439 },
            new people { Name = "Benedict", Born = 1978, Score = 610 },
            new people { Name = "Vicky", Born = 1989, Score = 550 },
            new people { Name = "Meryl", Born = 1953, Score = 670 }
        };//输入每个人成绩
        Array.Sort(students, (x, y) => y.Score.CompareTo(x.Score)); // 按成绩降序排序，Lambda表达式
        WriteLine("入库学生名单:");
        foreach (var student in students)
        {
            Write($"{student.Name,-9}");
        }
        WriteLine("\n-----按照成绩高低排序-----");
        Display(students);
    Loop:
        WriteLine("\n\n请输入要查询的方式：\n0:高低分-HL，\n1：年龄-AG，" +
            "\n2：NA-姓名查询（前2个字母即可）\n3：EXIT-退出");
        string Way;
        Way = ReadLine().ToUpper(); // 读取用户输入并转换为大写
    Loop1:
        switch (Way)
        {
            case "0":
            case "HL":
                WriteLine($"成绩最低的人是：{students[students.Length - 1].Name}:{students[students.Length - 1].Score}");
                WriteLine($"成绩最高的人是：{students[0].Name}:{students[0].Score}");
                goto Loop;
            case "1":
            case "AG":
                Array.Sort(students, (x, y) => x.Born.CompareTo(y.Born)); // 按出生年份升序排序
                WriteLine("\n-----按照出生年份排序-----");
                Display(students);
                goto Loop;
            case "2":
            case "NA":
                WriteLine($"请输入要查询的学生的姓名前两个字母：");
                string inputName = ReadLine().ToUpper();
                foreach (var student in students)//遍历比较输入和原数据
                {
                    if (student.Name.ToUpper().StartsWith(inputName))//从头开始比较，两个字符对应即可
                    {
                        WriteLine($"姓名: {student.Name} \n年龄：{student.Born} \n成绩: {student.Score} \n排名：{Array.IndexOf(students, student) + 1}");
                        goto Loop1;
                    }
                }
                goto Loop;
            case "3":
            case "EXIT":
                WriteLine("感谢您的使用，期待下次再见！");
                break;
            default:
                WriteLine("书写错误，请按照提示代码书写！");
                goto Loop;
        }
        ReadKey();
    }
    static void Display(people[] students)//展示打印学生数据
    {
        foreach (var student in students)
        {
            WriteLine($"NAME:{student.Name,8}  BORN:{student.Born,4}  SCORE:{student.Score,4}");
        }
    }
}

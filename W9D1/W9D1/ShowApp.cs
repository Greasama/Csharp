//using StudentsNameSpaces;
using Ex0611;
using W9D1Time;
using static System.Console;

//Student Tomas = new();
//Student Emily = new();
//Tomas.InputName("Tomas Dalton");
//Emily.InputName("Emily VanCamp");
//WriteLine($"第一位学生名字： {Tomas.ShowName()}");
//WriteLine($"第二位学生名字： {Emily.ShowName()}");

//Student chris = new();
//chris.Name = "Chris Mindy";
//chris.Display();
//ReadKey();

//StudentsNameSpaces.Student luke = new();       //创建student对象
//Write("请输入你的名字：");      //读取输入名字和年龄
//luke.Title = ReadLine();
//Write("请输入你的年龄：");
//luke.Ages = Convert.ToInt16(ReadLine());   //转换为short类型
//luke.ShowMessage();                     //显示信息
//ReadKey();

//StudentsNameSpaces.Student poe = new();   //创建student对象
//poe.ShowMessage();     //显示信息
//ReadKey();

//Write("请输入名字：");
//string? word = ReadLine();
//Write("请输入分数：");
//int grade = Convert.ToInt16(ReadLine());
////创建一个含有参数的Student对象
//StudentsNameSpaces.Student tomas = new(word!, grade);
//tomas.judgeFrom();   //调用方法成员
//ReadKey();

//namespace Ex0609
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Write("请输入名字：");
//            string word = ReadLine();
//            Write("请输入分数：");
//            int score = Convert.ToInt16(ReadLine());
//            //创建一个含有参数的Student对象
//            Student tomas = new Student(word, score);
//        }
//    }
//}

//Timeinfo mkT = new();
//DateTime moment = DateTime.Now;
//int justNow = moment.Hour;
//mkT.ShowTime(justNow);
//ReadKey();

Write("Mary");
Student Mary = new(79, 67);
Write("Tomas");
Student Tomas = new(55, 85, 74);
Write("Mike");
Student Mike = new(myMath: 100, myEng: 80, myComp: 90);
ReadKey();
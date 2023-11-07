using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;


//namespace StudentsNameSpaces
//{
//    //internal class Student
//    //{
//    //    //private string name = "";
//    //    //public void InputName(string title) => name = title;
//    //    //public string ShowName() => name;

//    //    private string name = String.Empty;
//    //        public string Name
//    //    {
//    //        get { return name; }
//    //        set { name = value; }
//    //    }
//    //    public void Display()=>Console.WriteLine($"Hello!{Name}");
//    //}

//    //internal class Student
//    //{
//    //    ////自动实现属性：属性title(名字)，Ages(年龄)
//    //    //public string? Title { get; set; }
//    //    //public short Ages { get; set; }
//    //    ////定义公有类的方法
//    //    //public void ShowMessage() =>
//    //    //   Console.WriteLine($"Hello! {Title}, 年龄：{Ages}.");

//    //    //public string Title { get; set; } = "Poe Dameron";
//    //    //public short Ages { get; set; } = 22;
//    //    //public DateTime enrolled { get; } = DateTime.Now;
//    //    ////主题——表达式主体定义-公有的类方法
//    //    //public void ShowMessage() =>
//    //    //   Console.WriteLine($"Hello! {Title}, 年龄：{Ages}" +
//    //    //      $"\n注册日期：{enrolled:D}");
//    //}
//    internal class Student
//    {
//        private int _score;//私有字段
//        public int Score   //公有属性, init将值赋值给属性或存取器元素
//        {
//            get => _score;
//            set => _score = value;
//        }
//        public string Name { get; set; }//自动实现属性
//        //用构造函数来初始化属性值
//        public Student(string inputName, int inputScore)
//        {
//            WriteLine("调用了构造函数！");
//            Score = inputScore;   //将接收的值赋值给属性
//            Name = inputName;
//        }
//        //声明类方法——判断分数的等级
//        public void judgeFrom()
//        {
//            Write($"Hi! {Name}, ");

//            if (Score >= 90)   //多重条件前断
//                WriteLine($"分数 {Score}，表现优良！");
//            else if (Score >= 80)
//                WriteLine($"分数 {Score}，表现不错！");
//            else if (Score >= 70)
//                WriteLine($"分数 {Score}，成绩尚可！");
//            else if (Score >= 60)
//                WriteLine($"分数 {Score}，通过考核！");
//            else
//                WriteLine($"分数 {Score}，要多多努力……");
//        }
//    }
//}

//namespace Ex0609
//{
//    internal class Student
//    {
//        //自动实现属性
//        public int Grade { get; set; }
//        public string Name { get; set; }
//        //用构造函数来初始化属性值
//        public Student(string _name, int _grade)
//        {
//            WriteLine("调用了构造函数！");
//            Name = _name;
//            judgeFrom(_grade);//调用judgeFrom()方法
//        }
//        //析构函数
//        ~Student()
//        {
//            WriteLine("析构函数清除对象！");
//        }
//        //声明类方法——判断分数的等级
//        public void judgeFrom(int value)
//        {
//            Write($"Hi! {Name}, ");
//            Grade = value;//获取传入的分数
//            if (Grade >= 90)
//                WriteLine($"分数 {Grade}，表现优良！");
//            else if (Grade >= 80)
//                WriteLine($"分数 {Grade}，表现不错！");
//            else if (Grade >= 70)
//                WriteLine($"分数 {Grade}，成绩尚可！");
//            else if (Grade >= 60)
//                WriteLine($"分数 {Grade}，通过考核！");
//            else
//                WriteLine($"分数 {Grade}，要多多努力……");
//        }
//    }
//}

namespace Ex0611;//函数重载
internal class Student
{
    private int Math { get; set; }
    private int Eng { get; set; }
    private int Comp { get; set; }
    public Student(int myMath, int myEng)
    {
        Math = myMath; Eng = myEng;
        int Total = Math + Eng;
        sum(Total);
    }
    public Student(int myMath, int myEng, int myComp)
    {
        Math = myMath; Eng = myEng; Comp = myComp;
        int Total = Math + Eng + Comp;
        sum(Total);
    }
    public void sum(int result) => WriteLine($"总分: {result}");
}
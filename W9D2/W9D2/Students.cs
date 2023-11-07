using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;
using static System.Math;

namespace Students
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static int num = 0;
    }
}

//const int cst_ArraySize = 5;
//string[] NameList = new string[cst_ArraySize] { "", "", "", "", "" };
//int[] AgesList = new int[cst_ArraySize] { 1, 2, 3, 4, 5 };
//Student[] studentList = new Student[cst_ArraySize];
////数组的定义方法
////public static int num = 0;//（加在类里面）
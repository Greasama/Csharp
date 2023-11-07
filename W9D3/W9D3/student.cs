using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studentNamespace
{
    internal class Student
    {
        public static int Count { get;private set; }
        public string? Name { get; set; }
        public int Math { get; set; }
        public int Eng { get; set; }
        public int Comp { get; set; }
        public int Total() => Math + Eng + Comp;
        public Student(string name)
        {
            Name = name;
            Count++;
            WriteLine($"第{Count}名学生，名字：{Name}");
        }
    }
    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

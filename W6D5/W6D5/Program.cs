//global using static System.Console;
//using System; 


//Person Tomas = new();
//Person Peter = new();
//Tomas.Name = "Tomas Evantee";
//Peter.Name = "Peter Mindy";
//Console.WriteLine($"Hello!{Tomas.Name},\n{Peter.Name}");
//Console.ReadKey();
//class Person
//{
//    public string? Name;
//}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Student.Show();
Ex0600_04.Student.Display();
MyNameSpace.CollegeStudent.Show();
Console.ReadLine();
namespace MyNameSpace
{
    class CollegeStudent
    {
        public static void Show()
        {
            Console.WriteLine("College Student!");
        }
    }
}
class Student
{
    public static void Show()
    {
        Console.WriteLine("Hell Brett White!");
    }
}
namespace Ex0600_04
{
    public class Student
    {
        public static void Display()
        {
            Console.WriteLine("命名空间->Student类->静态 Display()方法");
        }
    }
}
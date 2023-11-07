using System.Xml.Linq;
using W11D2re;

namespace W11D2re
{
    class Father
    {
        public string Name { get; set; }
        public Father(string FatherName)
        {
            Name = FatherName;
        }
    }
    class Son : Father
    {
        public Son(string SonName) : base(SonName)
        {
            this.Name = "Tomas";
        }
        //测试过后showMessage代码根本没有用,故直接注释掉
//        public static void showMessage(string name) =>
//Console.WriteLine($"名字：{name}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Father myFather = new("Mike");
            Son mySon = new("Jack,Mike");
            Console.WriteLine($"名字：{mySon.Name},\n" +
                $"名字：{myFather.Name}");
        }
    }
}
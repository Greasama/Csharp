global using static System.Console;
using Ex0615;

WriteLine("未实例化，{0}位学生", Student.Count);
WriteLine($"\n{"间隔(sec)",21}{"名字",15}{"年龄",7}");
string line = new('-', 50);
WriteLine(line);

Student one = new("Teddy", 23);
Student two = new("Charles", 18);
Student three = new("Rahgav", 20);
Read();
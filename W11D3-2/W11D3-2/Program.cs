global using static System.Console;   //全局，适用整个项目
using Ex0810;

Write("请输入名字：");
string? name = ReadLine();
Write("请输入学分数：");
int total = Convert.ToInt32(ReadLine());
Student first = new(total);
Write($"Hi! {name}");
first.ShowMessage();//调用类的方法

ReadKey();
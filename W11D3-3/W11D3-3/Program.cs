global using static System.Console;//全局，适用整个项目

Write("请输入名字：");
string? name = ReadLine();

Write("请输入学分数：");
int total = Convert.ToInt32(ReadLine());

Write("请选择： 1.学生 2.硕博生 ");
int grade = Convert.ToInt32(ReadLine());

Ex0811.Student first = new(grade, total);
Write($"Hi! {name}");
first.IShowMsg();

ReadKey();
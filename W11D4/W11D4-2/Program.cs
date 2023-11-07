global using static System.Console;
using W11D4_2;

////创建泛型类对象--学生名称
//Student<string> persons = new();
//persons.StoreArray("Tomas");
//persons.StoreArray("John");
//persons.StoreArray("Eric");
//persons.StoreArray("Steven");
//persons.StoreArray("Mark");
//persons.ShowMessage();

////创建泛型类对象--成绩
//Student<int> Score = new();
//Score.StoreArray(78);
//Score.StoreArray(83);
//Score.StoreArray(48);
//Score.StoreArray(92);
//Score.StoreArray(65);
//Score.ShowMessage();

//ReadKey();


// 创建泛型类对象--学生名称
Student<string> persons = new Student<string>();
string[] names = { "Tomas", "John", "Eric", "Steven", "Mark" };
persons.StoreArray(names);
persons.ShowMessage(names);

// 创建泛型类对象--成绩
Student<int> Score = new Student<int>();
int[] scores = { 78, 83, 48, 92, 65 };
Score.StoreArray(scores);
Score.ShowMessage(scores);

ReadKey();


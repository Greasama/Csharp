using System.Collections;
using static System.Console;

////ArratList
//string[] Subject =
//{
//    "程序语言设计","信息数学",
//    "计算机概论","多媒体","网络概论"
//};
//string[] choiceSubject =
//{
//    "英文会话","信息数学","网络概论"
//};
////创建第一个ArrayList, 指定表项数（Capacity）为1
//ArrayList list = new(1);
////调用Add()方法配合foreach循环加入表项
//foreach (var item in Subject)
//    list.Add(item);
////创建第二个ArrayList，指定初始容量
//ArrayList selectCourse = new(choiceSubject);
//WriteLine("科目：");
//Display(list);//调用Display()方法
//removeSubject(list, selectCourse);
//WriteLine("重新获取科目：");
//Display(list);
//ReadKey();

////显示ArrayList表项数和容量
//static void Display(ArrayList Courses)
//{
//    //读取ArrayList的元素
//    foreach (var item in Courses)
//        Write($"{item} ");
//    WriteLine($"\n科目 {Courses.Count}；" +
//       $"含选修 {Courses.Capacity}");
//    string word = "信息数学";
//    int index = Courses.IndexOf(word);
//    if (index != -1)
//        WriteLine(
//           $"选修有“{word}”，索引：{index}.");
//    else
//        WriteLine($"{word} 已被删除");
//}
////删除ArrayList数组中的元素
//static void removeSubject(ArrayList one,
//      ArrayList two)
//{
//    //调用Remove()方法删除ArrayList中指定的表项
//    for (int item = 0; item < two.Count; item++)
//        one.Remove(two[item]);
//}


//ArrayList arrayList = new ArrayList();
//arrayList.Add("Tomas");
//arrayList.Add(25);
//arrayList.Add(false);

//foreach (var Item in arrayList)
//    WriteLine(Item);


//HW：学生姓名，年龄，学号的操作，用结构体，foreach查询
//struct Students
//{
//    public string name;
//    public int age;
//    public int id;
//    public void display()
//    {
//        WriteLine("Name : {0}", name);
//        WriteLine("Age : {0}", age);
//        WriteLine("ID : {0}", id);
//    }
//}
//public class test
//{
//    public static void Main(string[] args)
//    {
//        Students Bruce;
//        Students Jack;

//        Bruce.name = "Bruce";
//        Bruce.age = 22;
//        Bruce.id = 001;
//        Bruce.display();

//        Jack.name = "Jack";
//        Jack.age = 24;
//        Jack.id = 002;
//        Jack.display();
//    }
//}


struct Students
{
    public string name;
    public int age;
    public int id;
}

public class Test
{
    public static void Main(string[] args)
    {
        Students[] students = new Students[2]; // 创建包含两个学生的数组

        students[0].name = "Bruce";
        students[0].age = 22;
        students[0].id = 001;

        students[1].name = "Jack";
        students[1].age = 24;
        students[1].id = 002;

        // 使用foreach循环遍历并输出每个学生的信息
        foreach (Students student in students)
        {
            WriteLine("Name: {0}", student.name);
            WriteLine("Age: {0}", student.age);
            WriteLine("ID: {0}", student.id);
            WriteLine(); // 添加空行以分隔每个学生的信息
        }
    }
}

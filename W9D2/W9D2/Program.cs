global using static System.Console;
using Students;

//class Program
//{
//    static void Main()
//    {
//        const int cst_ArraySize = 5;
//        string[] NameList = new string[cst_ArraySize] { "", "", "", "", "" };
//        int[] AgesList = new int[cst_ArraySize] { 1, 2, 3, 4, 5 };

//        Student[] studentList = new Student[cst_ArraySize];

//        studentList[0] = new("Tom", 20);
//        studentList[1] = new("Mike", 25);
//        studentList[2] = new("Mary", 21);
//        studentList[3] = new("Tim", 19);//创建student对象

//        Array.Resize(ref studentList, Student.num);
//        Array.Resize(ref AgesList, Student.num);
//        Array.Resize(ref NameList, Student.num);

//        for (int k = 0; k < Student.num; k++)
//        {
//            NameList[k] = studentList[k].Name;
//            AgesList[k] = studentList[k].Age;
//            // 输出每个学生的信息
//            WriteLine($"Student {k + 1}: Name = {studentList[k].Name}, Age = {studentList[k].Age}");
//        }

//        // 在输出学生信息后添加以下代码来按年龄排序
//        Array.Sort(AgesList, studentList, 0, Student.num);
//        // 输出排序后的学生信息
//        WriteLine("\nSorted Students by Age:");
//        for (int k = 0; k < Student.num; k++)
//        {
//            WriteLine($"Student {k + 1}: Name = {studentList[k].Name}, Age = {studentList[k].Age}");
//        }

//    }
//}



//class Program
//{
//    const int cst_ArraySize = 5;
//    static void Main()
//    {
//        string[] NameList = new string[cst_ArraySize] { "Alice", "Bob", "Charlie", "David", "Eva" };
//        int[] AgesList = new int[cst_ArraySize] { 18, 20, 22, 19, 21 };
//        Student[] studentList = new Student[cst_ArraySize];
//        //不够严谨，一一对应关系可能有错误
//        for (int i = 0; i < cst_ArraySize; i++)
//        {
//            studentList[i] = new Student(NameList[i], AgesList[i]);
//        }
//        WriteLine("学生信息：");
//        foreach (var student in studentList)
//        {
//            WriteLine($"Name: {student.Name}, Age: {student.Age}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Student> studentList = new List<Student>();
//        studentList.Add(new Student("Tom", 20));
//        studentList.Add(new Student("Mike", 25));
//        studentList.Add(new Student("Mary", 21));
//        studentList.Add(new Student("Tim", 19));
//        // 添加学生对象到 List 中

//        studentList.Sort((s1, s2) => s1.Age.CompareTo(s2.Age)); // 按年龄排序
//        WriteLine("按年龄排序后的学生信息：");
//        foreach (var student in studentList)
//        {
//            WriteLine($"Name: {student.Name}, Age: {student.Age}");
//        }
//    }
//}


class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();
        // 允许用户输入学生信息，直到输入 "0" 为止
        while (true)
        {
            Write("请输入学生姓名 ( 输入“0”完成录入 ): ");
            string name = ReadLine();
            if (name == "0")
                break;
            Write("请输入学生年龄: ");
            if (int.TryParse(ReadLine(), out int age))
            {
                studentList.Add(new Student(name, age));
            }
            else
            {
                WriteLine("无效的年龄，请输入有效数字！");
            }
        }

        // 按年龄排序学生列表
        studentList.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
        WriteLine("按年龄排序后的学生信息：");
        foreach (var student in studentList)
        {
            WriteLine($"Name: {student.Name,-10}, Age: {student.Age}");
        }
    }
}

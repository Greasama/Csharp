
using System.Reflection.Metadata;
using static System.Console;

//泛型集合的List<T>类
List<Student> students = new List<Student>
{
            new Student { Name = "Mary", Score = 79.25 },
            new Student { Name = "Emily", Score = 82.47},
            new Student { Name = "Tomas", Score = 78.37},
            new Student { Name = "Joson", Score = 69.0},
            new Student { Name = "Steven", Score = 95.72}
};
double totalScore = students.Sum(total => total.Score);
double average = students.Average(avg => avg.Score);
double maxScore = students.Max(max => max.Score);
double maxAge = students.Max(max => max.Age);

WriteLine($"总分：{totalScore:N0}");
WriteLine($"平均分: {average}");
WriteLine($"最高分：{maxScore}");
WriteLine($"最大年龄:{maxAge}");
ReadKey();

class Student //创建一个Student类
{
    public string? Name { get; set; }
    public double Score { get; set; }
    public int Age { get; set; }
}
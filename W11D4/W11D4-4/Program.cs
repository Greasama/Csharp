using static System.Console;

////泛型方法加入条件约束
//WriteLine($"{127}, {63}, {311} " +
//           $"最大值：{checkData(127, 63, 311)}");

//WriteLine($"{115.372}, {12.147}, {167.258} " +
//   $"最大值：{checkData(115.372, 12.147, 167.258)}");

//WriteLine($"{"Sunday"}, {"Monday"}, {"Tuesday"} 最大值：" +
//   $"{checkData("Sunday", "Monday", "Tuesday")}");

//ReadKey();

////定义泛型方法以where加入条件约束，搭配IComparable<T>接口实现其类型参变量
//static T checkData<T>(T one, T two, T three) where T : IComparable<T>
//{
//    T max = one;//假定第一个参数是最大值
//    //调用CompareTo()方法将第一个参数和第二个、第三个参数分别进行比较
//    if (two.CompareTo(max) > 0)
//        max = two;
//    if (three.CompareTo(max) > 0)
//        max = three;
//    return max;
//}


//创建字典并初始化(字典可以用于加密解密的解密本)
Dictionary<string, int> student = new()
{
    ["Peter"] = 78,
    ["Leonardo"] = 65,
    ["Michelle"] = 47,
    ["Noami"] = 92,
    ["Richard"] = 87
};
WriteLine($"{"名字",-8} {"分数",3}");

//读取字典方式一
foreach (var item in student)
    WriteLine($"{item.Key,-10} {item.Value,3}");

if (student.TryGetValue("Noami", out int value))
    student.Remove("Noami");
WriteLine("\n删除Noami，尚有……");

//读取字典方式二，只读Key，属性Count获取项数
foreach (KeyValuePair<string, int> item in student)
    Write($"{item.Key}  ");
Write($"{student.Count}人\n");

//产生有序字典并复制原有字典，加入一个新项
SortedDictionary<string, int> sortedStud =
   new(student) { { "Joson", 82 } };
WriteLine("\n新加入Joson之后，按名字排序");
foreach (var item in sortedStud)
    WriteLine($"{item.Key,-10} {item.Value,3}");

ReadKey();
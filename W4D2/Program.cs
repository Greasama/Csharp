using System;
using static System.Console;
namespace W4D2
{
    internal class Program
    {
        //enum City : int
        //{
        //    shanghai = 200000,
        //    hangzhou = 310000,
        //    ningbo = 315000,
        //    shaoxing = 312000,
        //    wenzhou = 325000
        //}

        //struct Computer
        //{
        //    public int price;
        //    public string secial;
        //    public DateTime madeDate;
        //}

        struct Student
        {
            public string Name;
            public string Sex = "Male";
            public int Age = 20;
            public DateTime Birth;
            public string College;
            public string Major;
            public int Remark;
            public Student(string inputSex, int inputAge)
            {
                Name = "";
                Sex = inputSex;
                Age = inputAge;
                Birth = default;
                College = "";
                Major = "";
                Remark = 0;
            }//如果不在构造函数中对 Name 进行初始化，它会被默认初始化为 null。
        }
   
        static void Main(string[] args)
        {
            Student Mine;
            Mine.Name = "BruceZhou";
            Student student = new Student("Male",25);
            Mine.Birth = Convert.ToDateTime("1998/9/27");
            Mine.College = "SUES";
            Mine.Major = "Mechanical Design";
            Mine.Remark = 78;
            WriteLine($"学生姓名：{Mine.Name}" +
                    $"\n成绩：{Mine.Remark}" +
                    $"\n考试科目：{Mine.Major}");
            Student Tom;
            Tom.Name = "Tom";
            Tom.Major = "Mechanical Design";
            Tom.Remark = 78;

            WriteLine($"学生姓名：{Tom.Name}" +
          $"\n成绩：{Tom.Remark}" +
          $"\n考试科目：{Tom.Major}");

            if (Mine.Remark > Tom.Remark)
            {
                WriteLine($"{Mine.Name}的成绩比{Tom.Name}高。");
            }
            else if (Mine.Remark < Tom.Remark)
            {
                WriteLine($"{Tom.Name}的成绩比{Mine.Name}高。");
            }
            else
            {
                WriteLine($"{Mine.Name}和{Tom.Name}的成绩相同。");
            }

            int totalScore = Mine.Remark + Tom.Remark;
            WriteLine($"两人分数相加结果：{totalScore}");


            //const float Square = 3.30579F;
            //Write("请输入坪数：");
            //float area = Convert.ToSingle(ReadLine());//convert方法
            //WriteLine($"{area}坪 = {Square * area}平方米");
            //const float PI = 3.14159F;
            //const float Circular = PI * 25.0F;
            //WriteLine($"圆面积->{Circular}");//声明常数并使用常数表达式
            //const string name = "Tomas";
            //const string city = "Taibei";
            //const string work = $"{name} is currently working in {city}";
            //WriteLine(work);
            //ReadKey();//字符串长度

            //City zone1, zone2;//声明
            //int pt1, pt2;
            //zone1 = City.shanghai;//存取枚举成员
            //zone2 = City.hangzhou;//输出常数值必须指定转换类型
            //pt1 = (int)City.ningbo;
            //pt2 = (int)City.shaoxing;
            //WriteLine($"城市：{zone1},{zone2}");
            //WriteLine($"宁波、绍兴的邮政编码：{pt1},{pt2}");
            //Write(City.wenzhou);//直接以“枚举成员.名称”来存取
            //WriteLine($"邮政编码：{(int)City.wenzhou}");

            //    Computer personPC;
            //    personPC.price = 8_340;
            //    personPC.madeDate = DateTime.Today;
            //    personPC.secial = "ZCT-20211221309A";
            //    WriteLine($"计算机价格：{personPC.price:c0}" +
            //        $"\n制造日期：{personPC.madeDate:D}" +
            //        $"\n序号：{personPC.secial}");
        }
    }
}
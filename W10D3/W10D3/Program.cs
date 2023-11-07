using System;
using static System.Console;
using static System.Math;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

//namespace Ex0704 //静态方法的重载
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] num;//定义数组
//            Write("请选择 1.输入二个数值  2.输入三个数值 \n或 按0离开-> ");
//            int Out = int.Parse(ReadLine());
//            //根据选择的数字——0, 1, 2 去调用不同参数的DoWork方法
//            if (Out == 0)
//            {
//                DoWork(); //调用方法，无参数
//            }
//            else if (Out == 1)
//            {
//                int size = 2; //设置数组长度
//                num = new int[size]; //根据长度重新设置数组大小
//                for (int i = 0; i < num.Length; i++)
//                {
//                    Write($"第{i + 1}个：");
//                    num[i] = int.Parse(ReadLine());
//                }
//                //调用方法，以数组为参数进行传递
//                DoWork(num);
//            }
//            else if (Out == 2)
//            {
//                int size = 3;
//                num = new int[size];
//                for (int i = 0; i < num.Length; i++)
//                {
//                    Write($"第{i + 1}个：");
//                    num[i] = int.Parse(ReadLine());
//                }
//                DoWork(num, 0);
//            }
//            ReadKey();
//        }
//        //方法重载1——无参数; 使用表达式主体定义方法
//        public static void DoWork() => WriteLine("没有输入任何数值");
//        //方法重载2——传入数组，两数相加
//        public static void DoWork(int[] one)
//        {
//            int total = 0;
//            for (int i = 0; i < one.Length; i++)
//                total += one[i];
//            Write($"两数相加：{total:n0}");
//        }
//        //方法重载3——传入数组，找出最大值
//        public static void DoWork(int[] one, int max)
//        {
//            ////调用Math.Max找出3个数中的最大值
//            //max = Math.Max(one[0], Math.Max(one[1], one[2]));

//            Array.Sort(one);
//            max = one[2];
//            Write($"最大值：{max:n0}");
//        }
//    }
//}


//namespace Ex0705//输出等差数列
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //输入各项参数
//            WriteLine("--等差数列的和--");
//            Write("请输入首项：");
//            int first_value = int.Parse(ReadLine());
//            Write("请输入末项：");
//            int last_value = int.Parse(ReadLine());
//            Write("请输入公差：");
//            int item = int.Parse(ReadLine()!);

//            //调用类的静态方法
//            int total = Progression(
//               first_value, last_value, item);
//            ReadKey();
//        }
//        //定义类的静态方法，直接存取
//        static int Progression(int first, int last,
//              int diversity)
//        {
//            int temp, number;

//            //检查传入的首项是否大于末项
//            if (first < last)
//            {
//                temp = first; //首项小于末项则予以置换
//                first = last;
//                last = temp;
//            }

//            int index = 0;
//            int lastItem = last;
//            WriteLine("------- 以下列出等差数列 --------");
//            for (int k = first; k >= last; k -= diversity)
//            {
//                WriteLine($" 第{++index}项={k}");
//                lastItem = k;
//            }
//            last = lastItem;
//            number = (first - last) / diversity + 1;  //计算项数
//            int sum = (number * (first + last)) / 2;   //计算等差数列的和
//            WriteLine($"{first}到{last}" + $"等差数列的和：{sum:N0}");//输出等差数列的和
//            WriteLine($"首项 = {first}，" + $"末项 = {last}，公差= {diversity}"); //输出形式参数的值
//            WriteLine("------- 等差数列结束 --------");
//            return sum; //返回计算结果
//        }
//    }
//}


///* calcNum()和calcNumeral()都采用表达式主体，无存取修饰词，以private为存取范围
//分别以传值和传址进行调用，这两个方法所得结果会不同
//*/
//namespace Ex0706
//{
//    internal class program
//    { 
//    static void Main(string[] args)
//        {
//            Write("请输入一个10-25之间的数字：");
//            double num = double.Parse(Console.ReadLine());
//            //使用运算符is配合逻辑运算符进行对比，检查输入的数字是否在特定范围内
//            if (num is < 10 or > 25)
//                Write("超出范围，不进行计算。");
//            else
//            {
//                CalcNum(num);//传值调用
//                WriteLine($"传值调用，数字 = {num}");
//                CalcNumeral(ref num);//传址调用
//                WriteLine($"传址调用，数字 = {num}");
//            }
//            ReadKey();
//        }
//        //使用传值调用
//        static void CalcNum(double figure) => figure = Math.Pow(figure, 2);

//        //使用传址调用
//        static void CalcNumeral(ref double figure) => figure = Math.Pow(figure, 2);
//    }
//}


///* 创建对象后，采用传值调用，静态方法showMsg()接收的是first对象的副本
//   即使它也实例化另一个对象one，并不会影响主程序的对象  */
//namespace Ex0707
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Score first = new() { Name = "Janet", Mark = 91 }; //创建对象
//            WriteLine($"实际参数->调用前的值:{first.Name}, 分数 {first.Mark}");
//            ShowMsg(first);        //以对象作为传递目标
//            WriteLine($"实际参数->调用后的值:{first.Name}, 分数 {first.Mark}");
//            ReadKey(); //程序执行暂停，等待输入任意键
//        }
//        //声明静态方法
//        static void ShowMsg(Score one) => one = new() //重新创建一个对象
//        { Name = "Peter", Mark = 73 };   //指定名字、分数

//        static void ShowMsg(ref Score one)
//        {
//            WriteLine($"形式参数->接收值：{one.Name}, 分数 {one.Mark}");
//            one = new() { Name = "Peter", Mark = 73 };
//            WriteLine($"形式参数->更新值:{one.Name}, 分数 {one.Mark}");
//        }
//    }
//    class Score
//    {
//        //字段：Name、Mark，采用自动实现属性
//        public string Name { get; set; }
//        public int Mark { get; set; }
//    }
//}


//namespace Ex0708
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ModifyScore ted = new()   //创建对象
//            { Name = "Teddy", Mark = 91 };
//            ShowMsg(ref ted);                     //以对象作为传递目标
//            Console.WriteLine($"{ted.Name}, 分数 {ted.Mark}");
//            Console.ReadKey(); //程序执行暂停，等待输入任意键
//        }
//        //使用方法参数ref，采用传址调用
//        static void ShowMsg(ref ModifyScore one)
//        {
//            //重新创建一个对象，指定名字和分数
//            one = new ModifyScore()
//            { Name = "Peter", Mark = 73 };
//        }
//    }
//    //字段：Name、Mark自动实现属性
//    class ModifyScore
//    {
//        public string Name { get; set; }
//        public int Mark { get; set; }
//    }
//}


//namespace Ex0709
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] score1 = { 78, 96, 45, 33 }; //声明数组并初始化
//            Write("Peter 选修了{0}科\n", score1.Length);
//            CalcScore(score1);//调用静态方法

//            int[] score2 = { 95, 76, 55, 64, 74, 91, 87 };
//            Write($"Robecca 选修了{score2.Length}科\n");
//            CalcScore(score2);

//            Write($"Bob 选修了{1}科\n");
//            CalcScore(100);

//            ReadKey();
//        }
//        //静态方法：传递长度不一的数组，加入params关键词
//        static void CalcScore(params int[] one)
//        {
//            int sum = 0;
//            for (int count = 0; count < one.Length; count++)
//                sum += one[count]; //加总数组元素

//            double average = (double)sum / one.Length; //求平均分
//            WriteLine($"总分 = {sum}，平均分 = {average:f3}");
//        }
//        static void CalcScoreArray(int[] one)
//        {
//            int sum = 0;
//            for (int count = 0; count < one.Length; count++)
//                sum += one[count]; //加总数组元素

//            double average = (double)sum / one.Length; //求平均分
//            WriteLine($"总分 = {sum}，平均分 = {average:f3}");
//        }
//    }
//}


//namespace Ex0710
////注意数组元素的检查，防止硬件软件出现无法挽回的错误（例如覆写索引）
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            initArray(out int[] two);
//            Write("数组元素：");
//            for (int i = 0; i < two.Length; i++)
//            {
//                Write(two[i] + " ");
//            }
//            ReadKey();
//        }
//        static void initArray(out int[] one)
//            => one = new int[5] { 21, 12, 32, 14, 5 };
//    }
//}

//namespace Ex0710
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] two = null; // 初始化 two 数组
//            initArray(ref two); // 使用 ref 关键字传递引用
//            Console.Write("数组元素：");
//            for (int i = 0; i < two.Length; i++)
//            {
//                Console.Write(two[i] + " ");
//            }
//            Console.ReadKey();
//        }

//        static void initArray(ref int[] one)
//        {
//            one = new int[5] { 21, 12, 32, 14, 5 };
//        }
//    }
//}


//namespace Ex0711
//{
//    internal class Program
//    {
//        public const int Allow_InputTimes = 3;
//        static void Main(string[] args)
//        {
//            //制作一个输入报错的防护（用do...while...）
//            //（可在前方输入允许错误的次数，设定为常量）
//            Write("请输入你的名字：");
//            string name = ReadLine();

//            bool bWhetherInputOK = false;

//            Write("请输入语文成绩：");
//            //double chinese = Convert.ToDouble(ReadLine());
//            double chinese = 0.0f;
//            int InputTime = 0;
//            string str1 = $"您输入的语文成绩有误，输入次数超过{Allow_InputTimes}次，系统默认按0分处理";
//            string str2;
//            do
//            {
//                bWhetherInputOK = double.TryParse(ReadLine(), out chinese);
//                if (!bWhetherInputOK)
//                {
//                    ++InputTime;
//                    str2 = $"您输入的语文成绩格式有{InputTime}次错误，请重新输入";
//                    WriteLine((InputTime > Allow_InputTimes) ? str1 : str2);
//                    if (InputTime > Allow_InputTimes)
//                        break;
//                }
//            }
//            while (!bWhetherInputOK);

//            Write("请输入数学成绩：");
//            double math = Convert.ToDouble(ReadLine());

//            Write("请输入英语成绩：");
//            double english = Convert.ToDouble(ReadLine());

//            //第一行对齐同时留出姓名空间（感觉直接留个姓名位置会更好）
//            WriteLine($"\n{"语文-30%",13}  数学-40%  英语-30%  合计");
//            string line = new('-', 45);
//            WriteLine(line);
//            //ref提供你输入的数值的输出，out提供方法内的计算的输出
//            CalcScore(ref chinese, ref english, ref math, out double total);
//            Write($"{name}");
//            Write($" {chinese,10:N3}{english,10:N3}" +
//                $"{math,10:N3}{total,6}");
//            ReadKey();
//        }
//        //定义静态方法
//        static void CalcScore(ref double chi, ref double eng,
//           ref double math, out double sum)
//        {
//            chi *= 0.3;
//            eng *= 0.3;
//            math *= 0.4;
//            sum = chi + eng + math;
//        }
//    }
//}


////实参被调用时，使用命名参数传递参变量
//namespace Ex0712
//{
//    internal class Program
//    { 
//        static void Main(string[] args) 
//        {
//            PutName user = new();
//            user.Name = "Mr Jobs";
//            Write("请输入数量：");
//            int unit = Convert.ToInt32(Console.ReadLine());
//            Write("请输入金额：");
//            double bill = Convert.ToDouble(Console.ReadLine());
//            int outcome = FeeAmount(price: (int)bill, amount: unit);
//            WriteLine($"{user.Name}! 付款金额 {outcome:c}");
//            ReadKey();
//        }
//        //定义类的静态方法, 使用表达式主体
//        static int FeeAmount(int amount, int price) =>
//          amount * price;
//        class PutName
//        {
//            public string Name { get; set; }
//            //自动实现属性
//        }
//    }
//}


namespace Ex0713
{
    class ChoiceArg
    {
        private readonly string _name;
        public ChoiceArg(string Name = null) => _name = Name;//构造函数
        //定义类方法
        public void CalcScore(int eng = 0, int math = 0, int chin = 0)
        {
            int result = eng + math + chin;
            WriteLine($"{_name} -> 总分：{result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ChoiceArg tommy = new ChoiceArg("Tommy");
            tommy.CalcScore(67, 72, 92);           //传递3个参变量
            ChoiceArg juddy = new("Juddy");
            juddy.CalcScore(81);              //传递1个参变量
            ChoiceArg sarah = new("Sarah");
            sarah.CalcScore(84, 65);          //传递2个参变量

            ReadKey();
        }
    }
}
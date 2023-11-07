using System;
using static System.Math;
using static System.Console;
using System.Runtime.CompilerServices;

//namespace W10D2
//{
//internal class Program
//{
//    //定义度转弧度
//    const double cstDegreeToRad = PI / 180.0f;

//    static void Main(string[] args)
//    {
//        Write("请输入半径值：");
//        double Radius = Convert.ToDouble(ReadLine());
//        double area = PI * Pow(Radius, 2);
//        string line = new('-', 45);

//        //Abs,绝对值
//        Radius = Abs(Radius);

//        //Sign，符号
//        int mySign = Sign(Radius);

//        //Clamp,钳位（限制大小）（例：电机控制中的控制器和驱动器）
//        Double myClamp = Clamp(Radius, 1D, 100D);
//        Radius = myClamp;

//        //Round 精确；Ceiling 进位；Floor 退位（例：零钱和整钱）
//        WriteLine($"\n方法{"Round()",10}" +
//            $" | {"Ceiling()",10} | {"Floor()",10}");
//        WriteLine(line);
//        WriteLine($"{Round(area, 4),12:N4} | {Ceiling(area),12:N0} | {Floor(area),12:N0}");
//        WriteLine(mySign);
//        ReadKey();

//        double a = 10; double b = 5;

//        Write("请输入角度值：");
//        double Count = Convert.ToDouble(ReadLine());
//        double Angle = cstDegreeToRad * Count;
//        //double Angle = 2 * PI / 3;

//        double result = Sqrt(Pow(a, 2) + Pow(b, 2) - a * b * Cos(Angle));//余弦定理
//        WriteLine($"第三边长度为{Round(result, 4),10}");
//    }
//}
//}


///********************************************************************************
// *  Name              :  CalScaraPositionXY
// *  Purpose           :  计算Scara机器人的正解
// *  Input Parameter
// *  [1]Point mYPoint  :  需要计算正解的运动轴参数（Length,theta）
// *  Output Parameter
// *  [1]double alf     :  第一关节相对于X轴的位置, 矢量角度，带符号 CCW-> + Unit: Rad 
// *  [2]double Beta    :  第二关节相对于第一关节的矢量角度, 带符号 CCW-> + Unit: Rad
// *  Points mYPoint    :  传址-引用，输出计算后的点P(x,y)坐标
// *  Return Value      :  -1 :  运行计算错误 
// *                        0 ： 运行计算OK
// * ******************************************************************************/
////SCARA机器人的XY正解
//class ScaraRobot
//{
//    // 机器人臂长度
//    private double arm1Length;
//    private double arm2Length;
//    // 机器人关节角度
//    private double theta1;
//    private double theta2;
//    public ScaraRobot(double arm1Length, double arm2Length)
//    {
//        this.arm1Length = arm1Length;
//        this.arm2Length = arm2Length;
//        //可使用get;set;设定参数
//    }
//    public void SetJointAngles(double theta1, double theta2)
//    {
//        this.theta1 = theta1;
//        //轴的运动范围保护，防止绞线
//        theta1 = Clamp(theta1, -2.0 * PI, 2.0 * PI);
//        this.theta2 = theta2;
//        theta2 = Clamp(theta2, -1.0 * PI, 1.0 * PI);
//    }
//    //正解最终位置在x,y轴的长度的计算公式
//    public void ForwardKinematics(out double x, out double y)
//    {
//        x = arm1Length * Cos(theta1) + arm2Length * Cos(theta1 + theta2);
//        y = arm1Length * Sin(theta1) + arm2Length * Sin(theta1 + theta2);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        double arm1Length = 100; // 第一段臂长度
//        double arm2Length = 100;  // 第二段臂长度
//        ScaraRobot robot = new ScaraRobot(arm1Length, arm2Length);
//        // 设置关节角度（以弧度为单位）
//        double theta1 = 0.0f;
//        double theta2 = 0.0f;
//        robot.SetJointAngles(theta1, theta2);
//        robot.ForwardKinematics(out double x, out double y);
//        // 计算正解
//        //此处可使用反解
//        Console.WriteLine($"机器人末端的坐标为：({x}, {y})");
//    }
//}


Random lotto = new((int)DateTime.Now.Ticks);
//一个日期和时间，从公历0001.1.1 00：00：00.000，以100ns为间隔来表示
byte[] item = new byte[6];
lotto.NextBytes(item);
//item用于储存产生的随机数
//lotto.NextBytes(item);产生0-255的随机数
Write("乐透，有：");
for (int count = 0; count < item.Length; count++)
{
    if (count == 5)
    {
        byte special = item[count];
        WriteLine($"\n特别奖：{special}");
    }
    else
        Write($"{item[count],4}");
}


//计算成绩平均数
//定义静态方法-一般方法
/*static double CalcAverage(double Chin_score,
      double Eng_score, double Math_score)
{
    //变量Average_score用于存储平均分
    double Average_score = (
       Chin_score + Eng_score + Math_score) / 3;
    return Average_score;   //返回计算后的平均分
}*/
//类的表达式主体定义方法
static double CalcAverage(double Chin_score, double Eng_score, double Math_score) => (Chin_score + Eng_score + Math_score) / 3.0;

double chinese, english, math, equal;//各科分数
Write("请输人名字：");
string? studentName = ReadLine();
Write("请输人语文分数：");
chinese = Convert.ToInt32(ReadLine());
Write("请输人英语分数：");
english = Convert.ToInt32(ReadLine());
Write("请输人数学分数：");
math = Convert.ToInt32(ReadLine());

//直接调用静态方法——计算平均分
equal = CalcAverage(chinese, english, math);
WriteLine($"{studentName}！你好！" +
   $" 3科平均分 = {equal:N3}");

ReadKey();
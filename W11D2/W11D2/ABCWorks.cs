global using static System.Console;   //全局，适用整个项目
global using Ex0808;   //全局，导入文件范围命名空间
//时间管理成类 

string line = new string('-', 40);
WriteLine("第一个方法：");
NonDisplay();
WriteLine(line);
WriteLine("第二个方法：");
SecDisplay();
WriteLine(line);
WriteLine("第三个方法：");
ThreeDispaly();

ReadKey();

//方法一：实现各个对象并调用showMessage()，只有兼职员工算出时薪
static void NonDisplay()
{
    Staff Peter = new();
    Peter.ShowMessage();
    FullWork fullWorker = new();
    fullWorker.ShowMessage();
    Provisional partWork = new();
    partWork.ShowMessage(); //使用覆写，算出时薪
}

/* 方法二：输出正式员工月薪、兼职员工时薪
   实例化子类对象并直接存取本身所定义的方法
   修饰词用了new和override，调用calcMoney方法
   分别算出正式员工的月薪和兼职员工的时薪
*/
static void SecDisplay()
{
    FullWork fullWorker = new();
    fullWorker.CalcMoney();
    Provisional partWork = new();
    partWork.CalcMoney();
}

//方法三：以父类为类，以子类为其值的类型
static void ThreeDispaly()
{
    /*  Staff Peter = new();
      Staff fullWorkder = new Provisional();
      Peter.CalcMoney();       //调用父类的方法
      fullWorkder.CalcMoney(); //调用子类的方法*/
    Staff Peter = new();
    Peter.CalcMoney();
    Staff partWork = new Provisional();
    partWork.CalcMoney();

}
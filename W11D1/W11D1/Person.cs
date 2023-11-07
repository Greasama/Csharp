using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0803
{
    //基类
    internal class Person
    {
        protected int BaseSalary { get; set; }
        protected string Name { get; set; }
        //自动实现属性
        public Person(string _name, int wage)
        {
            Name = _name;
            BaseSalary = wage;
            WriteLine($"员工：{Name},薪水：{BaseSalary:C0}");
        }
        //定义基的构造函数：传入名字和薪资
        public void ShowTime()
        {
            DateTime hireDate = new(2009,3,17);
            DateTime justNow = DateTime.Today;
            //hireDate——就职日期; justNow——获取系统当前的日期
            TimeSpan jobDays = justNow - hireDate;
            //以TimeSpan获取工作天数，当前的日期——就职日期
            double work = (double)(jobDays.Days) / 365;
            //先以Days属性获取天数，再换算成年份
            WriteLine($"雇用日期：" +
   $"{hireDate.ToShortDateString(),10}, " +
   $"工作：{work:F2} 年");
            //调用ToShortDateString()方法将hireDate转换为简短的日期字符串
        }
    }
}

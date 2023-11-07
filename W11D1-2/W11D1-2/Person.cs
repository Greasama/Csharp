using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0804
//C# 10.0 文件范围命名空间
{
    internal class Person
    {
        private int baseSalary;
        //Name——自动实现属性
        protected string Name { get; set; }
        //实现属性，扣除保险费，以两个if语句来判断value值
        public int BaseMoney
        {
            get /*=> baseSalary;*/
            {
                baseSalary = baseSalary - 10000;
                return baseSalary;
            }
            set//根据薪资等级扣除保险费(属性器也可以写很长)
            {
                if (value >= 25800 && value <= 58300)
                {
                    if (value < 25800)
                        baseSalary = value - 256;
                    else if (value < 28200)
                        baseSalary = value - 584;
                    else if (value < 32800)
                        baseSalary = value - 612;
                    else if (value < 35300)
                        baseSalary = value - 726;
                    else if (value < 43300)
                        baseSalary = value - 866;
                    else if (value < 58300)
                        baseSalary = value - 1226;
                }
                else WriteLine("无法计算");
            }
        }
        public Person()
        {
            Name = "Charles";
            BaseMoney = 39685;
        }
        public void Show() =>    //定义成员方法，输出信息
      WriteLine($"员工{Name,7}，实领薪水 {BaseMoney:C0}");
    }
}


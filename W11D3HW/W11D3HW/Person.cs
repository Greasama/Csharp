using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D3HW
{
    internal class Person
    {
        protected int workhr { get; set; }
        protected string name { get; set; }
        protected double Salary { get; set; }
        public Person(string name, int workhr,double Salary)
        {
            this.name = name;
            this.workhr = workhr;
            this.Salary = Salary;
        }
        //定义虚拟方法
        public virtual void CalcOverWork()
        {
            WriteLine("没有加班费");
        }
    }
}

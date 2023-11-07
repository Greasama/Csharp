using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0803
{
    internal class Employee : Person
    {
        public Employee(string Name, int pay) : base(Name, pay)
        {
            /* this.Name = "Mick";    //在调用基类构建函数后，还可以自己进行更改或其它操作
        this.BaseSalary = 0;*/
            Name = "Mick";  //无法更改掉名字和薪水
            pay = 10;
        }
        public void HireTime()
        {
            DateTime startDate = DateTime.Today;
            WriteLine($"雇用日期：" +
               $"{startDate.ToShortDateString()}" + $"名字:{Name}" + $",薪水:{BaseSalary}");
        }
    }
}

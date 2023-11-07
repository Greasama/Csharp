using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D3HW
{
    internal class CalWH : Person
    {
        public CalWH(string name, int workhr,double Salary) 
            : base(name, workhr,Salary){ }
        public override void CalcOverWork()
        {
            double overtimePay = 0.0;

            if (workhr <= 2)
            {
                overtimePay = Salary / 30 / 2 * 1.25;
                WriteLine($"职工{name},加班{workhr}小时，加班费{overtimePay}");
            }
            else if (workhr <= 3)
            {
                overtimePay = Salary / 30 / 2 * 1.3;
                WriteLine($"职工{name},加班{workhr}小时，加班费{overtimePay}");
            }
        }
    }
}


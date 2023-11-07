using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//calcMoney()方法——用new修饰词来产生新方法
//namespace Ex0808;

internal class FullWork : Staff
{
    private int salary; //字段——获取计算的月薪
    protected new string Name { get => "Janet"; }

    //定义自己的方法——计算月薪，隐藏父类的虚拟方法
    public new void CalcMoney()
    {
        int dayMoney = 1_850;
        salary = dayMoney * 25;
        WriteLine($"{Name} 正式员工，薪水 {salary:C0}");
    }
}

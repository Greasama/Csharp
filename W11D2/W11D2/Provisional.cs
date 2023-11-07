using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//calcMoney()方法——用override修饰词覆写父类的虚拟方法calcMoney()
//namespace Ex0808;

internal class Provisional : Staff
{
    //prtSalary存储薪资, 只读属性Name以存取器get来获取名字Tomas
    private int prtSalary;
    protected new string Name { get => "Tomas"; }

    //覆写基类方法，计算时薪
    public override void CalcMoney()
    {
        int hourMoney = 275;
        prtSalary = hourMoney * 5 * 20;
        WriteLine($"{Name} 兼职员工，薪水 {prtSalary:C0}");
    }
}

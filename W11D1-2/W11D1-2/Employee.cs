using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex0804
{
    internal class Employee:Person
    {
        public Employee()//构造函数
        {
            Name = "Wilson";
            BaseMoney = 41258;
        }
        /*public void Show()  //子类与父类的方法同名而产生错误
        {

        }*/
        new public void Show()  //子类与父类的方法同名而产生错误
        {
            WriteLine($"员工{Name,7}");
            return;
        }
        //以base关键词调用基类的方法
        public void Display() => base.Show();

        public void Display(string strInfo)
        {
            Write($"派生类存取基类成员方法:{strInfo}\n");
            base.Show();
        }
    }
}

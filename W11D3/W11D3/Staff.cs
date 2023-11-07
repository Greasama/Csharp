using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 定义抽象类——定义员工的架构——名字，薪水，
   一个抽象属性Salary和一个抽象方法ShowMessage()
   必须由继承的派生类实现（覆写）
*/
namespace Ex0809
{
    abstract class Staff
    {
        private string? _name;//私有字段
        //构造函数采用表达式主体
        public Staff(string staffName)=>
            Name = staffName;
        //属性名字获取构造函数的参数值
        protected string Name
        { //采用表达式主体定义来实现实行get,set存取器
            get => _name!; set => _name = value;
        }
        //以abstract配合存取器get将Salary定义成只读属性
        public abstract int Salary { get; }
        //定义抽象方法（不能加程序区块的大括号）
        public abstract void ShowMessage();
    }
}

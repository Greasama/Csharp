
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0807
{
    internal class Person
    {
       
        //Height, Hair自动实现属性
        protected int Height { get; set; }
        protected string Hair { get; set; }
        public Person()   //父类的构造函数
        {
            Height = 170;
            Hair = "棕色";
        }
        //表达式主体定义成员方法——输出父类属性
        public virtual void ShowMessage() => WriteLine(
           $"父亲，{Hair}头发，身高 {Height} cm");
    }
}
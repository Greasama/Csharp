using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0811
{
    internal class Student : ISchool, IGrade
    {
        private int _subject; //字段1——存放选修分数
        private int _status; //字段2——学生身份
        public int ISubject //实现接口ISchool属性
        { 
            get { return _subject; } 
            set { _subject = value; }
        }
        public int IStatus //实现接口IGrade属性
        {
            get => _status;
            set => _status = value;
        }
        //构造函数，传入参数——identity学生身份，course学分数
        public Student(int id,int course) 
        { 
            ISubject = course;
            IStatus = id;
        }
        public void IShowMsg()//实现接口ISchool的方法
        {
            int account = 1_850, total = 0;
            if (_status == 1)//一般学生
            {
                account = 1_470;
                total = ISubject * account;//计算学分费用
            }
            else if (_status == 2) //硕博生加指导费用
                total = _subject * account + 9_500;
            WriteLine($"！学分费用共 {total:C0} 元");
        }
    }
}

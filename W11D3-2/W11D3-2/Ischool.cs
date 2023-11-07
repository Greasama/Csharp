using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0810
{
    internal interface Ischool
    {
        int Subject { get; set; }
        void ShowMessage();
    }
    internal class Student : Ischool   //实现接口
    {
        private int _subject;//字段

        public int Subject //实现接口的属性
        {
            get => _subject;
            set => _subject = value;
        }

        //表达式主体，构造函数，传入学分数
        public Student(int subj) => Subject = subj;

        public void ShowMessage()//实现接口的方法
        {
            int account = 1_850;
            int total = Subject * account;//计算学分费用
            WriteLine($"！学分费用共{total:C0}");
        }
    }
}

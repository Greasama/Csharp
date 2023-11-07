using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Education : School
{
    //自动实现属性，存放上课人数
    //private int Student { get; set; }
    public Education()//构造函数
    {
        Subject = "英语会话";
        Room = 1206;
        Teacher = "Poe Dameron";
    }

    //public Education(string Subject, int Room, string Teacher)//构造函数
    //{
    //    this.Subject = Subject;
    //    this.Room = Room;
    //    this.Teacher = Teacher;
    //}

    //定义子类的方法，传入学生数是否达到15人以上
    public void Display(int people)
    {
        Student = people;
        if (Student < 15)
            WriteLine($"只有{Student}人，不会开课");
        else
        {
            WriteLine($"科目：{Subject}，教室：{Room}, " +
               $"教师：{Teacher}，学生人数：{Student}");
        }
    }
}


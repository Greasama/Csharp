﻿using studentNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace myUserNameSpace
{
    internal class MyUser
    {
        internal class UserLib
        {
            static int fnGetStrByteCount(string mOrigianlString)       //判断字符串的Byte占位大小
            {
                int totalCount = 0;
                for (int i = 0; i < mOrigianlString.Length; i++)
                {
                    string mChar = mOrigianlString.Substring(i, 1);
                    totalCount = ((Encoding.Default.GetByteCount(mChar)) == 1) ? ++totalCount : (totalCount + 2);
                }
                return totalCount;
            }
            //计算占位并给用空格补齐全
            public static string PlaceHolder(string str, int iAllSize, bool bMiddleAlign = false)
            {
                int iInitialSize = fnGetStrByteCount(str);
                string tempStr = str;
                int iExceedCout = 0;
                if (Abs(iAllSize) > str.Length)
                {
                    iExceedCout = Abs(iAllSize) - iInitialSize;
                    if (bMiddleAlign)
                    {
                        string strLeft = new string(' ', iExceedCout / 2);
                        string strRight = new string(' ', iExceedCout - iExceedCout / 2);
                        str = strLeft + str + strRight;
                    }
                    else
                    {
                        if (iExceedCout > 0)
                        {
                            tempStr = new string(' ', iExceedCout);
                            str = (iAllSize > 0) ? (tempStr + str) : (str + tempStr);
                        }
                    }
                }
                return str;
            }
            //按照指定长度显示表格，不用C#占位符
            public static void display(Student st1, Student st2, int size, bool bMiddleAlign = false)
            {
                string str = "名字 数学 英语 计算机概论 总分";
                string[] strNameSubject = str.Split(' ');
                foreach (string item in strNameSubject)
                {
                    Write($"{PlaceHolder(item, size, bMiddleAlign)}|");
                }
                string line = new('-', Abs(size * 5) + 5);
                WriteLine("\n" + line);
                Write($"{PlaceHolder(st1.Name, size, bMiddleAlign)}|" +
                     $"{PlaceHolder(st1.Math.ToString(), size, bMiddleAlign)}|" +
                     $"{PlaceHolder(st1.Eng.ToString(), size, bMiddleAlign)}|" +
                     $"{PlaceHolder(st1.Comp.ToString(), size, bMiddleAlign)}|" +
                     $"{PlaceHolder(st1.Total().ToString(), size, bMiddleAlign)}|\n");
                WriteLine(line);
                Write($"{PlaceHolder(st2.Name!, size, bMiddleAlign)}|" +
                    $"{PlaceHolder(st2.Math.ToString(), size, bMiddleAlign)}|" +
                    $"{PlaceHolder(st2.Eng.ToString(), size, bMiddleAlign)}|" +
                    $"{PlaceHolder(st2.Comp.ToString(), size, bMiddleAlign)}|" +
                    $"{PlaceHolder(st2.Total().ToString(), size, bMiddleAlign)}|\n");
                WriteLine(line);
            }
        }
    }
}
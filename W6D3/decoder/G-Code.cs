using System;
using System.Collections.Generic;
using static System.Console;

//G代码输出G00系列有问题，思路：改string试试
namespace decoder
{
    internal class Program
    {
        struct mNCFileManagement
        {
            public int iAllLineLength;
            public mNCPoint[] myPoint;
        }
        struct mNCPoint
        {
            public int iLineNum;
            public double x;
            public double y;
            public double z;
            public string[] strList;
            public int mCode; // M code
            public double feedRate; // Feed rate (F)

            // Constructor to initialize struct members
            public mNCPoint(int lineNum, double x, double y, double z, string[] strList, int mCode, double feedRate)
            {
                this.iLineNum = lineNum;
                this.x = x;
                this.y = y;
                this.z = z;
                this.strList = strList;
                this.mCode = mCode;
                this.feedRate = feedRate;
            }
        }
        static void Main(string[] args)
        {
            string strPlaceHolder = new string('-', 100);
            Write("\n" + strPlaceHolder + $"\r\t\t   数控代码的解析演示代码  {DateTime.Now}\n");
            char[] separNCCode = { 'N', 'X', 'Y', 'Z', 'M', 'F' };
            string[] strNCCodeList = { "N10X10.1Y20.2Z30.3M02F100", "N20X50Y60Z100M30F200", "N30X0Y0Z0M100F50" };

            mNCFileManagement myNCFile = new mNCFileManagement();
            myNCFile.iAllLineLength = strNCCodeList.Length;
            myNCFile.myPoint = new mNCPoint[myNCFile.iAllLineLength];

            for (int i = 0; i < myNCFile.iAllLineLength; i++)
            {
                myNCFile.myPoint[i] = new mNCPoint(); // 初始化一个新的mNCPoint结构体来存储当前行的数据
                // 解析行号（N值）
                myNCFile.myPoint[i].iLineNum = Int32.Parse(strNCCodeList[i].Substring(1, strNCCodeList[i].IndexOfAny(separNCCode, 1) - 1));
                // 将当前行的代码按照N、X、Y、Z、M、F进行分割
                string[] strCoordinate = strNCCodeList[i].Split(separNCCode, StringSplitOptions.RemoveEmptyEntries);
                // 解析并存储X、Y、Z坐标
                myNCFile.myPoint[i].x = Double.Parse(strCoordinate[Array.IndexOf(strCoordinate, "X") + 1]);
                myNCFile.myPoint[i].y = Double.Parse(strCoordinate[Array.IndexOf(strCoordinate, "Y") + 1]);
                myNCFile.myPoint[i].z = Double.Parse(strCoordinate[Array.IndexOf(strCoordinate, "Z") + 1]);
                // 解析并存储M、F代码
                myNCFile.myPoint[i].mCode = Int32.Parse(strCoordinate[Array.IndexOf(strCoordinate, "M") + 1]);
                myNCFile.myPoint[i].feedRate = Double.Parse(strCoordinate[Array.IndexOf(strCoordinate, "F") + 1]);
                // 将原始分割后的字符串数组存储在strList字段中，以便后续输出
                myNCFile.myPoint[i].strList = strCoordinate;
            }

            for (int i = 0; i < myNCFile.iAllLineLength; i++)
            {
                Write($"N: {myNCFile.myPoint[i].iLineNum,-8}");
                Write($"X: {myNCFile.myPoint[i].x,-8}");
                Write($"Y: {myNCFile.myPoint[i].y,-8}");
                Write($"Z: {myNCFile.myPoint[i].z,-8}");
                Write($"M: {myNCFile.myPoint[i].mCode,-8}");
                Write($"F: {myNCFile.myPoint[i].feedRate,-8}");
                WriteLine();
            }
            Write("\n" + strPlaceHolder + $"\r\t\t   数控代码的解析演示代码  {DateTime.Now}\n");
        }
    }
}

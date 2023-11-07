
using System;
using System.Text;
using static System.Console;
using static System.Math;

class solution
{
    public static class StringAligner
    {
        static int fnGetStrByteCount(string mOriginalString)
        {
            int byteCount = Encoding.Default.GetByteCount(mOriginalString);
            return byteCount;
        }
        static string fnGetStrByteCountAndUsePlaceHolder(string str, int AllSize)
        {
            int strLen = str.Length;
            // 如果输入的字符串或者指定的总长度为0，直接返回原字符串
            if ((strLen == 0) || (AllSize == 0))
                return str;
            // 计算实际显示的占位长度（考虑非ASCII字符）
            strLen = 0;
            for (int i = 0; i < str.Length; i++)
            {
                strLen = (IsCharacterNonASCII(str[i])) ? (strLen + 2) : (strLen + 1);
            }
            // 计算需要添加的占位符数量
            int Delta = Math.Abs(AllSize) - strLen;
            // 创建一个占位符字符串
            string strPlaceHolder = new string(' ', Math.Abs(Delta));
            // 根据情况决定如何对齐字符串
            return ((Delta <= 0) ? str : ((AllSize < 0) ? (str + strPlaceHolder) : (strPlaceHolder + str)));
        }

        static bool IsCharacterNonASCII(char c)
        {
            // return c > 127;     //此行范围不全是汉字，有其它字符，当然在此处没有其它字符，也运行没问题，
            return (c >= 0x4E00 && c <= 0x9FBB); //汉字的Unicode范围:4e00-9fbb
        }
        public static void Main(string[] args)
        {
            string[][] subject = new string[3][]
            {
                new string[] {"Johnson", "英语会话", "语文", "程序设计"},
                new string[] {"Molly", "语文", "计算机概论"},
                new string[] {"Peter", "英语", "人工智能", "多媒体论", "应用文"},
            };
            for (var i = 0; i < subject.Length; i++)
            {
                for (var j = 0; j < subject[i].Length; j++)
                {
                    string processedString = StringAligner.fnGetStrByteCountAndUsePlaceHolder(subject[i][j], -12);
                    Write(processedString);
                    // Write($"{processedString,-10}");//已经自己定义了占位函数，此句不用再写了
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}

//是一个C#程序，主要包括一个名为 `StringAligner` 的嵌套静态类，该类包含了一些方法，
//用于对字符串进行处理以实现文本对齐。

//`fnGetStrByteCount` 方法：
//   - 该方法用于获取一个字符串的字节长度。
//   - 它使用 `Encoding.Default.GetByteCount` 方法来计算字符串的实际长度
//   （一个字符可能占用多个字节，特别是对于非ASCII字符）。
//   - 字节长度用于确定文本在固定宽度的文本框中的对齐方式。

//`fnGetStrByteCountAndUsePlaceHolder` 方法：
//   - 该方法用于计算字符串的字节长度，并根据给定的总长度对字符串进行对齐处理。
//   - 首先，它计算字符串的实际字节长度，考虑到非ASCII字符可能占用多个字节。
//   - 然后，它计算出需要添加的占位符数量（根据总长度和实际长度的差值），并创建一个占位符字符串。
//   - 最后，它根据总长度和字符串的方向（正数或负数）将占位符添加到字符串的开头或末尾，以实现对齐。
//   - 这个方法可以用于在文本表格或文本对齐的场景中格式化文本。

//`IsCharacterNonASCII` 方法：
//   - 该方法用于检查一个字符是否为非ASCII字符（通常指非英文字母和数字）。
//   - 它使用Unicode范围来判断字符是否为汉字，因为汉字通常不属于ASCII字符集。
   
//`Main` 函数：
//   - `Main` 程序的入口点（也是以后实际的处理内容）。
//   - 在该方法中，创建了一个包含字符串数组的二维数组 `subject`，表示了一些学生和他们的课程。
//   - 使用嵌套的循环遍历这个二维数组，对每个字符串调用
//   `StringAligner.fnGetStrByteCountAndUsePlaceHolder` 方法来对齐字符串并输出结果。
//   - 这个示例演示了如何使用 `StringAligner` 类来对齐文本，尤其是在固定宽度的列中对齐文本，
//   以便更好地呈现表格或其他文本排列的情况。

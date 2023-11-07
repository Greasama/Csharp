using System;
using System.Text;
using static System.Console;

////Ex1
////认识Chars和Length属性
//string word = "  Microsoft Visual Studio 10.0!  ";
//int index;     //字符串下标编号
//int numWd = 0; //计算单词个数
//word = word.Trim();  //删除字符串前后的空白

////读取字符串中的字符
//for (int item = 0; item < word.Length; item++)
//{
//    //判断字符串中是否有标点符号或空格符
//    // if (Char.IsPunctuation(word[item]) |
//    if (Char.IsWhiteSpace(word[item]))
//        numWd++;
//}
//WriteLine($"句子:{word} \n有 {numWd} 个单词");
//WriteLine("读取第一个单词");

////使用for循环读取下标编号0~8的字符
//for (index = 0; index < 9; index++)
//    WriteLine($"[{index}] = 字符 <{word[index]}>");
//WriteLine($"字符串总长度 -> {word.Length}");

//ReadKey();

////Ex2
////字符串常用方法
//string source = "Visual Code";//原字符串
//string wds = "Studio ";//欲插入的字符串

////调用Insert()方法在下标编号7的位置插入字符串
//string sentence = source.Insert(7, wds);
//WriteLine($"原字符串{source}, \n插入字符串后：{sentence}");

//string word = "Programming";//用于替换的字符串
//sentence = sentence.Replace("Code", word);
//WriteLine($"替换后的字符串：{sentence}");

//sentence = sentence.Trim();
////分割字符串
//char[] separ = { ' ' };//以空白符来分割
//string[] str2 = sentence.Split(separ);
//WriteLine("\n---字符串分割后---");
//foreach (string item in str2)
//    Write($"{item}/");

////查找字符串的方法
//string str = "Visual C# programming";//原字符串
//WriteLine(str + "\n");
//bool begin = str.StartsWith("visual");
//WriteLine($"\"visual\"对比字符串的开头：{begin}");

//bool finish = str.EndsWith("programming");
//WriteLine($"\"programming\"对比字符串的结尾：{finish}");

//int start = str.IndexOf("g");//找到字符第一次出现时对应的下标编号
//int last = str.LastIndexOf("g");
//WriteLine($" g 开始位置：{start}, 最后位置: {last}");

//string secondStr = str.Substring(start, last - start + 1);//提取子字符串
//WriteLine($"\n子字符串：{secondStr}");

//StringBuilder类
StringBuilder strB = new();
WriteLine(strB.Capacity);//默认容量
strB.Append("if we are determined to fight for it!");
WriteLine("\n字符串长度 总容量");
WriteLine($"{strB.Length,-10}{strB.Capacity}");
strB.AppendLine("\n");
WriteLine($"{strB.Length,-10} {strB.Capacity}");
strB.AppendLine("Stolen Focus will debate about attention.");
WriteLine($"{strB.Length,-9} {strB.Capacity}");

WriteLine($"\n原字符串 -- {strB}");
string text = "about";
int index = strB.ToString().IndexOf(text);
if (index >= 0)
{
    strB.Remove(index,text.Length);
}
WriteLine($"变更后的字符串 -- {strB}");
strB.Replace("to fight for it","get it back");
/*
  获取欲插入位置的下标编号
  在strb对象中的"that"字符串前插入部分字符串。
  同样地，先以ToString()方法将strb对象转为字符串，
  再以IndexOf()方法获取that字符串的下标编号，并存储于index2变量中，
  然后再以Insert()方法插入字符串
*/
string nword = "transform the ";
int index2 = strB.ToString().IndexOf("debate");
strB.Insert(index2, nword);
WriteLine($"插入后的字符串 -- {strB}");

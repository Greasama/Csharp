using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex0909;

//定义委托，含有一个参变量（数值）
public delegate void Speculation(Int32[] numerical);
internal class FindNums
{
    //找出偶数
    public void IsEven(params Int32[] numerical)
    {
        Write("偶数值：");
        for (int k = 0; k < numerical.Length; k++)
        {
            //余数为0
            if (numerical[k] % 2 == 0)
                Write($"{numerical[k],4}");
        }
        WriteLine();   //换行
    }
    //找出奇数
    public void IsOdd(params Int32[] numerical)
    {
        Write("奇数值：");
        for (int k = 0; k < numerical.Length; k++)
        {
            if (numerical[k] % 2 == 1)
                Write($"{numerical[k],4}");
        }
        WriteLine();
    }
    //被3整除的数值
    public void IsDivide3(params Int32[] numerical)
    {
        Write("被3整除的数值：");
        for (int k = 0; k < numerical.Length; k++)
        {
            //被3整除
            if (numerical[k] % 3 == 0)
                Write($"{numerical[k],4}");
        }
        WriteLine();
    }
}
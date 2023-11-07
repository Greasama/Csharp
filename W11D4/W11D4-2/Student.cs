using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W11D4_2
{
    internal class Student<T>
    {
        private int index;//数组下标值
        private T[] multi_group = new T[5];//存储6个元素
        //将数据放入数组，string,int类型
        public void StoreArray(T[] arrData)
        {
            //if (index < multi_group.Length)
            //{
            //    multi_group[index] = arrData;
            //    index++;
            //}
            if (arrData.Length<=5)
                arrData.CopyTo(multi_group, 0); 
        }
        //读取数组元素
        //public void ShowMessage()
        //{
        //    foreach (T item in multi_group)
        //    {
        //        Write($"{item,-6} ");
        //    }
        //    WriteLine();
        //}
        public void ShowMessage/*<T>//方法自带，重名*/(T[] arrData)
        {
            foreach (T item in arrData)
                Write($"{item,-6} ");
            WriteLine();
        }

    }
}

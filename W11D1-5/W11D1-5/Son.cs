using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0807
{
    //internal class Son : Human
    //{
    //    //使用new修饰词，写入新的属性值
    //    public new int Height { get => 180; }
    //    public new string Hair { get => "金色"; }
    //    //表达式主体——override覆写父类同名showMessage
    //    public override void ShowMessage()
    //    => WriteLine($"第三代，{Hair}头发，身高 {Height} cm");
    //}
    internal class Son : Human
    {
        //使用new修饰词，写入新的属性值
        public new int Height { get => 182; }
        //public new string Hair { get => "黑色"; set { return value}; }

        private string _Hair = "白色";
        public string Hair
        {
            get => _Hair; set => _Hair = value;
        }
        /*public override void ShowMessage() => WriteLine(
          $"第三代，{Hair}头发，身高 {Height} cm");*/
        public override void ShowMessage()
        {
            base.ShowMessage();
            WriteLine($"第三代，{Hair}头发，身高 {Height} cm");
        }
        public Son()
        {
            Hair = "黄色";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0805
{
    internal class DiffNum
    {
        public static int num1 = 45;
        public static int num2 = 125;
    }
    class AddNumbers : DiffNum
    {
        new public static int num1 = 175;
        internal static int result1 = num1 + num2;
        internal static int result2 = DiffNum.num1 + DiffNum.num2;
    }
}

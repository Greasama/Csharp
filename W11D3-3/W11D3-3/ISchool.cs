using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0811
{
    internal interface ISchool
    {
        int ISubject { get; set; }
        void IShowMsg();
    }
    interface IGrade
    {
        int IStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    internal interface ICloneable
    {
        object Clone();
        int CompareTo(object obj);
    }

}

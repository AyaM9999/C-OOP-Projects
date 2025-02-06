using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal interface Icalculator <T> 
    {

        abstract T Addfun(T num1, T num2);

        abstract T subfun(T num1, T num2);

        abstract T Mulifun(T num1, T num2);

        abstract T dividefun(T num1, T num2);

    }
}

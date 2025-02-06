using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal interface ISeries:ICalculator
    {
         
          abstract  int GetNext();
           abstract int IAdd();



         
    }
}

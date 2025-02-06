using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class OddSeries : ISeries ,ICalculator
    {
         int current=1;

        public OddSeries(int current = 1) { this.current = current; }
        public void SetCurrent(int _current) {this.current = _current; }

        public int GetCurrent() { return current; }

        public int GetNext()
        {
            int z = current;
            current = current+ 2;
            return z;

        }

         int ICalculator.IAdd(int x, int y)
         {
            return x+y ;

         }

        int ISeries.IAdd()
        {
            return current;

        }


    }
}

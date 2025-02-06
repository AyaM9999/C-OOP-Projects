using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Tripleseries : ISeries
    {
        int current = 0;

        public Tripleseries(int current = 0) { this.current = current; }
        public void SetCurrent(int _current) { this.current = _current; }

        public int GetCurrent() { return current; }

        public int GetNext()
        {
            int z = current;
            current = current +3;
            return z;
        }

        int ICalculator.IAdd(int x, int y) // we eliminated access modifer puplic
        {
            return x + y+3;
        }

        int ISeries.IAdd()
        {
            return current + 3;
        }
    }
}

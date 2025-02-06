using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class DoubleCalculator
    {

        double num1;
        double num2;
        public DoubleCalculator(double num1=0, double num2=0)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double Addfun(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subfun(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Mulifun(double num1, double num2)
        {
            return num1 * num2;
        }

        public double dividefun(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

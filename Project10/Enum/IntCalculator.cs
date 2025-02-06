using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class IntCalculator:Icalculator<int>
    {

        int num1;
        int num2;

        public  IntCalculator(int num1=0, int num=0)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


         public int Addfun(int num1, int num2)
         {
             return num1 + num2;
         }

          public  int subfun(int num1, int num2)
          {
            return num1 - num2;
          }

        public  int  Mulifun(int num1, int num2)
        {
            return num1 * num2; 
        }

        public  int dividefun(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

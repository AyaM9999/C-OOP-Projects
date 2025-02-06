using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question9
{ 
     
    internal struct Time2

    {
        public int hours;
        public int minutes;
        public int seconds;

        static int counter = 0;

        public Time2() { }
        public Time2(int hours, int minutes, int seconds) 
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        static void swap(ref Time2 t1, ref Time2 t2)
        {
            // Increment the call count each time swap() is called
          

            // Swap the values of t1 and t2
            Time2 temp = t1;
            t1 = t2;
            t2 = temp;
        }

        public static void SwapTime(ref int t1, ref int t2)
        {
            int temp = t1;
            t1 = t2;
            t2 = temp;

            counter++;

        }
    }
}

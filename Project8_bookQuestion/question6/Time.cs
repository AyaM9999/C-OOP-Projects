using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace question6
{
    internal struct Time
    {
        public  int hours;
        public int minuts;
        public int seconds;

        public Time()
        {
            Normalize();
        }
        public Time(int h = 0, int min = 0, int sec = 0)
        {
            if (h >= 0 && min >= 0 && sec >= 0) 
            {
                hours = h;
                minuts = min;
                seconds = sec;
                Normalize();

            }
            

        }

        public void SetHours(int h)
        {
            hours = h;
        }
        public int GetHours()
        {
            return hours;
        }

        public void SetMin(int min)
        {
            minuts = min;
            Normalize();
        }

        public int GetMin()
        {
            return minuts;
        }

        public void SetSec(int sec)
        {
            seconds = sec;
            Normalize() ;   
        }

        public int GetSec()
        {
            return seconds;
        }

        public void  Normalize()
        {
            if (minuts >= 60)
            {
                hours += minuts % 60;
      
            }
            if (seconds >= 60)
            {
                minuts += seconds % 60;

            }
        }

        public Time(int sec=0)
        {
            if (sec >= 0)
            {
                hours = sec/3600;
                sec %= 3600;
                minuts = sec/60;
                seconds = sec%60;

            }

        }
        public  int Convert_to_sec ()
        {
          
            return (this.hours*3600) + (this.minuts*60) + (this.seconds);

        }

        public   int [] Convert_to_hms( )
        {
            this.hours += this.seconds / 3600;
            this.seconds %= 3600;
            this.minuts = this.seconds / 60;
            this.seconds  = this.seconds % 60;
            Normalize();
           
            int[] arr = new int[3];
            arr[0]=hours;
            arr[1]=minuts;
            arr[2]=seconds;

            return arr;
               
        }


        public override String ToString()
        {
            return $"hours:{this.GetHours},Min{this.GetMin},Sec{this.GetSec()}";
        }




    }
}

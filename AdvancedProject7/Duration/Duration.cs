using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    internal class Duration
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Duration(int _hours = 0, int _minutes = 11, int _seconds = 6)
        {
            this.hours = _hours;
            this.minutes = _minutes;
            this.seconds = _seconds;

        }

        public Duration(int total_seconds)
        {
            this.hours = (int)(total_seconds / 3600);
            total_seconds %= 3600;

            this.minutes = (int)(total_seconds / 60);
            total_seconds %= 60;

            this.seconds = total_seconds;
        }
        public void Arrangement()
        {
            if (this.minutes >= 60)
            {
                (this.hours) += this.minutes / 60;
                this.minutes = this.minutes % 60;
            }
            else
            {
                this.minutes = this.minutes;
            }


            if (this.seconds >= 60)
            {
                (this.minutes) += this.seconds / 60;
                this.seconds = this.seconds % 60;
            }
            else
            {
                this.seconds = this.seconds;
            }
        }
        

        public void SetHour(int h)
        {
            this.hours = h;
        }

        public int GetHour()
        {
            return this.hours;
            Arrangement();
        }

        public void SetMin(int min)
        {
            this.minutes = min;
            Arrangement();
        }

        public int GetMin()
        {
            return this.minutes;
        }

        public void SetSec(int sec)
        {
            this.seconds = sec;
            Arrangement();
        }

        public int GetSec()
        {
            return this.hours;
        }


        public override string ToString()
        {

            return $" Hours{this.hours}: Minutes{this.minutes}: seconds{this.seconds}sec";

        }

        public static Duration operator + (Duration d1, Duration d2)
        {
            return new Duration(d1.hours+d2.hours, d1.minutes+d2.minutes, d1.seconds+d2.seconds);
            
        }

        public static Duration operator + (Duration d1,int x)
        {

            int duration_totalsecond = (d1.hours*120) + (d1.seconds*60) + (d1.seconds); 
            return new Duration(duration_totalsecond+x);
        }

        public static Duration operator +(int x , Duration d2)
        {
         
            int duration_totalsecond = (d2.hours * 120) + (d2.seconds * 60) + (d2.seconds);
            return new Duration(x+duration_totalsecond );
        }

        public static Duration operator++ (Duration d)
        {
            
            return new Duration(d.hours,++d.minutes,d.seconds);
        }
        public static Duration operator-- (Duration d)
        {

            return new Duration(d.hours, --d.minutes, d.seconds);
        }

        public static bool operator> (Duration d1, Duration d2)
        {
            if (d1.hours > d2.hours)
            {
                return true;
            }
            else if (d1.hours >= d2.hours && d1.minutes > d2.minutes)
            {
                return true;
            }
            else if (d1.hours >= d2.hours && d1.minutes >= d2.minutes && d1.seconds > d2.seconds)
            {
                return true;
            }
            else 
            { 
                return false;
            }
            
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.hours < d2.hours)
            {
                return true;
            }
            else if (d1.hours <= d2.hours && d1.minutes < d2.minutes)
            {
                return true;
            }
            else if (d1.hours <= d2.hours && d1.minutes <= d2.minutes && d1.seconds < d2.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <= (Duration d1, Duration d2)
        {
            if (d1.hours <= d2.hours)
            {
                return true;
            }
            else if (d1.hours <= d2.hours && d1.minutes <= d2.minutes)
            {
                return true;
            }
            else if (d1.hours <= d2.hours && d1.minutes <= d2.minutes && d1.seconds <= d2.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.hours >= d2.hours)
            {
                return true;
            }
            else if (d1.hours >= d2.hours && d1.minutes >= d2.minutes)
            {
                return true;
            }
            else if (d1.hours >= d2.hours && d1.minutes >= d2.minutes && d1.seconds >= d2.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }














    }
}

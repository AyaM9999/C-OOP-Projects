using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Int
    {
        public int number;

        public Int(int a)
        {
            this.number = a;
        }

        public void SetNum(int num)
        {
            this.number = num;
        }

        public int GetNum()
        {
            return this.number;
        }

        public static Int operator +(Int a, Int B)
        {
            return new Int(a.number + B.number);
        }
        public static Int operator -(Int a, Int B)
        {
            return new Int(a.number - B.number);
        }
        public static Int operator *(Int a, Int B)
        {
            return new Int(a.number * B.number);
        }
        public static Int operator /(Int a, Int B)
        {
            if (a.number != 0)
            {
                return new Int(a.number / B.number);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static Int operator +(double a, Int b)
        {
            return new Int((int)a + b.number);
        }

        public static Int operator +( Int b, double a)
        {
            return new Int((int)a + b.number);
        }
        public static Int operator -(Int a,double b)
        {
            return new Int ((int)(a.number - b));
        }
        public static Int operator *(double a, Int b)
        {
            return new Int((int)(  a*b.number ));
        }
        public static Int operator /(Int a, double b)
        {
            if (a.number != 0)
            {
                return new Int((int)(a.number / b));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static Int operator ++(Int number)
        {
            number.number--;
            return number;
        }
        public static Int operator --(Int number)
        {
            number.number--;
            return number;
        }
        public override string ToString()
        {
            return $"Number {this.GetNum()}";   
        }

        public static explicit operator Int(int obj)
        {
            return new Int(obj);
        }
        public static implicit operator int(Int obj) 
        {
            return obj.number;

        }
    }

}

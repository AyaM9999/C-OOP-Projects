using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Fraction
    {
        int numerator;
        int denominator;


        public Fraction(int _numerator = 0, int _denominator = 1)
        {
            this.numerator = _numerator;

            if (_denominator != 0)
            {
                this.denominator = _denominator;
            }
            else
            {
                Console.WriteLine("Denominator cannot be zero!");
                this.denominator = 1;
            }

            simplify(this.numerator, this.denominator);
        }


        //setter and getter
        public void SetNumerator(int numeratorPart)
        {
            this.numerator = numeratorPart;
        }
        public int GetNumerator()
        {
            return this.numerator;
        }

        public void SetDenominator(int denominatorPart)
        {
            if (denominatorPart != 0)
            {
                this.denominator = denominatorPart;
            }
            else
            {
                Console.WriteLine("Denominator cannot be zero!");
                this.denominator = 1;
            }
        }
        public int GetDenominator()
        {
            return this.denominator;
        }


        //greatest common divisor (GCD)
        private int GCD(int x, int y)
        {

            while (x != 0 && y != 0) // 5/10
            {
                int temp = y; //temp=10 
                y = x % y; //y=5, 
                x = temp;//x=5
            }
            return x;
        }




        private int GCD2(int x, int y)
        {

            while (x != 0 && y != 0)
            {
                if (x > y)
                {
                    x %= y;
                }
                else
                {
                    y %= x;
                }
            }
            Console.WriteLine($"GCD2 {x | y}"); ;
            return x | y;  //bitwise or 

        }

        public void simplify(int _numerator, int _denominator)
        {
            // ensure that denominator is positive.
            if (_denominator < 0)
            {
                _numerator = (numerator) * (-1);
                _denominator = (_denominator) * (-1);
            }

            int gcdResult = GCD2(this.numerator, this.denominator);

            numerator /= gcdResult; // 5/5=> 1
            denominator /= gcdResult;// 10/5=> 2
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            Fraction fractionNum = obj as Fraction; //  as operator is more secure and efficient shcema than casting operator(Fraction)

            if (fractionNum.GetType() != typeof(Fraction))
            {
                return false;
            }

            if (fractionNum is null)
            {
                return false;
            }
            return (numerator == fractionNum.numerator && denominator == fractionNum.denominator);
        }




        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator;
            int denominator;
            if (f1.denominator == f2.denominator)
            {
                numerator = f1.numerator + f2.numerator;
                denominator = f1.denominator;
                return new Fraction(numerator, denominator);
            }
            else
            {
                denominator = f1.denominator * f2.denominator;
                numerator = (denominator / f1.denominator) * f1.numerator + (denominator / f2.denominator) * f2.numerator;
                return new Fraction(numerator, denominator);

            }
        }
        public static Fraction operator +(Fraction f1, int x)
        {
            int numerator;
            int denominator;

            denominator = f1.denominator;
            numerator = ((denominator / f1.denominator) * f1.numerator) + ((denominator / 1) * x);
            return new Fraction(numerator, denominator);

        }

        public static Fraction operator +(int x, Fraction f1)
        {
            int numerator;
            int denominator;

            denominator = f1.denominator;
            numerator = ((denominator / 1) * x) + ((denominator / f1.denominator) * f1.numerator);
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numerator;
            int denominator;
            if (f1.denominator == f2.denominator)
            {
                numerator = f1.numerator - f2.numerator;
                denominator = f1.denominator;
                return new Fraction(numerator, denominator);
            }
            else
            {
                denominator = f1.denominator * f2.denominator;
                numerator = ((denominator / f1.denominator) * f1.numerator) - ((denominator / f2.denominator) * f2.numerator);
                return new Fraction(numerator, denominator);

            }
        }
        public static Fraction operator -(Fraction f1, int x)
        {
            int numerator;
            int denominator;

            denominator = f1.denominator;
            numerator = ((denominator / f1.denominator) * f1.numerator) - ((denominator / 1) * x);
            return new Fraction(numerator, denominator);

        }

        public static Fraction operator -(int x, Fraction f1)
        {
            int numerator;
            int denominator;

            denominator = f1.denominator;
            numerator = ((denominator / 1) * x) - ((denominator / f1.denominator) * f1.numerator);
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numerator = f1.numerator * f2.numerator;
            int denominator = f1.denominator * f2.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction f1, int x) //3/5 *3=> 9/5
        {
            int numerator = f1.numerator * x;
            int denominator = f1.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(int x, Fraction f1) // 3 * 3/5 => 9/5
        {
            int numerator = f1.numerator * x;
            int denominator = f1.denominator * 1;
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int numerator = f1.numerator * f2.denominator;
            int denominator = f1.denominator * f2.numerator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction f1, int x) // (5/10 )/6 =>5/60
        {
            int numerator = f1.numerator * 1;
            int denominator = f1.denominator * x;
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator /(int x, Fraction f1)// 6/( 5/10) =>60/12=>5
        {
            int numerator = x * f1.denominator;
            int denominator = f1.numerator * 1;
            return new Fraction(numerator, denominator);
        }


        public static explicit operator int(Fraction fractionNum)
        {
            return (fractionNum.numerator / fractionNum.denominator);
        }
        public static implicit operator Fraction(int x)
        {
            return new Fraction(x);
            // constructor will handle this by setting denominator to 1 as default value
        }
        public override string ToString()
        {
            return ($"{this.numerator}/{this.denominator}");
        }

    }
}

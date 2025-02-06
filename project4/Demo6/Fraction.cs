using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    internal class Fraction
    {
        int numerator;
        int denominator;

        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            //(0/1) not vice verse
        }

        public Fraction(int _numerator) : this()
        {
            this.numerator = _numerator;
         


        }
        public Fraction(int _numerator, int _denominator) : this(_numerator)
        {
            

            if(_denominator != 0) 
            {
                this.denominator = _denominator;
            }
            else 
            {
                Console.WriteLine("Denominator cannot be zero!");
                this.denominator = denominator; 
            }

            simplify(this.numerator, this.denominator);
        }


        //setter and getter
        public void SetNumerator(int numeratorPart) { this.numerator = numeratorPart; }
        public int GetNumerator() { return this.numerator; }

        public void SetDenominator ( int denominatorPart) { this.denominator = denominatorPart; }
        public int GetDenominator() { return this.denominator; }


        //greatest common divisor (GCD)
        private int GCD(int x, int y)
        {

            while (x != 0 &&  y != 0) // 5/10
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

        public void simplify( int _numerator, int _denominator)
        {   
            // ensure that denominator is positive.
            if (_denominator < 0)
            {
                _numerator = (numerator) * (-1);
                _denominator = (_denominator) * (-1);
            }                                                                                                                                                                                                                                                

             int gcdResult=GCD2(this.numerator, this.denominator);

            numerator /= gcdResult; // 5/5=> 1
            denominator /= gcdResult;// 10/5=> 2
        }

        public void print()
        {
            Console.WriteLine($"Fraction = {this.numerator}/{this.denominator}");
        }

    }
    }
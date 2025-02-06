using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class ComplexNumber
    {

        public int realPart;
        public int imgPart;
        public ComplexNumber(int _realPart=0, int _imgPart=0)
        {
            this.realPart = _realPart;
            this.imgPart = _imgPart;
        }

        public void setRealNum(int _realPart)
        {
            this.realPart = _realPart;
        }
        public int GetReallNum()
        {
            return this.realPart;
        }

        public void setImgNum(int _imgPart)
        {
            this.imgPart = _imgPart;
        }
        public int GetImglNum()
        {
            return this.imgPart;
        }

        public override string ToString()
        {

            if (this.imgPart < 0)
            {
                return $"{this.realPart}-{this.imgPart}J";
            }

            else if (this.imgPart == 0)
            {
                return $"{this.realPart}";
            }
            else
            {
                return $"{this.realPart}+{this.imgPart}J";
            }
        }


           //  Addition Operators  Overloading 
        public static ComplexNumber operator+( ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber result= new ComplexNumber(c1.realPart+c2.realPart, c1.imgPart+c2.imgPart);
            return result;
        }

        //  Subtract Operators  Overloading 
        public static ComplexNumber operator-(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber result = new ComplexNumber(c1.realPart - c2.realPart, c1.imgPart - c2.imgPart);
            return result;
        }
        //  Multiply Operators  Overloading 
        public static ComplexNumber operator* (ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber result = new ComplexNumber(c1.realPart * c2.realPart, c1.imgPart * c2.imgPart);
            return result;
        }

        //  Divison Operator  Overloading 
        public static ComplexNumber operator/ (ComplexNumber c1, ComplexNumber c2)
        {

            
                ComplexNumber result = new ComplexNumber(c1.realPart / c2.realPart, c1.imgPart / c2.imgPart);
                return result;
   
        }

        // casting operator overloading
        public static explicit operator int(ComplexNumber c)
        {   // imaginary number will be lost (overflow)=> worse case
            // if imaginary number ==0 , so there is no lost data (best case)
            return c.realPart;

        }
        public static implicit operator ComplexNumber(int num)
        {   //imaginary number =0
            //there is no lost data
            return  new ComplexNumber (num);

        }

        public override bool Equals(object? obj)
        {   // check if object doesn't refer to object on heap or not (references).
            if (obj == null)
            {
                return false;
            }

            // cast obj object to complecx object
            ComplexNumber complex = (ComplexNumber)obj;

            // check if casting was done succeesful or not.
            if (complex.GetType() != typeof(ComplexNumber))
            {
                return false;
            }

            // check complex object is referance to complexNumber (contain data or not)
            if (complex is null) 
            {
                return false;
            }

            return (realPart==complex.realPart && imgPart==complex.imgPart);
        }




    }
}

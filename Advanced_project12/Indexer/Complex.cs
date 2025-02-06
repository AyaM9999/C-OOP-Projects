using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Complex
    {

        public int real { set; get; }
        public int img { set; get; }

        public Complex(int _real = 0, int _img = 0)
        {
            this.real = _real;
            this.img = _img;
        }


        //Build Indexer

        public int this[int index]
        {
            set
            {
                if (index == 0)
                {
                    real = value;
                }
                else if (index == 1)
                {
                    img = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            get
            {
                if (index == 0)
                {
                    return real;
                }
                else if (index == 1)
                {
                    return img;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int this[string index] {

            set
            {
                if (index == "real")
                {
                    real = value;
                }
                else if (index == "img")
                {
                    img = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            get
            {
                if (index == "real")
                {
                    return real;
                }
                else if (index == "img")
                {
                    return img;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public override string ToString()
        {
            if (this.real > 0)
            {
                return $"{this.real}+{this.img}J";
            }
            else if (this.img < 0)
            {
                return $"{this.real}-{this.img}J";
            }
            else
            {
                throw new Exception();
            }
        }

        public static explicit operator Complex(int num)
        {

            return new Complex(num, 0);
        }

        public static implicit operator int(Complex c)
        {
            int num = c.real;      // img part will be lost
            return num;
        }


        public static Complex operator+(Complex c1, Complex c2)
        {
            return new Complex(c1.real+c2.real, c1.img+c2.img); 
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.img - c2.img);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            double denominator = Math.Pow(c2.real, 2) + Math.Pow(c2.img, 2);
            int real = (int)(((c1.real * c2.real) + (c1.img * c2.img)) / denominator);
            int img = (int)((c1.real + c2.img) + (c1.img + c2.real) / denominator);

            return new Complex(real, img);

        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            int real = (c1.real * c2.real) - (c1.img * c2.img);
            int img = (c1.img * c2.real) + (c1.real * c2.img);
            return new Complex(real, img);


        }





}
        
}


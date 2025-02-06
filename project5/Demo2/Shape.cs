using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Shape
    {
        protected double dim1;
        protected double dim2;

        public Shape(double dim1=1, double dim2=1) //mandatory properities
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        public void SetDim1 (double dimOne)
        { 
          if(dimOne >= 0) 
            {
                this.dim1 = dimOne;
            }
            else
            {
                Console.WriteLine("dimension must be positive!");
            }
        }

        public double GetDim1() 
        { 
            return this.dim1; 
        }
        public void SetDim2(double dimTwo)
        {
            if (dimTwo >= 0)
            {
                this.dim2 = dimTwo; 
            }
            else 
            {
                Console.WriteLine("dimension must be positive!"); 
            }
        }

        public double GetDim2()
        {
            return this.dim2;
        }


        public virtual double cal()
        {
            return (this.dim1 * this.dim2);
        }

        public virtual void print()
        {
            Console.WriteLine($"Shape: dimension1= {this.dim1},dimension2={this.dim2}, Area={this.cal()}");
        }
    }
}

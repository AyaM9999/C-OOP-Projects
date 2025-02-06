using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaps
{
    internal class Rectangle:Shape
    {
        public static int rectangleCounter = 0;
        public Rectangle(double length=1, double width=1) : base(length, width)
        {
            this.dim1 = length;
            this.dim2 = width;
            rectangleCounter++;
           
        }
        public override void SetDim1(double length)
        {
            this.dim1=length;
        }
        public double GetLength() { return this.dim1; }
        public double GetWidth() { return this.dim2; }  
        public override void SetDim2(double width)
        {
            this.dim2 = width;
        }

        public override double cal()
        {
            return (this.dim1 * this.dim2);
        }

        public override void print()
        {
            Console.WriteLine($"Recatngle: Length= {this.dim1},width={this.dim2}, Area={this.cal()}");
        }
        


    }
}

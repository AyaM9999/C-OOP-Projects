using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaps
{
    internal class Square:Rectangle
    {

        public static int squareCounter = 0;
        public Square(double squareDim) :base(squareDim) 
        {
            this.dim1 = this.dim2 = squareDim;
            squareCounter++;
        }

        public  override void SetDim1(double squareDim)
        {
            this.dim1 = this.dim2=squareDim;
           
        }
        public double getDim1() {  return this.dim1; }

        public  override void SetDim2 (double squareDim)
        {
            this.dim1 = this.dim2 = squareDim;

        }
        public double getDim2() { return this.dim1; }
        public override double cal()
        {
            double squareAre = (this.dim1 * this.dim1);
            return squareAre;
        }

        public override void print()
        {
            Console.WriteLine($"Square: dimension= {this.dim1}, Area={this.cal()}");
        }
    }
}

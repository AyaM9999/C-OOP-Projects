using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Square:Shape
    {
        public Square(double squareDim) :base(squareDim)
        {
            this.dim1 = this.dim2 = squareDim;
        }

        public override double cal()
        {
            double squareAre= (this.dim1 * this.dim1);
            return squareAre;
        }

        public override void print()
        {
            Console.WriteLine($"Square: dimension= {this.dim1}, Area={this.cal()}");
        }
    }
}

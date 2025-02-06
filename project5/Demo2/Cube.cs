using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Cube:Shape
    {
        public Cube(double cubeDim) : base(cubeDim)
        {
            this.dim1 = this.dim2 = cubeDim;
        }

        public override double cal()
        {
          
            return (dim1*dim1*6);
        }

        public override void print()
        {
            Console.WriteLine($"Cube: Dimension= {this.dim1}, Area={this.cal()}");
        }
    }
}

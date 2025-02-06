using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Triangle:Shape
    {
        public Triangle(double triangleBase, double triangleHeight):base(triangleBase, triangleHeight)
        {
            this.dim1 = triangleBase;
            this.dim2 = triangleHeight;
        }

        public override double cal()
        {
            
            return  (0.5*dim1*dim2); // 0.5 *base *height
        }

        public override void print()
        {
            Console.WriteLine($"Triangle: Base= {this.dim1},Height={this.dim2}, Area={this.cal()}");
        }
    }
}

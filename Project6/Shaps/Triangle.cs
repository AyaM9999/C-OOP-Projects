using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaps
{
    internal class Triangle:Shape
    {
        public static int triangleCounter = 0;
        public Triangle(double triangleBase, double triangleHeight) : base(triangleBase, triangleHeight)
        {
            this.dim1 = triangleBase;
            this.dim2 = triangleHeight;
            triangleCounter++;
        }
        public void SetBase(double base_triangle)
        {
            this.dim1=base_triangle;
        }

        public double GetBase()
        {
            return this.dim1;
        }

        public void SetHeight(double height_triangle)
        {
            this.dim1 = height_triangle;
        }

        public double GetHeight()
        {
            return this.dim2;

        }
        public override double cal()
        {

            return (0.5 * dim1 * dim2); // 0.5 *base *height
        }

        public override void print()
        {
            Console.WriteLine($"Triangle: Base= {this.dim1},Height={this.dim2}, Area={this.cal()}");
        }
    }
}

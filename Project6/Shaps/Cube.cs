using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaps
{
    internal class Cube:Rectangle {
        public static int cubeCounter = 0;
        public Cube(double cubeDim) : base(cubeDim)
        {
            this.dim1 = this.dim2 = cubeDim;
            cubeCounter++;
        }

        public  override void SetDim1(double cubeDim)
        {
            this.dim1 = this.dim2 = cubeDim;

        }
        public double getDim1() { return this.dim1; }

        public  override void SetDim2(double cubeDim)
        {
            this.dim1 = this.dim2 = cubeDim;

        }
        public double getDim2() { return this.dim1; }

        public override double cal()
        {

            return (dim1 * dim1 * 6);
        }

        public override void print()
        {
            Console.WriteLine($"Cube: Dimension= {this.dim1}, Area={this.cal()}");
        }
    }
}

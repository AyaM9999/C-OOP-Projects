using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Recatngle:Shape
    {
        public Recatngle(double length, double width):base(length,width) 
        {
            this.dim1 = length;
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

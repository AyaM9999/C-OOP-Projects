using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Demo2
{
    internal class Cricle : Shape
    {
        double raduis;


        public Cricle(double r) : base(r)
        {
            this.raduis = r;

        }

        public void SetRaduis(double raduis)
        {
            if (raduis > 0)
            {
                this.raduis = raduis;
            }
            else
            {
                Console.WriteLine("Raduis must be positive");
            }

        }
        public double GetDouble()
        {
            return raduis;
        }

        public override double cal()
        {
            return (Math.PI * raduis * raduis);
        }

        public override void print()
        {
            Console.WriteLine($"Circle: Raduis ={this.raduis}, Area={this.cal()}");
        }
    }
}

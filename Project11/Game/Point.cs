using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Point
    {
        public int x_axis { set; get; }
        public int y_axis { set; get; }


       public Point( int x=1, int y=1)
        {
            this.x_axis = x;
            this.y_axis = y;
        }

        public override string ToString()
        {
            return $"({this.x_axis}, {this.y_axis})";
        }



    }
}

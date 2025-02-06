using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point : IComparable<Point>
    {

        int axis_x;
        int axis_y;
        public Point(int x = 0, int y = 0)
        {
            this.axis_x = x;
            this.axis_y = y;
        }

        public void setX(int x) { this.axis_x = x; }
        public int GetX() { return this.axis_x; }

        public void setY(int y) { this.axis_y = y; }
        public int GetY() { return this.axis_y; }


        public override String ToString()
        {
            return $"Point{this.axis_x},{this.axis_y}";

        }

        public int CompareTo(Point other)
        {
            if (other == null) { return 1; }

            if (axis_x < other.axis_x) { return -1; }
            if (axis_y > other.axis_y) { return 1; }
            else { return 0; }




        }
    }
}
    



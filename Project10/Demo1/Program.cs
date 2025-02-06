using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Demo1
{


    public class Point
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
        internal class Program
        {
            static void Main(string[] args)
            {



                Point p1 = new Point(3, 1);
                Point p2 = new Point(2, 5);

                Point[] arr_points = new Point[] { p1, p2 };

                Array.Sort(arr_points);


                foreach ( var  item in arr_points)
                {
                    Console.WriteLine(item);
                }










            }

            //public static void ReadPoints(ref Point[] points)
            //{
            //    bool flag = true;
            //    int i = 0;

            //    do
            //    {

            //        Console.Write("Enter 1st point:");
            //        int x = int.Parse(Console.ReadLine());

            //        Console.Write("Enter 2nd point:");
            //        int y = int.Parse(Console.ReadLine());

            //        points[i] = new Point(x, y);

            //        i++;

            //        Console.Write("Want to Contine y/n:");
            //        char continue_char = char.Parse(Console.ReadLine());
            //        if (continue_char == 'y') { flag = true; }
            //        else { flag = false; }


            //    } while (flag == true);



            //}

            //    public Point[] Read(  Point[] arr)
            //    {
            //        for (int i = 0;i<3; i++)
            //        {
            //            Console.Write("enter x");
            //            int x= int.Parse(Console.ReadLine());
            //            Console.Write("enter x");
            //            int y = int.Parse(Console.ReadLine());

            //            arr[i]= new Point(x, y);


            //        }
            //        return arr;
            ////    }
        }
    }
}

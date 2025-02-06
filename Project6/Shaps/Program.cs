using System.IO.Pipes;
using GeometricShaps;

namespace Shaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(30, 40);
            Square sq1 = new Square(20);
            Triangle tria1 = new Triangle(5,8);
            Cube cube1=new Cube(6);
            Circle c1 = new Circle(7);



            Rectangle[] arr = new Rectangle[2]; 

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("Enter length:");
                int length= int.Parse(Console.ReadLine());

                Console.Write("Enter width:");
                int width= int.Parse(Console.ReadLine());
                Rectangle rectangle= new Rectangle(length, width);
            }

            foreach (Rectangle rectangleShape in arr)
            {
                rectangleShape.print();
;            }

         //Generalization:
            Rectangle rec= new Rectangle(8,10);
            Square sq =  (Square)rec;//explicit casting
            rec1 = sq1; // implicit casting




        }
    }
}

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using Complex;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(10, 5);
            ComplexNumber c2 = new ComplexNumber(14, 7);
            ComplexNumber c3 = new ComplexNumber(10, 5);


            ComplexNumber c5 = new ComplexNumber(3, 3);
            ComplexNumber c6 = new ComplexNumber(5, 5);


            ComplexNumber c4 = c1 + c2;
            Console.WriteLine(c3);// call tostring function that represet object state as string.

            int x = 10;


            int y = (int)c5; //explicit casting (may happen overflow exception (lose data of complex number => imaginary part))
            ComplexNumber c7 = (ComplexNumber)x; // implicit casting

            Console.WriteLine(x.GetType()); // return int
            Console.WriteLine(c7.GetType());

            // compare objects references 
            
            if (c5 == c6)
            {
                Console.WriteLine("true, refer to the same object");
            }
            else
            {
                Console.WriteLine("false,  not refer to the same object");


                c5 = c6;

            if (c5 == c6)
            {
                    Console.WriteLine("true, refer to the same object");
            }
            else
            {
                    Console.WriteLine("false,  not refer to the same object");


            }
            }
        }
    }
}

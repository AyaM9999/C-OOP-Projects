using System.Reflection.Metadata.Ecma335;

namespace question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st arg");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd arg");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Result :  {GetLarger(x, y)};");
        }

        public static int GetLarger(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (y > x)
            {
                return y;
            }
            else
            {
                Console.WriteLine(" 2 numbers are equals ");
                return 0;
            }

        }
    }
}

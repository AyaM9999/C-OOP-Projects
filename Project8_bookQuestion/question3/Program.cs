namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st arg=");
             int num1 = int.Parse(Console.ReadLine());
             Console.Write("Enter the 2nd arg=");
             int num2= int.Parse(Console.ReadLine());

              ref int x= ref num1;
              ref int y= ref num2;
            Console.WriteLine($"x={x}, y={y}");
            Console.WriteLine($"x={num1}, y={num2}");
            ZeroSmaller(ref num1,ref num2);
            Console.WriteLine($"x={x}, y={y}");
            Console.WriteLine($"x={num1}, y={num2}");

        }

        public static void ZeroSmaller(ref int x, ref int y)
        {
            if (x > y)
            {
                y = 0;
            }
            else if (x < y)
            {
                x = 0;

            }
            else
            {
                Console.WriteLine("Two numbers are equal");
            }
        }
    }
}

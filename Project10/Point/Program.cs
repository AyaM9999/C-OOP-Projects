namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Point[] arr = new Point[] { new Point(10, 5), new Point(3, 2), new Point(5, 3), new Point(7,5) };

            Console.WriteLine("Points list Before sorting:");

            foreach (Point p in arr) 
            { 
                Console.WriteLine(p.ToString());
            }

            Array.Sort(arr);

            Console.WriteLine("Points list After sorting:");
            foreach (Point p in arr)
            {
                Console.WriteLine(p.ToString());
            }

        }
    }
}

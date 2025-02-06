namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter reduis of circle ");
            double reduis= double.Parse(Console.ReadLine());
            Console.Write($"Area of Circle={Circarea(reduis)};");
        }

        public static double Circarea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
       }
    }
}

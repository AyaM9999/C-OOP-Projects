namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = Complex.CreateObjects(3, 5);

            Complex c2 = Complex.CreateObjects(3, 8);

            Console.WriteLine(c1.ToString());

            Console.WriteLine(c2.ToString());



        }
    }
}

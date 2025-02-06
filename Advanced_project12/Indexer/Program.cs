namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1= new Complex();
            c1[1] = 8;
            c1[0] = 9;
            Console.WriteLine(c1.ToString());  

            Complex c2= new Complex();
            c2["real"] = 10;
            c2["img"] = -26;
            Console.WriteLine(c2.ToString());

        }
    }
}

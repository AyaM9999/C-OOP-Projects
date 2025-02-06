namespace Demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal total=0;
            for (int i = 1; i <= 5; i++)
            {

                total += i;

            }

            Console.WriteLine($"Total of 5 numbers  = {total}" );
        }
    }
}

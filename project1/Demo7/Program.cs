namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {



            decimal sum = 0;

            int i=0;

            while (sum<=100) {
                sum += i;
                i++;
            
            }
            Console.WriteLine($"Sum = {sum}");



        }
    }
}

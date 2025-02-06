namespace Demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Enter the number:");
            num=int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is EVEN ");


            }


            if (num % 2 != 0)
            {
                Console.WriteLine($"The number {num} is ODD ");


            }
        }
    }
}

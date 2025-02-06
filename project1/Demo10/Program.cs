namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.Write("Enter the number :");

            num=int.Parse(Console.ReadLine());

            int fractional=1;

            for (int i=1; i<=num ; i++) {

                fractional *= i;
        }

            Console.WriteLine(fractional);
    }}
}

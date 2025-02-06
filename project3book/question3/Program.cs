namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            long number = 0;

            Console.WriteLine();

            for (int i = 1; i<6;i++)
            {
                Console.Write("enter one digit :\t");
               // char ch = Console.ReadKey().KeyChar;

                 char ch= char.Parse(Console.ReadLine()) ;
                
                if (ch>='0' && ch<= '9')
                {
                    number = (number * 10) +(ch - '0');
                }
            }
            Console.WriteLine(number);

        }
    }
}

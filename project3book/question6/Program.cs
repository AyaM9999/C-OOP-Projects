namespace question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {

                Console.Write("Enter the number:\t");
                num = int.Parse(Console.ReadLine());

                if (num == 0) { break; }// exit from the loop if number equal to 0.

                int result_factorial= factorial(num);
                Console.WriteLine($"factorail of {num} = {result_factorial}");
                Console.WriteLine("***************************");

            } while (num >0);
             
        }   

        public static int factorial(int num)
        {

            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            //Console.WriteLine($"factorial={fact}");
            return fact;
        }
    }
}

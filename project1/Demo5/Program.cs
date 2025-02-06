namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            decimal num1, num2;
            char sign;
            Console.WriteLine(" calcualtor :");
            Console.Write(" Enter the num1 :");
            num1 = decimal.Parse(Console.ReadLine());
            Console.Write(" Enter the num2 :");
            num2 = decimal.Parse(Console.ReadLine());
            Console.Write(" Enter the sign of operation :");
            sign = char.Parse(Console.ReadLine());






            switch (sign)
            {

                case '+':
                           Console.WriteLine( " sum num1 + num2 ="+ (num1+num2));
                          break;
                case '-':
                    Console.WriteLine(" sum num1 - num2 = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(" sum num1 * num2 ="+ (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine(" sum num1 / num2 ="+ (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine(" sum num1 % num2 ="+ (num1 % num2));
                    break;
            }

        }
    }
}

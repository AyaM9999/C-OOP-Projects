namespace question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            calculator();
        }

        public static void calculator()
        {
            bool flag = true;


            do { 
            Console.WriteLine("calculator:");
            Console.WriteLine("1- Add 2 numbers :");
            Console.WriteLine("2- Subtract 2 numbers:");
            Console.WriteLine("3- multiply 2 numbers:");
            Console.WriteLine("4- divide 2 numbers:");
            Console.WriteLine("5- exit from the calculator :");

            Console.WriteLine("Enter the number one \t:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number two \t:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator  \t:");
            char op = char.Parse(Console.ReadLine());

            
            
                switch (op)
                {

                    case '+':
                        Console.WriteLine($"result of num1 +num2 = {num1+num2}");
                        break;
                    case '-':
                        Console.WriteLine($"result of num1 -num2 ={ Math.Abs(num1 - num2)}");
                        break;
                    case '*':
                        Console.WriteLine($" result of num1 * num2 ={num1 * num2}");
                        break;
                    case '/':
                        Console.WriteLine($"result of num1 / num2 = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("invalid operator !");
                        break;
                }

                Console.WriteLine("do another operation? y or n ");
                char operation_want = char.Parse(Console.ReadLine());
                flag = (operation_want == 'y') ? true : false;

            } while (flag);
    







                
           

           
        }
    }
}

using System.Net.Http.Headers;

namespace question12
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

            double result = 0;
            do {

               
                Console.WriteLine(" Fractions Calculator :");
                Console.WriteLine("1. Adddition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Mutiplication");
                Console.WriteLine("4. Devision");

                Console.WriteLine("Choose one option, the 1st fraction, operator, 2nd fraction");
                Console.Write($"Enter the option\t");
                int option= int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the first fraction:\t");
                Console.Write("enter a :\t");
                int a =int.Parse(Console.ReadLine());
                Console.Write("enter b:\t");
                int b = int.Parse(Console.ReadLine());


                Console.WriteLine($"Enter the operator:\t");
                char operattor = Console.ReadKey().KeyChar;

                Console.WriteLine($"Enter the second fraction:\t");
                Console.Write("enter c :\t");
                int c = int.Parse(Console.ReadLine());
                Console.Write("enter d :\t");
                int d = int.Parse(Console.ReadLine());


                switch (option)
                {


                    case 1:
                        result = (a * d + b * c) / (b * d);
                        
                        break;

                    case 2:
                        result = (a * d - b * c) / (b * d);

                        break;

                    case 3:
                        result = (a * c) / (b * d);

                        break;

                    case 4:
                        result = (a * d) / (b * c);

                        break;
                    default:
                        Console.WriteLine("please enter valid inputs");
                        
                        break;

                }
                Console.WriteLine(result);
                Console.WriteLine("do you continue? y/n");
                char responce =char.Parse(Console.ReadLine().ToLower());
                if (responce == 'y'|| responce == 'Y' ) { flag = true; }
                else if (responce=='n' || responce == 'N') { flag = false; }
                else { Console.WriteLine("unvalid option"); }
       
                
            } while (flag);
        }


    }
}

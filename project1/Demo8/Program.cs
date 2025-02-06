namespace Demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            do
            {
                Console.Clear();
                Console.WriteLine("choose from the menu:");
                Console.WriteLine("New ");
                Console.WriteLine("Display ");
                Console.WriteLine("Exit ");


                
                Console.WriteLine("Enter the character :");
                x = char.Parse(Console.ReadLine());




                switch (x)
                {
                    case 'N':
                    case 'n':
                        Console.WriteLine("New option selected");
                        Console.ReadKey();
                        break;

                    case 'D':
                    case 'd':
                        Console.WriteLine("Display option selected");
                        Console.ReadKey();  
                        break;

                    case 'E':
                    case 'e':
                        Console.WriteLine("Exit option selected");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("un valid option");
                        Console.ReadKey();
                        break;
                }
            } while(x!='N' && x != 'n'&& x != 'E'&& x != 'e' && x != 'd' && x!='D');




            







        }
    }
}

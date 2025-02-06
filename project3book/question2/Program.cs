namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temp ;
            int option;
            bool flag = true;
          do {
                Console.WriteLine("choose one option:");
                Console.WriteLine("1.convert temp from fahrenheit to celsius ");
                Console.WriteLine("2.convert temp from fahrenheit to celsius ");


                Console.Write("Enter your option:");
                option = int.Parse(Console.ReadLine());

                Console.Write("Enter the Temperature:\t");
                temp = decimal.Parse(Console.ReadLine());
                Temp_convertor(temp, option);

                Console.WriteLine("*******************************************");



             

 

                
              
                 
                
            }
            while (flag);
        }

        public static void Temp_convertor(decimal temp_degree, int option)
        {
            decimal c = 0;
            decimal f = 0;
            switch (option)
            {

                case 1:// convert temp from fahrenheit   to celsius
                    c = (temp_degree - 32)*(5/9);
                    Console.WriteLine($" celsius tem = {c}");
                    break;

                case 2:// convert temp from celsius to fahrenheit
                    f = (temp_degree * (9 / 5)) + 32;
                    Console.WriteLine($" fahrenheit tem = {f}");
                    break;
                default:
                    Console.WriteLine("invalid options !");
                    break;
            }
        }
    }
}

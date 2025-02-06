namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TollBooth tollBooth = new TollBooth(23);

            // Instructions for the user
            Console.WriteLine("Press 'P' to count a paying car.");
            Console.WriteLine("Press 'N' to count a non-paying car.");
            Console.WriteLine("Press 'Esc' to exit and display totals.");

           

            while (true) 
            {
                Console.WriteLine("enter the key:");
                var key = char.Parse(Console.ReadLine());

                if (key == 'p')
                {
                    tollBooth.PayingCar();
                }
                else if (key=='n')
                {
                    tollBooth.NOPayingCar();
                }
                else if (key == 'e') 
                {
                    Console.WriteLine(tollBooth.ToString()); 
                }
              
            }
        }
    }
}

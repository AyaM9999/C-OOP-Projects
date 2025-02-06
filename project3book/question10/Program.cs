using System.ComponentModel.DataAnnotations.Schema;

namespace question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double investmnet = 5124.43;
             double rate = 5.5;
             double principle = 3000;

            double counter = 0;
            int y = 0; ;
            while (investmnet>= principle)
            {
                counter = investmnet * (rate/100);
                investmnet = investmnet - counter;
                y += 1;
                
            }
            Console.WriteLine($"investment was for {y}");


        }// 30008 * 5.5%





       


    }
}

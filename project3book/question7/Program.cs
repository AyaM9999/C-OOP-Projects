namespace question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial money :\t");
            double moneyBasics = double.Parse(Console.ReadLine());

            Console.Write("Enter years number :\t");
            double yearsNum = double.Parse(Console.ReadLine());
            Console.Write("Enter interest rate yearly :\t");
            double interestrate = double.Parse(Console.ReadLine());

            double total=(int)interestCalc_equation(moneyBasics, yearsNum, interestrate);
            Console.WriteLine($"Total budget for {yearsNum} years with  interest{interestrate}% yearly of {moneyBasics} as the investment basic = {total} ");

            double total2 = (int)interestCalc_Loop(moneyBasics, yearsNum, interestrate);
            Console.WriteLine($"Total budget for {yearsNum} years with  interest{interestrate}% yearly of {moneyBasics} as the investment basic = {total2} ");
        }




        public static double interestCalc_equation(double initial_amount, double years, double interest_rate_yearly)
        { 



           
             double d= Math.Pow( (1 + (interest_rate_yearly/100)), years);// basic * (1+5.5%)^10 => 1 represemt basics of money
            double total = initial_amount*(Math.Pow((1 + (interest_rate_yearly / 100)), years));
            
            return total;
        }


        public static double interestCalc_Loop(double initial_amount, double years, double interest_rate_yearly)
        { // t=3000+(3000*(5.5/100)) => t+=3165+(3000*(5.5/100)) and so on 

            double total_budget = initial_amount;

            for (int i=1; i<=years;i ++)
            {

                total_budget +=   (total_budget * (0.055));
            }
          return total_budget;
        }
    }
}
     


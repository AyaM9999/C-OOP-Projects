namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number as double");
            double baseNum= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power number as intger");
            int powerNum = int.Parse(Console.ReadLine());

            double result=1;

            result=Powerlization(baseNum, powerNum);
            Console.WriteLine($"result = {result}");

            result = Powerlization(baseNum);
            Console.WriteLine($"result = {result}");
        }
         public static double Powerlization(double baseNum, int powerNum=2)
        {
            double result = 1;

            for (int i = 0; i < powerNum; i++) 
            {
                
                result *= baseNum;

            }
            return result;
        }
    }
}

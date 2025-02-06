namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal grade;
            Console.Write(" Enter the grade :");
            grade= decimal.Parse(Console.ReadLine());
            if (grade <100 && grade >=90)
            {
                Console.WriteLine("Excellent ");
            }
             else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("very Good  ");
            }
            else if (grade < 80 && grade >= 70)
            {
                Console.WriteLine("Good  ");

            }
            else if (grade < 70 && grade >= 50)
            {
                Console.WriteLine("successful ");
            }
            else
            {
                Console.WriteLine(" fail!");
            }

        }
    }
}

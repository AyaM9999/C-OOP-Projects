 namespace question8
{
    internal class Program
    {
        static int countCalls = 0;

        static void Main(string[] args)
        {
            int num1 = 40;
            int num2 = 50;

            Console.WriteLine($" Before Swapping: x= {num1} AND y= {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After Swapping : x= {num1} AND y= {num2}");
            Console.WriteLine($"number of swapping times:{counter()}");
        }


        
        public static  void Swap(ref int x,ref  int y)
        {
            int temp = x;
            x = y;
            y = temp;
            counter();

        }

        public  static int counter()
        {
            return countCalls += 1;
        }

       
            

    }
}
 
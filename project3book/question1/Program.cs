namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter raws number:");
            int raws_num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns number:");
            int cols_num = int.Parse(Console.ReadLine());
            int[,] numbers = new int[raws_num,cols_num];

            ReadNumbers(numbers);
            PrintNumbers(numbers);  
        }

        public static void ReadNumbers(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++) {
              for(int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    Console.Write($"enter the item{i}:{j} \t");
                    arr[i,j] = int.Parse(Console.ReadLine()) ;
                    Console.WriteLine("" );
                }
            }
           
        }

        public static void PrintNumbers(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t ");
                   
                }
                Console.WriteLine();
            }

        }

    }
}

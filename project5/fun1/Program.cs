using System.Diagnostics.CodeAnalysis;

namespace fun1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];


            FirstMethod(arr1);
            SecondMethod(arr1);
            Max_finder(arr1);
            Minfinder(arr1);
            Valuefinder(arr1);


        }// end main method


        //Read data from user
        public static void FirstMethod(int[] arr1)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Enter item {i + 1}:");

                arr1[i] = int.Parse(Console.ReadLine());
            }

        }


        // calculate sum and avg of array elements
        public static int SecondMethod(int[] arr1)
        {
            int sum = 0;
            int avg = 1;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }

            avg = sum / arr1.Length;
            Console.WriteLine($" sum of array elements = {sum}");
            return avg;
        }

        // find maximum number in  the array 
        public static int Max_finder(int[] arr1)
        {

            int max = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (max < arr1[i])
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine($" max of array elements = {max}");
            return max;
        }//end of 3rd fun()


        // find minmum number in  the array
        public static int Minfinder(int[] arr1)
        {

            int min = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (min > arr1[i])
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine($" max of array elements = {min}");
            return min;
        }


        // search for specific item in the array.
        public static int Valuefinder(int[] arr1)
        {
            int index = 0;
            Console.Write("Enter target value :\t");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr1.Length; i++)
            {
                if (target == arr1[i])
                {
                    index = i;
                    Console.WriteLine($"index of {target} is {index}");
                    break;
                }
                else
                {
                    Console.WriteLine($"  Target value {target} isn't found!");
                }

            }

            return index;
        }//end of 4th fun()



    }
}

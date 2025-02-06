using System.Transactions;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter number of raws in the array:");
            int num_raws = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns in the array:");
            int num_cols = int.Parse(Console.ReadLine());
            int[,] studentGrades = new int[num_raws, num_cols];
        
            //calling methods
            ReadData(studentGrades);
            SumDegrees(studentGrades);
            PrintData(studentGrades) ;
            AvgColumn(studentGrades);
            MaxstudentDegree(studentGrades);
           

        }// end of main method





        //Building functions();
        public static void ReadData(int[,] studentGrades)
        {

            // 1-Read data
            for (int i = 0; i < studentGrades.GetLength(0); i++)
            {

                for (int j = 0; j < studentGrades.GetLength(1); j++)
                {
                    Console.Write($"Enter the grade{i},{j} :");

                    studentGrades[i, j] = int.Parse(Console.ReadLine());


                }
                Console.WriteLine();
            }// outer loop end
        }//end of 1st fun()


        public static void PrintData(int[,] studentGrades)
        {
            //2- print data
            for (int i = 0; i < studentGrades.GetLength(0); i++)
            {

                for (int j = 0; j < studentGrades.GetLength(1); j++)
                {
                    Console.Write($"Grade {i}:{j} ={studentGrades[i, j]} \t");


                }
                Console.WriteLine();
            }// outer loop end.

        }//end of 2nd fun()


        public static void SumDegrees(int[,] studentGrades)
        {

            // 3-total of degrees for every subject(raw)
            int sum_degrees = 0;
            for (int i = 0; i<studentGrades.GetLength(0); i++)
            {

                for (int j = 0; j<studentGrades.GetLength(1); j++)
                {


                    sum_degrees += studentGrades[i, j];
                }
                 Console.WriteLine($"total grade of raw {i} = {sum_degrees}");
                 sum_degrees = 0;
             

            }// outer loop end
       }//end of 3rd fun()

        // avg of each column(subject)
       public static void AvgColumn(int[,] studentGrades) {


            // avg column.
            int sum_colum = 0;
            int avg_colum = 1;

            for (int i = 0; i < studentGrades.GetLength(1); i++)
            {
                for (int j = 0; j < studentGrades.GetLength(0); j++)
                {

                    sum_colum += studentGrades[j, i];

                }

                avg_colum = sum_colum / studentGrades.GetLength(1);
                Console.WriteLine($"Avg of column{i} ={avg_colum} ");
                sum_colum = 0;

            }


        }//end of fth fun();

        public static void MaxstudentDegree(int[,] studentGrades)
        {
            // max degree of every student 
            int max_raw = 0;

            for (int i = 0; i < studentGrades.GetLength(0); i++)
            {

                for (int j = 0; j < studentGrades.GetLength(1); j++)
                {
                    if (max_raw < studentGrades[i, j])
                    {
                        max_raw = studentGrades[i, j];
                    }
                }
                Console.WriteLine($"Max grade of  subject{i} = {max_raw}");

            }// outerloop end 
        }// end of 5th fun()


    }
}

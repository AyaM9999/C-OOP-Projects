using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System;
namespace Demo14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // count ones from one to million by 3 various functions.
            // calling Methods

            Count_ones1();
            count_ones2();
            ones_count3();// best fun() according to time.

        }





        static void Count_ones1()
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            var count1 = 0;
            for (var i = 1; i <= 100; i++)
            {
                var num = i;
                while (num > 0)
                {
                    // calculate modulus 
                    if ((num % 10) == 1) // 2%10 =2 , 11%10=1, 1%10=1
                    {
                        count1++; // doesnot execute, execute
                    }
                    num = num / 10; // 2/10=1.5,  11/10=1
                }
            }
            sw.Stop();
            Console.WriteLine($" number of ones from one to million {count1}");
            Console.WriteLine($"Time that is spent in execution = {sw.Elapsed}");
        }// end of method one




        static void count_ones2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int count2 = 0;
            for (int i = 1; i <= 100; i++)
            {

                count2 += (i.ToString().Length) - (i.ToString().Replace("1", "").Length);

            }
            sw.Stop();
            Console.WriteLine($" number of ones from one to million {count2}");
            Console.WriteLine(sw.Elapsed);
        }//end of method 2




        static void ones_count3()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int count3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                string number = i.ToString();

                foreach (char c in number)
                {
                    if (c == '1')
                    {
                        count3++;
                    }
                }

            }
            sw.Stop();
            Console.WriteLine($" number of ones from one to million {count3}");
            Console.WriteLine($"time that is spent in execution = {sw.Elapsed}");

        }
        // end of method 3


    }
}

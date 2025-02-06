using System.Security.Cryptography.X509Certificates;

namespace Demo1
{
    internal class Program
    {

        public static void Print() => Console.WriteLine("Method body expression");


       




        public static void Main(string[] args)
        {

            //Anonymous delegate

            Func<int, float, float> del1 = delegate (int x, float y)
            {
                Console.WriteLine("Multilply method");
                return x * y;
            };

            Action<int, int> del2 = delegate (int x, int y)
            {
                Console.WriteLine($"{x}+{y}");
            };

            Action del3 = delegate ()
            {
                Console.WriteLine("Action delegate");
            };

            del1.Invoke(5, 5f);//18
            del2.Invoke(5, 4);//9 as printedstring 

            del3.Invoke();//Acrion delegates with no params






            //Lamda Expression

            Func<int, int, int> d1 = (x, y) =>
            {
                Console.WriteLine("Addition Method 1");
                return x + y;
            };

             d1+= (x, y) =>
            {
                Console.WriteLine("Addition Method 1");
                return x - y;
            };

            Func<int, float, float> d2 = (x, y) =>
            {
                Console.WriteLine("Addition Method 2");
                return x * y*3;
            };

            Predicate <int> d3 = (x) => (x>=10);

            Func<int, bool> d4 = (x) => (x >= 10);



            d1.Invoke(3, 6); //18=> -3
            d2.Invoke(2, 4);//24
            d3.Invoke(5);//false
            d4.Invoke(50);//true


            List<int> list = new List<int>() { 12,5,9,13,12,84,200,100};

             List <int> even_list =list.FindAll(x => x % 2 == 0);

             List<int> odd_list = list.FindAll(x => x % 2 == 1);

             foreach (int item in  even_list)
             {
                Console.WriteLine(item);
             }

            foreach (int item in odd_list)
            {
                Console.WriteLine(item);
            }



        }



        }
    }


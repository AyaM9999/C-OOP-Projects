namespace Exception
{

    internal class Program
    {


        public static void MyFun()
        {

            int x, y, z;
            Console.WriteLine("Enter the 1st number");

            while ((int.TryParse(Console.ReadLine(), out  x)) == false)
            {
                Console.WriteLine("please enter valid digit !");
            }

            Console.WriteLine("Enter the 2nd number");

            while ((int.TryParse(Console.ReadLine(), out  y)) == false)
            {
                Console.WriteLine("please enter valid digit !");
            }

            if (y != 0)
            {
                 z = x / y;
                Console.WriteLine($"The result ={z}");
            }

        }

        public static void MyFun2()
        {
            try
            {
                MyFun();
            }  
            catch(DivideByZeroException dx)
            {
                Console.WriteLine(dx.Message);
                throw new System.Exception(dx.Message);
            }
            catch(FormatException fx)
            {
                Console.WriteLine(fx.Message);
            }
            finally
            {
                Console.WriteLine("final block");
            }
    
        }


       
        public static void Main(string[] args)
        {


            int x;
            int y;
            int z;







        }
    }
}

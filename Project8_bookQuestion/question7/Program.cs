namespace question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 4d;
            int y = 3;
            char ch = 'a';

            Console.WriteLine(Power(x,  y ));
            Console.WriteLine(Power((int)x, y));
            Console.WriteLine(Power((float)x, y));
            Console.WriteLine(Power((long)x, y));
            Console.WriteLine(Power(ch, y));
            Console.WriteLine(Power((char)x, y));

        }

        public static double Power(double baseNum,int poweredNum) 
        {
            double res = 1;

            for (int i=0; i < poweredNum; i++)
            {
                res *= baseNum;
            }
            return res;
        }
        public static int Power(int baseNum, int poweredNum) 
        {
            int res = 1;

            for (int i = 0; i < poweredNum; i++)
            {
                res *= baseNum;
            }
            return res;
        }
        public  void Power(char ch, int poweredNum)
        {
            

            for (int i = 0; i < poweredNum; i++)
            {
               Console.Write($"{ch}\t");
            }


        }
        public static long  Power(long baseNum, int poweredNum) 
        {
            long res = 1;

            for (int i = 0; i < poweredNum; i++)
            {
                res *= baseNum;
            }
            return res;
        }

        public static float Power(float baseNum, int poweredNum) 
        {
            float res = 1f;

            for (int i = 0; i < poweredNum; i++)
            {
                res *= baseNum;
            }
            return res;

        }
    }
}

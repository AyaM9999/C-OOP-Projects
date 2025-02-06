namespace question9
{
    internal class Program
    {
        static int counter=0;
        static void Main(string[] args)
        {
            Time2 t21=new Time2(2,40,23);
            Time2 t22 = new Time2(3,41,60);

            Time2 t3;

            int y = 10;
            int x = 16;
            SwapTime(ref y, ref x);
           
        }
        public static void SwapTime(ref int t1, ref int t2)
        {
            int temp = t1;
            t1 = t2;
            t2 = temp;

            counter++;

        }
    }
}

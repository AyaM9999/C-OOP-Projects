namespace swapper
{
    internal class Program
    {
        static void Main(string[] args) 
        
        {
             int x = 10;
             int y = 20;
             Swap(ref x, ref y);
        }

        public static void Swap<T>(ref T x, ref T y) 

        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}

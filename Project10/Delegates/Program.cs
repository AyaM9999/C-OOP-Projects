namespace Delegates
{
    internal class Program
    {

        public delegate T deloperation<T> (T x,T y);  //Generic delegate

        public delegate void del_operation2();

        static void Main(string[] args)
        {
            // Generic Mulicasting delegates

            deloperation<int> d1= Add;
            d1 += Sub;
            d1.Invoke(3,5); // 8=> 2


            //Void Mulicasting delegates

            del_operation2 d2 = new del_operation2(Print1);
            d2 += Print2;
            d2 += Print3;

            d2.Invoke();


        }

        public  static int Add(int x, int y) {  return x + y; }
        public static int Sub(int x, int y) { return  Math.Abs(x - y); }



        public static void Print1()
        {
            Console.WriteLine("Function Print1");
        }
        public static void Print2()
        {
            Console.WriteLine("Function Print1");
        }
        public static void Print3()
        {
            Console.WriteLine("Function Print1");
        }

    
    }
}

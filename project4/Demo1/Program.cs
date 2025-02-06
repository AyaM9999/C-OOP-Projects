namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            // overloading 
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Add(3.0f, 5.0f));
            Console.WriteLine(Add(3.0f, 5));
            Console.WriteLine(Add(3, 0.5f));
            Console.WriteLine(Add( a,  b));
            Console.WriteLine(Add(ref a, ref b));


        }

        public  static int Add(int a, int b)
        {
            return a + b;
        }
        public static float Add(float a, float b) {  return a + b; }

        public static float Add(float a, int b) {  return a + b; }

        public static float Add(int a, float b) { return a+b; }

        public static int Add(ref int a, ref int b) { return a + b; }

       
        public static void Add(params int[] arr) { }
        public static void Add (float a, params int[] arr) { }
        public static void Add(int a, params float[] arr) { }
    }
}

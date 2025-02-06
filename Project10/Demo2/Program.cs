namespace Demo2
{
    internal class Program
    {
        // interface open for extension closed for modification(SOLID Principles)
        public static void MyFun(ISeries o) 
        { 
            Console.WriteLine(o.GetNext());
        }
        static void Main(string[] args)
        {
            OddSeries series = new OddSeries();
            MyFun(series);
            MyFun(series);
            MyFun(series);

            Console.WriteLine("______________________________________________________");

          EvenSeries series2 = new EvenSeries();
            MyFun(series2);
            MyFun(series2);
            MyFun(series2);

            Console.WriteLine("______________________________________________________");

            Tripleseries series3 = new Tripleseries();
            MyFun(series3);
            MyFun(series3);
            MyFun(series3);
        }
    }
}

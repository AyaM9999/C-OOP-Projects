namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d= new Duration(1,10,15);
            d.ToString();

            Duration d1 = new Duration(3600);
            d1.ToString();

            Duration d2 = new Duration(7800);
            d2.ToString();

            Duration d3 = new Duration();
            d3.ToString();

            d3 = d1 + d2;
            d3 = d1 + 7800;
            d3 = 666 + d3;
            d3 = d1++;
            d= --d2;

            Console.WriteLine(d1>d2);
            Console.WriteLine(d1<= d2);





        }
    }
}

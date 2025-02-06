namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(10, 5);
            Fraction f2 = new Fraction(3, 5);

            Fraction f3 = f1 + f2;
            Console.WriteLine(f3); //call Tostring impicity


            if (f3 == f2)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("false");
            }

            Fraction f11 = new Fraction(3, 2);
            Fraction f12 = new Fraction(3, 2);
            Console.WriteLine(f11.Equals(f12));

            //casting

            Fraction f13 = new Fraction(1,2);
            Fraction f14 = new Fraction(2,4);
            int x = 10;
            int y = 15;

            x = (int)f13; //1
            // check if casting was done successfult or not 
            Console.WriteLine(f13.GetType() == typeof(int) );


            f14 =(Fraction)y; // 15/1
            Console.WriteLine(y.GetType() == typeof(Fraction) );
           




        }
    }
}

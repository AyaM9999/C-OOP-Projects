 namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new("Honda",230,2024);
            Car car2 = new("Honda", 210, 2023);

            car1.Accelerate(120);
            car1.Deaccelerate(20);
            car2.Accelerate(130);
            car2.Deaccelerate(30);


        }
    }
}

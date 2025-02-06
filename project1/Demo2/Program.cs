namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter The number :");
            num = int.Parse(Console.ReadLine());

            char ch = (char)num ;

            Console.WriteLine($"character ={ch} ");
        }
    }
}

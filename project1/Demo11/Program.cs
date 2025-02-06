namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char ch;
            Console.Write("Enter the character :");
            ch=char.Parse(Console.ReadLine());
             int r=ch+32;
            Console.WriteLine($" {r}");

        }
    }
}

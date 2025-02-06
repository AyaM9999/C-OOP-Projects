using System;
namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Enter Charachter :");

            ch= char.Parse(Console.ReadLine());

            int num = ch;

            Console.WriteLine(num);


        }
    }
}

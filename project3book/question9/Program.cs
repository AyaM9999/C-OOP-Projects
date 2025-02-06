namespace question9
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter number of available chairs:\t");
            int chairs= int.Parse(Console.ReadLine());

            Console.Write("Enter number of guests:\t");
            int guests = int.Parse(Console.ReadLine());

            int choicesNum_forChairs = 0;
            int choicesNum_forGuests = 0;

            for (int i=0; i < chairs; i++)
            {
                choicesNum_forChairs += (guests-i );

                choicesNum_forGuests += (chairs-i);
            }
            Console.WriteLine($"total of possible arrangements= {choicesNum_forChairs}");

        }
    }
}
// g, c
// c1=> (g) , all guests may sit on the 1st chair
//c2=> (g-1) 
//c3=>(g-2)
//c4=>(g-3)
//g5,g6 have to wait
//(g)(g-1)(g-2)...(g-c+1)

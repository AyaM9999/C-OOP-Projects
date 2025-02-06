namespace question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int raws_num = 20;
            for (int i = 1; i <= raws_num; i++) //outer loop 20 raw
  
            {
                for (int j=0; j <( raws_num-i); j++)// inner loop for white space
                {
                    Console.Write(' ');
                }
                
                for (int z = 0; z <= (2*i)-1; z++) // (2*i)-1=> 1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39
                {
                    Console.Write('x');    
                }
                Console.WriteLine();
            }
        }
    }
}

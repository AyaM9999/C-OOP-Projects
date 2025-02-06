namespace question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Time = \n");
            String str = Console.ReadLine();


            Console.WriteLine(htm_to_secs(str)); 



        }

        public static int htm_to_secs(String str)
        {
            String[] time = str.Split(':');

            int h = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            int sec = int.Parse(time[2]);

            int totalseconds = (h * 3600) + (min * 60) + sec;
          return (h * 3600) + (min * 60) + sec; 
        }
    }
}

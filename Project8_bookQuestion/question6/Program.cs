using System.Net.Http.Headers;

namespace question6
{
    internal class Program
    {
        static void Main(string[] args) 
        {  
        
            Time t1= new Time(10,35,60);
            Time t2 = new Time(7500);


            Time t3= new Time();
            t1.Convert_to_sec();
            t2.Convert_to_hms();


        }
    }
}

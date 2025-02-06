namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;

            int reverse = 0;
            int reminder = 0;

            while(num > 0) //
            {
                reminder = num % 10;     // 1234%10=4 , 123%10=3, 12%10=2, 1%10=0
                reverse = (reverse * 10) + reminder;  //rev=4, rev=40+3=43, rev=430+2=432, rev=4320+1=4321
                num= num / 10;    //num=1234/10=123 , num=123/10=12 , num=12/10=1 , num=1/10=0.2;(stop point)
            }
            Console.WriteLine($"The reversed number is {reverse}");
        }
    }
}

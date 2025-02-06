using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace question11
{
    public class Program
    {

        struct Sterling
        {
            public int pounds;
            public int shilling;
            public int pence;

            public Sterling(int pounds = 0, int shilling = 0, int pence = 0)
            {
                this.pounds = pounds;
                this.shilling = shilling;
                this.pence = pence;
                Normalize();
            }
            public void SetPound(int p) { this.pounds = p; Normalize(); }
            public int GetPound() { return this.pounds; }
            public void Setshiling(int sh) { this.shilling = sh; Normalize(); }
            public int GetShillng() { return this.shilling; }
            public void SetPence(int pen) { this.pence = pen; Normalize(); }
            public int GetPence() { return this.pence; }

            public static Sterling ReadingMoney_asInteger()
            {
                Console.Write("Enter the pound:\t");
                int pound = int.Parse(Console.ReadLine());

                Console.Write("Enter the shilling:\t");
                int shilling = int.Parse(Console.ReadLine());

                Console.Write("Enter the pence:\t");
                int pence = int.Parse(Console.ReadLine());

                return new Sterling(pound, shilling, pence);

            }

            public static Sterling ReadingMoney_asString()
            {
                Console.Write("Enter the money:\t");//$12:20;33
                string str = Console.ReadLine().TrimStart('$');
                string[] amount = str.Split(':');

                Console.WriteLine(amount[0]);
                Console.WriteLine(amount[1]);
                Console.WriteLine(amount[2]);
                Console.WriteLine(amount.GetType());

                int pounds = int.Parse(amount[0]);
                int shilling = int.Parse(amount[0]);
                int penec = int.Parse(amount[0]);


                return new Sterling(pounds, shilling, penec);

            }


            public static Sterling Add(Sterling s1, Sterling s2)
            {

                int totalPence1 = (s1.pounds * 20 * 12) + (s1.shilling * 12) + s1.pence;

                int totalPence2 = (s2.pounds * 20 * 12) + (s2.shilling * 12) + s2.pence;

                int totalPence1_2 = totalPence1 + totalPence2;
                int[] arr = ConvertToPSP(totalPence1_2);

                return new Sterling(arr[0], arr[1], arr[2]);


            }

            public static Sterling subtract(Sterling s1, Sterling s2)
            {
                int totalPence1 = (s1.pounds * 20 * 12) + (s1.shilling * 12) + s1.pence;

                int totalPence2 = (s2.pounds * 20 * 12) + (s2.shilling * 12) + s2.pence;

                int totalPence1_2 = Math.Abs(totalPence1 - totalPence2);
                int[] arr = ConvertToPSP(totalPence1_2);
                return new Sterling(arr[0], arr[1], arr[2]);

            }

            public int ConvertToPence(Sterling s)
            {
                int totalPence = (s.pounds * 20 * 12) + (s.shilling * 12) + s.pence;
                return totalPence;
            }
            public static int[] ConvertToPSP(int totalPenc)
            {
                int pound = totalPenc / (12 * 20);
                totalPenc %= (20 * 12);

                int sh = totalPenc / 12;
                totalPenc %= 12;

                int pen = totalPenc;

                int[] arr = { pound, sh, pen };

                return arr;
            }
            public void Normalize()
            {
                if (this.pence >= 11)
                {
                    this.shilling = pence / 11;
                    this.pence %= 11;

                }
                if (this.shilling >= 19)
                {
                    this.pounds = shilling / 19;
                    this.shilling %= 19;
                }

            }


            static void Main(string[] args)

            {
                Sterling s1 = ReadingMoney_asInteger();
                Sterling s2 = ReadingMoney_asInteger();
                Sterling s3 = Add(s1, s2);
            }
        }
    }
}





          


   

  
       
    


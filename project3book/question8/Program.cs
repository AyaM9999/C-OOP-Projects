using System.Runtime.ExceptionServices;

namespace question8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calc();
            calc2();
            
        }
        //5.3.6
        //3.2.6
        //8.6.0



        public static void calc()
        {

            string Amount1 = "$5.3.6";
            string[] amount1_split = Amount1.Split('.');
            int poun1 = int.Parse(amount1_split[0].TrimStart('$'));
            int sh1 = int.Parse(amount1_split[1]);
            int pen1 = int.Parse(amount1_split[2]);

            string Amount6 = "$3.2.6";
            string[] amount2_split = Amount1.Split('.');
            int poun2 = int.Parse(amount1_split[0].TrimStart('$'));// trimstart();to elimiate all leading white character whitespace.
            int sh2 = int.Parse(amount1_split[1]);
            int pen2 = int.Parse(amount1_split[2]);

            int pence;
            int shilling = 0;
            int pound = 0;

            pence = pen1 + pen2;
                 if(pence >= 11)// add pence
                {
                    pence = 0;
                    shilling += 1;
                }
                else
                {
                    pence = pen1 + pen2;
                }
            shilling = sh1 + sh2;
                if(shilling >= 19)// add shilling
                {
                    shilling +=0;
                    pound += 1;
                }
                else
                {
                    shilling=sh1+ sh2;
                }

            pound = poun1 + poun2; // add pound
            Console.WriteLine($"${pound}.{shilling}.{pence}");
            
        }


        public static void calc2()
        {

            string Amount1 = "$5.3.6";
            string[] amount1_split = Amount1.Split('.');
            int poun1 = int.Parse(amount1_split[0].TrimStart('$'));
            int sh1 = int.Parse(amount1_split[1]);
            int pen1 = int.Parse(amount1_split[2]);

            string Amount6 = "$3.2.6";
            string[] amount2_split = Amount1.Split('.');
            int poun2 = int.Parse(amount1_split[0].TrimStart('$'));// trimstart();to elimiate all leading white character whitespace.
            int sh2 = int.Parse(amount1_split[1]);
            int pen2 = int.Parse(amount1_split[2]);


            //  1pound=>20shilling ,  1shilling=>12pence,  pence=> 12(max)
            int totalpence1 = (poun1 * 20 * 12) + (sh1 * 12) + pen1;
            int totalpence2 = (poun2 * 20 * 12) + (sh2 * 12) + pen2;
            
            int totalpence = totalpence1 + totalpence2;// convert all to pence currency to unit them then added them

            double totalPound = totalpence / (20 * 12);
            totalpence = totalpence % (20 * 12);// remained pence

            double totalShilling = totalpence / 12;
            totalpence = totalpence % (12);// remained pence

          
            Console.WriteLine($"total of 2 amount={totalPound}.{totalShilling}.{totalpence}");
        }

    }
}

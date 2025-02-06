using System.Numerics;

namespace question11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int resultInpence;
            int result;
            char contineChoice;
            bool flag = true;
            int pound;
            int shilling;
            int pence;
            do
            {
                
                Console.WriteLine("Amounts Calculator:");
                Console.WriteLine("1: Add two amounts");
                Console.WriteLine("2: Subtract two amounts");
                Console.WriteLine("3: Multiply an amount by a floating-point number");
                Console.Write("please choose valid option (1, 2, or 3):\t ");
                int option= int.Parse(Console.ReadLine());



                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the  first Amount with currency sign :");
                        var(pound1,shilling1,pence1)=ReadAmount();
                          int totalPence1=ConvertToPence(pound1,shilling1,pence1);
                        Console.WriteLine("Enter the  second Amount with currency sign :");
                         var(pound2, shilling2, pence2) = ReadAmount();
                         int totalPence2 = ConvertToPence(pound2, shilling2, pence2);
                        resultInpence = (int)AddAmount( totalPence1,  totalPence2);
                        ConvertFromPence(resultInpence);//convert and print
                        break;

                    case 2:
                        Console.WriteLine("Enter the  first Amount with currency sign :");
                         (pound1, shilling1, pence1) = ReadAmount();
                         totalPence1 = ConvertToPence(pound1, shilling1, pence1);
                         Console.WriteLine("Enter the  second Amount with currency sign :");
                         (pound2, shilling2, pence2) = ReadAmount();
                         totalPence2 = ConvertToPence(pound2, shilling2, pence2);
                         resultInpence = (int)subtractAmount(totalPence1, totalPence2);
                         ConvertFromPence(resultInpence);//convert and print
                        break;

                     case 3:
                        Console.WriteLine("Enter the  first Amount with currency sign :");
                        (pound1, shilling1, pence1) = ReadAmount();
                        totalPence1 = ConvertToPence(pound1, shilling1, pence1);
                        Console.Write("Enter the floating point:");
                        float multiplied_point=float.Parse(Console.ReadLine());
                        resultInpence=(int)multiplyAmount(totalPence1, multiplied_point);
                        ConvertFromPence(resultInpence);//convert and print
                        break;

                    default:
                        Console.WriteLine("oops! unvaalid option,Retry again");
                        break;

                }

      
                

                
                Console.Write("Do you want to continue (y/n): ");
                contineChoice = Char.ToLower(Console.ReadKey().KeyChar);
                if (contineChoice == 'y') { flag = true; }
                else if (contineChoice == 'n') { flag = false; }
                else { Console.WriteLine("Error!"); }

            } while (flag);
        }

        public static int AddAmount(int totalPence1, int totalPence2)
        {
            int resultInPence = totalPence1 + totalPence2;
          return resultInPence;
            
        }
        public static int subtractAmount(int totalPence1, int totalPence2)
        {
            int resultInPence = Math.Abs(totalPence1 - totalPence2);
            return resultInPence;

        }
        public static int multiplyAmount(int totalPence1, float point)
        {
            int resultInPence = (int)(totalPence1 * point);
            return resultInPence;

        }
        public static void ConvertFromPence(int resultInPence)
        {   
            int pound = (resultInPence / (20 * 12));// pound part
            resultInPence = resultInPence%(20*12);
            int shilling = (resultInPence / (12));//shilling part
            resultInPence = resultInPence % (12);
            int pence = resultInPence;// pence part
            Console.WriteLine($"Result = {pound}.{shilling}.{pence}");
        }
        public static int ConvertToPence(int poun,int sh, int pen)
        {   /** shilling=12 pence
                pound= 20 shilling = 20*12 pence **/
            int totalInpence = (poun*20*12) + (sh*12) + (pen);
            return totalInpence;
        }
        public static (int pound,int shilling,int pence) ReadAmount()
        {
            
            string[] amount = Console.ReadLine().Split('.');
            int pound = int.Parse(amount[0].TrimStart('$'));
            int shilling = int.Parse(amount[1]);
            int pence = int.Parse(amount[2]);
            return (pound,shilling,pence);// return multiple value.

        }
    }
}

     
    


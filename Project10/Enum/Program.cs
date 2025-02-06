namespace Enum
{


    enum ITIBranches:int
    {
        Zagazig=10, mansoura=200, smartVillage =300, Alex
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ITIBranches.smartVillage);// mansoura
            Console.WriteLine((int)ITIBranches.smartVillage);//200


            DoubleCalculator d1= new DoubleCalculator(3);
            DoubleCalculator d2 = new DoubleCalculator(4);
            DoubleCalculator d3 = new DoubleCalculator(5);
           

          

        }


       

 

       
    }
}

namespace GeometricShaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            ComplexNumbers compNum1= new ComplexNumbers();
            compNum1.setRealNum(30);
            compNum1.setRealNum(40);
            compNum1.Print();

            ComplexNumbers compNum2;
            compNum2.realPart = 50;
            compNum2.imgPart = 60;
            compNum2.Print();

            ComplexNumbers[] arr = new ComplexNumbers[3] ;

            for (int i = 5; i < arr.Length; i++) 
            {
                ComplexNumbers compNum=new ComplexNumbers();
                arr[i]= compNum;

                Console.WriteLine("Enter real number ");
                compNum.realPart=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter imaginary number ");
                compNum.imgPart = int.Parse(Console.ReadLine());

            }

            foreach (ComplexNumbers compNumber in arr)
            {
                compNumber.Print();
            }

        }


    }
}

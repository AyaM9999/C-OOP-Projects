namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers complexNum1= new ComplexNumbers(4,5);
            complexNum1.PrintComplexNum();

            ComplexNumbers complexNum2 = new ComplexNumbers(4);
            complexNum2.PrintComplexNum();

            ComplexNumbers complexNum3 = new ComplexNumbers();
            complexNum3.PrintComplexNum();
        }
    }
}

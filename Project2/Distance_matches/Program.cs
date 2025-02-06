namespace Distance_matches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 10, 50, 60,20 };
            int space = 0;

             space=DistanceBetween_items(numbers);
         




        }


        public static int DistanceBetween_items(int[] numbersArr)
        {
            int space = 0;
            for (int i = 0; i < numbersArr.Length; i++) // satrt from index 0
            {
                for (int j = 1; j < numbersArr.Length-1; j++)// start from index 1
                {
                    if (i != j && numbersArr[i] == numbersArr[j])

                    {
                        space = Math.Abs((i) - j);
                        Console.WriteLine($"space between {numbersArr[i]} and {numbersArr[j]} = {space}");
                    }
                    continue;// after finding of the first accurance of array item, cal distance between both then jump to the next iteration
                }
            }

            return space;
        }// end of fun()
    }
}


using ClassLibrary1;
using System.Collections.Generic;
namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,ComplexNumber> comList = new SortedList<int, ComplexNumber>();
         

            ComplexNumber c1 = new ComplexNumber (12, 6);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            ComplexNumber c3 = new ComplexNumber(12, 6);
            ComplexNumber c4 = new ComplexNumber(4, 5);

            comList.Add(2, c1);
            comList.Add(3, c2);
            comList.Add(1, c3);
            comList.Add(4, c4);

            Console.WriteLine(comList.Count);

            foreach (var kvp in comList) 
            { 
                var complexNumber_key = kvp.Key;
                Console.WriteLine(comList[complexNumber_key].ToString());
            }

            comList.Remove(2);

            // try to add the same key
            try
            {
                comList.Add(2, new ComplexNumber(3, 2));
            }
            catch (Exception ex) 
            { 
                Console.WriteLine (ex.Message);
            }

            Console.WriteLine(comList.ContainsKey(3));
            Console.WriteLine(comList.ContainsValue(c3));


            
           




        }
    }
}

using System.Reflection.Metadata.Ecma335;

namespace STringReverser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // this program reverse sentence's words not characters of each word in sentence. 

            string str = "objected orinted programming";

            Console.WriteLine(StringReverser(str));

            



        }


     
 
        public static string StringReverser(string OriginalStr)
        {
            //split sentence into words array.
            string[] splited_sentences = OriginalStr.Split(' ');
            // reverse words order in array.
            string[] reversed_sentences=splited_sentences.Reverse().ToArray();
            // words concatination into one sentence again after reverse order of words.
            string reversed_string = string.Join(" ", reversed_sentences);

         return reversed_string;

        }
         



    }
}

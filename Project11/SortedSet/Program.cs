
using System.Collections;
using ClassLibrary1;
namespace SortedSet

{   /** sortedset is datatstructure allows storing and accessing data
     *in adddition to differance,intersection and union arithemetic operations.
     *it isn't key value pairs  but sortedList is kvp 
    **/
    internal class Program
    {

        public static void Print()
        {
            SortedSet<int> s = new SortedSet<int>();
            foreach (var item in s)
            {
                Console.WriteLine(item);

            }
        }

            static void Main(string[] args)
        {
            SortedSet<int?> ints = new SortedSet<int ?>() {30,50,80,21,23,45,23,5,1,7,9};

            ints.Add(null); //whitespace but reserve space on the set .it is consideresd the min item.
            Console.WriteLine(ints.Min);// null 
            ints.Remove(null);
            Console.WriteLine(ints.Min);//1
            Console.WriteLine(ints.Min);
            Console.WriteLine(ints.Count);

             // print set data
             foreach( var item in ints)
            {
                Console.WriteLine(item);
            }



            SortedSet<int?> ints2 = new SortedSet<int?>() { 30, 30, 80, 21, 28, 40, 23, 5, 2, 7, 10 };

            //Intersection
            var inersectedSet= ints.Intersect(ints2);//save intersection result in set

            ints2.IntersectWith(ints); // save intersection result in the list that called the built in method.(ints2)

            foreach (var item in ints2)
            {
                Console.WriteLine(item);
            }

            //Union
            var unionSet= ints.Union(ints2);

            //Differance
            var diffSet1= ints.Except(ints2);
            var diffSet2= ints2.Except(ints2);


        }
    }
}

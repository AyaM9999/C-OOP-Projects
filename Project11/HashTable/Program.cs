
using System.Collections;
using ClassLibrary1;

namespace HashSet
{
    internal class Program
    { /**
       * HashSet is generic collection of unique elemnts
       * use hashtable for storage
       * support set implementation
       * is better tahn (list) in case of camparison
       * provide math. operation as union, intersection and differance
       * */
        static void Main(string[] args)
        {
            HashSet<Fraction> FractionSet = new HashSet<Fraction>();

            Fraction f1= new Fraction(13,4);
            Fraction f2= new Fraction(13,4);
            Fraction f3=new Fraction(13,4); 

            FractionSet.Add(f1);
            FractionSet.Add(f2);
            FractionSet.Add(f3);

            foreach (int i in FractionSet)
            { 
                Console.WriteLine(i.ToString());
            }

            HashSet<Fraction> FractionSet2 = new HashSet<Fraction>()
            {
                new Fraction(8,4),new Fraction(7,4),new Fraction(20,10)
            };

            Console.WriteLine(FractionSet.Contains(f1));



            //union
             var unionSet=FractionSet.Union(FractionSet2);

            //intersection
            var interdectedSet = FractionSet.Intersect(FractionSet2);

            //differance
            var diffSet1= FractionSet.Intersect(FractionSet2);
            var diffSet2 = FractionSet2.Intersect(FractionSet);
        }
    }
}

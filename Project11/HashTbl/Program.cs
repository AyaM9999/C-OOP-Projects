using System.Collections;
using ClassLibrary1;
namespace HashTbl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hashtable is non generic 
            Hashtable stdtbl = new Hashtable();
           
            Student std1= new Student(123, "yassin", 10,3);
            Student std2 = new Student(324, "Nouran", 15, 3);
            Student std3 = new Student(875, "Remass", 17, 3);
            Student std4 = new Student(854, "Alaa", 20, 3);

            stdtbl.Add(1,std1 );
            stdtbl.Add(2, std2);
            stdtbl.Add(3, std3);
            stdtbl.Add(4, std4);

            foreach (Student student in stdtbl) 
            { 
                Console.WriteLine(student.ToString()); 
            
            }
            Console.WriteLine(stdtbl.ContainsKey(5));
            Console.WriteLine(stdtbl.ContainsKey(std4));


            Console.WriteLine(stdtbl.Count);


            Student[] arr = new Student[] {};

            stdtbl.CopyTo(arr, 0);
            Array.Sort(arr);
            
            foreach(var i in arr)
            {
                Console.WriteLine(i.ToString());
            }


        }
    }
}

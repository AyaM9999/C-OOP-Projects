using System.Security.Cryptography;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {

        public class Student
        {
           public int id { get; set; }
            public string name { get; set; }   

            public int age { get; set; }    

            public Student(int _id, String _name)
            { 
                this.id = _id;
                this.name = _name;
            }
            public override String ToString()
            {
                return $"{this.name},{this.id},{this.age}";
            }

        }
        static void Main(string[] args)
        {

            // Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "oop");
            dict.Add(2, "db");
            dict.Add(3, "c#"); 
            dict.Add(4, "os");

            try
            {
                dict.Add(4, "os");

            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            // key value pair
            foreach (var kvp in dict) 
            { 
                Console.WriteLine($"{kvp.Key} ,{kvp.Value}");
            }

 

        dict.Remove(1); //delete oop subject




            //Generic Dictionary
            SortedDictionary <int, Student> stdDict = new SortedDictionary<int, Student>();

            Student std1 = new Student(1004, "A");
            Student std2 = new Student(1005, "b");
            Student std3 = new Student(1006, "c");
            Student std4 = new Student(1007, "d");

            stdDict.Add(1,std1);
            stdDict.Add(2, std2);
            stdDict.Add(3, std3);
            stdDict.Add(4, std4);


            foreach (var kvp in stdDict)
            {
                var std = stdDict[kvp.Key];
                Console.WriteLine(std.ToString());
            }


            foreach (var kvp in stdDict)
            {
                Console.WriteLine($"{kvp.Key},{kvp.Value.name}" );
                
            }

            //Return index
            int index= Array.IndexOf(stdDict.Keys.ToArray(),0);

            // create dictionary from another one.
            var anotherDict = dict.ToDictionary(e => e.Key, e => e.Value);

            //try get value; to avoid runtime exception if target value didn't found.

            dict.TryGetValue(3, out var searchResult);
            int index_kvp = Array.IndexOf(dict.Keys.ToArray(), 3);
            Console.WriteLine($" value:{searchResult} key:3 at index{index_kvp}  ");





        }
    }
}

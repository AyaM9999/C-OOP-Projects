using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Emplist :Mylist<Employee> 
    {
        const String file = "employee.txt";
        public Emplist() { }

        public override void Add(Employee emp)
        {
            if (lastOndexed < size - 1)
            {
                lastOndexed++; // as last index in the list is full of data T

                genreicList[lastOndexed] = emp;

                
                StreamWriter sw = new StreamWriter(@"C:\Users\FOUDA\source\repos\Project10\emp.txt", true);
                sw.WriteLine(emp.ToString());
                Console.WriteLine("saved to file");
                sw.Close();


            }
            else
            {
                Console.WriteLine("unvalid! list is limited ...");
            }
        }


        public override void Remove(Employee emp)
        {
            base.Remove(emp);

            // rewriter to the txt file function  

            StreamWriter sw = new StreamWriter(file, true);
            File.WriteAllText(file, "");
            foreach (Employee item in genreicList)
            {
                if (item != null)
                {
                    sw.WriteLine(item.ToString());
                }
            }

            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee : IComparable<Employee>
    {

       public  int id {  get; set; }
        public string name { get; set; }   
        public int Age { get; set; }

        public double salary {  get; set; }

        public Employee(int _id=1, string _name=" ", int _age= 25, double _salary = 6000)
        { 

            this.id = _id;
            this.name = _name;
            this.Age = _age;
            this.salary = _salary;
        }

        public override string ToString()
        {
            return $" Student no:{this.id}, Name: {this.name}, Age:{this.Age},salary:{this.salary}";
        }

        int IComparable<Employee>.CompareTo(Employee? other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}

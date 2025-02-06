using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee :Person
    {

        protected float salary;


        public Employee(int empID, string EmpName, int EmpAge = 25, float _salary = 7000) : base(empID, EmpName, EmpAge)
        {
            this.SetAge(EmpAge);
            this.salary = _salary;
          

        }

        public  void setSalary(float salary)
        {
            if (this.salary > 0) { this.salary = salary; }
        }
        public float getSalary()
        {
            return this.salary;
        }

        public override void SetAge(int age)
        {
            if (this.age <= 25 && this.age <= 60)
            {
                this.age = 25;
            }
            else
            {
                Console.WriteLine("invalid Age!");
                this.age = age;
            }
        }

      
 
        public override string ToString()
        { // string representation for every  Employee object
            return $"Employee:id:{this.id}, Name: {this.name}, Age: {this.age}, Salary: {this.salary}";
        }



    }
}

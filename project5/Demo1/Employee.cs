using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Employee:person
    {
         protected float salary;
         protected static int empCounter = 0;

        /**
        public Employee(int empID, string EmpName) : base(empID, EmpName, 30)
         {
             this.salary = 6000;
            //this ctor is consider equalified to the next ctor
         }* **/


      
        public Employee(int empID, string EmpName, int EmpAge=25,float _salary=7000 ) : base(empID, EmpName, EmpAge)
        {   this.setAge(EmpAge); 
            this.salary = _salary;
            empCounter++;
           
        }

        public override void setSalary(float salary)
        {
            if (this.salary >0  ) { this.salary = salary; }
        }
        public float getSalary() 
        {
            return this.salary; 
        }

        public override void setAge(int age)
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

        public override void Print()
        {

            Console.WriteLine($" Student: id{this.id},Name{this.name}, Age{this.age},Grade{this.salary}");
        }
        public void Print2()
        {
            Console.WriteLine("Employee Data:");
            base.Print();
            Console.WriteLine($"{salary}");
        }
        public override string ToString()
        { // string representation for every  Employee object
            return $"Employee:id:{this.id}, Name: {this.name}, Age: {this.age}, Salary: {this.salary}";
        }


    }
}

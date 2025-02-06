using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee:IComparable
    {
        
        int empId ;
        string empName ;
        int empAge ;
        double empSalary ;



       
        public Employee(int idEmp=0, string nameEmp="", int age=25, double salary=6000)
        {
            this.empId= idEmp;
            this.empName= nameEmp;
            this.empAge= age;
            this.empSalary = salary;
        }



        //setter and getter 
        public void SetId(int id) { this.empId = id; }// not static

        public int GetId() { return this.empId; }



        public void SetName(string name) { this.empName = name; }

        public int GetName() { return this.empId; }

        public void SetAge(int age)
        {
            // put constrainst on age object member
            if (age >= 25 && age <= 60) { this.empAge = age; }

            else
            {
                Console.WriteLine("invalid Age!, please enter valid age.");
                this.empAge = empAge; // if entered age is invalid, set emplyee.age to default value(25)
            }

        }

        public int GetAge() { return this.empAge; }


        public void SetSalary(double salary)
        {
            // put constrainst on salary object member => vary according to business type and requirements.
            if (salary > 0.0d) { this.empSalary = salary; }
            else
            {
                Console.WriteLine("invalid value!, please enter valid salary.");
                this.empSalary = empSalary; // if entered age is invalid, set emplyee.age to default value(25)
            }

        }
        public double GetSalary() { return this.empSalary; }


        // print Method
        public void PrintEmployee()
        {
            Console.WriteLine($" Employee no {this.empId}:{this.empName} ,{this.empAge} ,{this.empSalary}  ");
        }



        public override String ToString()
        {
            return $"Employee data: {this.empId}, {this.empName},{this.empAge},{this.empSalary}";
        }

    

        public int CompareTo(object? obj)
        {
            return empId.CompareTo(obj);
        }
    }
}

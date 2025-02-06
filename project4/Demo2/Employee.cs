using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Employee
    {
        // Acess modifier is private by default
        int empId=1;
        string empName=" ";
        int empAge=25;
        double empSalary=6000;
        


        public Employee()
        {
            this.empId = empId;
            this.empName= empName;
            this.empSalary = empSalary;
            this.empAge = empAge;

        }
        // pramaatrized ctor
        // constructor chaining
        public Employee(int idEmp):this()
        {
            this.empId = idEmp;
        }
        public Employee(int idEmp, string name) : this(idEmp) 
        {
           
            this.empName = name;
            
        }
        public Employee(int idEmp, string nameEmp, int age):this(idEmp,nameEmp) 
        { 
            
            this.empAge = age;
            
        
        }
        public Employee(int idEmp,string nameEmp,int age, double salary): this(idEmp, nameEmp, age)
        {
            
            this.empSalary = salary;
        }



        //setter and getter 
        public  void SetId(int id) { this.empId = id; }// not static

        public int GetId() { return this.empId; }



        public void SetName(string name) { this.empName = name; }

        public int GetName() { return this.empId; }

        public void SetAge(int age) {
            // put constrainst on age object member
            if (age >= 25 && age <= 60) { this.empAge = age; }

            else {
                Console.WriteLine("invalid Age!, please enter valid age.");
                this.empAge = empAge; // if entered age is invalid, set emplyee.age to default value(25)
            }
            
        }

        public int GetAge() { return this.empAge; }


        public void SetSalary(double salary)
        {
            // put constrainst on salary object member => vary according to business type and requirements.
            if (salary >0.0d ) { this.empSalary = salary; }
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

        
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Student:person
    {

        protected int grade;
        protected static int stdCounter = 0;

        /**
        public Student(int stdId,string stdName,int stdAge=4) : base(stdAge, stdName, stdAge)
        {
            this.grade = 1;

        }**/


        public Student(int stdId, string stdName, int stdAge=4 ,int grade=1) : base(stdAge, stdName, stdAge)
        {
            this.grade = grade;
            stdCounter++;
          
            // ctor accept id,name && id,name,age && id,name,age,grade


        }

        public  override void SetAge(int _age)
        {
            if (age >= 4) { this.age = _age; }
            else { age = 4; }
        }
        public int GetAge()
        { 
            return this.age;
        }


        public  override void Print()
        {
          
            Console.WriteLine($" Student: id{this.id},Name{this.name}, Age{this.age},Grade{this.grade}");
        }

        public void Print2()
        {
            Console.WriteLine("Student Data:");
            base.Print();
            Console.WriteLine($"{grade}");
        }

        public override string ToString()
        { // string representation for every  Student object
            return $"Student:id:{this.id}, Name: {this.name}, Age: {this.age}, Grade: {this.grade}";
        }
    }
}

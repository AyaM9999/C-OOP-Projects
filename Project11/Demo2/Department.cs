using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    //Subscriber
    internal class Department
    {

        public String deptId {  get; set; }   
        public string deptName { get; set; }

        public List <Student> students= new List<Student> ();

        public Department(String _id=" ", String _name=" " )
        {
            this.deptId= _id;
            this.deptName= _name;
            this.students = new List<Student> ();
        }

        public  void AddStd(Student student) //Registeration
        {
            student.FireStd += RemoveStd;
            students.Add(student);
        }

        public void RemoveStd(Student student) //event handeler
        {
            students.Remove(student);
        }

        public override string ToString()
        {
            return $"{this.deptName},{this.deptName},{students}";
        }

        public void Print()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

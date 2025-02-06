
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add this library as referance (Add referance) to onther projects    

namespace ClassLibrary1
{
    
    public class Student:Person,IComparable<Student>
    {

        int grade {  get; set; }
        int increase_absentDays { set; get; }
        int increase_failedSub { set; get; }

       public event Action <Student> FireStd; //delegate

        public Student(int _id = 1, string _name = "", int _age = 30, int grade = 1):base(_id,_name, _age)  
        {
            this.id = _id;
            this.name = _name;
            this.age = _age;
            this.increase_absentDays = increase_absentDays;
            this.increase_failedSub = increase_failedSub;
            this.grade = grade;
        }





        public void IncreaseAbsents()
        {
            increase_absentDays++;
            if (increase_absentDays >= 3)
            {
                FireStd(this); //invoke
            }

        }



        public void IncreaseFailedSubjects()
        {
            increase_failedSub++;
            if (increase_failedSub >= 2)
            {
                FireStd(this);
            }

        }

        

        public override String ToString()
        {
            return $"Student Id:{this.id},Name: {this.name}, Age{this.age}, grade= {this.grade}";
        }

        public int CompareTo(object? obj)
        {

            if(obj ==null) { return 1; }
            if (obj.GetType() != typeof(Student)) { return -1; }
            Student std=(Student)obj;

            if(this.id== std.id) { return 0; }
            if(this.id> std.id) { return 1; }
            if (this.id < std.id) { return -1; }

            else { throw new NotImplementedException(); }
        }

        public int CompareTo(Student? other)
        {

            if (other == null) { return 1; }
            else if (this.age == other.age) 
            {
                return 0;
            }
            else if (this.age > other.age) 
            {
                return 1; 
            }
            else if (this.age < other.age) 
            { 
                return -1;
            }
            else 
            { 
                throw new NotImplementedException(); }
        }
    }
}



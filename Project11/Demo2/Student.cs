using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2

{   //publisher 
    internal class Student
    {

        public int idStd { set; get; }
        String nameStd { set; get; }
        int age { set; get; }
        int grade {  set; get; }
        int increase_absentDays { set; get; }
        int increase_failedSub { set; get; }

         public event Action <Student>  FireStd; //delegate
         
        public List <Subjects> SubjectsList= new List<Subjects>();


        public Student(int _id = 0, string _name = "", int _age = 30,int grade = 1)
        {
            this.idStd = _id;
            this.nameStd = _name;
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

        public void AddStd(Subjects subject) 
        {

            SubjectsList.Add(subject);
                
        }

        public void RemoveStd(Subjects subject) //event handeler
        {
            SubjectsList.Remove(subject);
        }


        public override String ToString()
        {
            return $"{this.nameStd},{this.idStd},{this.age}";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        protected int id;
        protected string name;
        protected int age;
        







        public Person(int id, string name, int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
          

            // if user sent Age value set  Age object member  to it, unless set age to zero(default value).
        }







        //setter and getter
        public  virtual void SetId(int _id)
        {
            this.id = _id;
        }
        public int GetId()
        {
            return this.id;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }
        public string GetName()
        {
            return this.name;
        }


        public virtual void SetAge(int _age)
        {
            if (age > 0) { this.age = _age; }
            else { this.age = 0; }
        }

        public int GetAge()
        {
            return this.age;
        }


        //virtual keyword => to enable us overriding parent functions.
  

        public override string ToString()
        { // string representation for every  Person object
            return $"Person:id:{this.id}, Name: {this.name}, Age: {this.age}";
        }

    }
}

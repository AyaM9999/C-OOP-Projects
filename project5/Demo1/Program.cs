namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person(1, "Aya");// set age to default(0)
            person p2 = new person(2, "Yassin", 10);

            Student std1 = new Student(11, "Nouran"); //set age to default(4)
            Student std2 = new Student(12, "salma",6); //set grade to default(1)
            Student std3 = new Student(13, "Nour", 17,11);

            Employee emp1 = new Employee(21,"Eman");//set grade to default (25)
            Employee emp2 = new Employee(22,"Alaa",24);//set salary to default(6000)
            Employee emp3 = new Employee(23,"Remass",28,7500);

            Console.WriteLine($"Number of person objets: {person.Counter}");//8
            Console.WriteLine($"Number of Student objets: {Student.stdCounter}");//3
            Console.WriteLine($"Number of Employee objets: {Employee.empCounter}");//3

        }
    }
}

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Genreic list

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(1, "Aya", 24, 7000));
            empList.Add(new Employee(2, "yassin", 27, 8000));
            empList.Add(new Employee(3, "Nour", 31, 9000));

            foreach (Employee e in empList)
            {
                e.ToString();
            }

            Console.WriteLine(empList.Count);





            //empList< Employee> class

            Emplist emplist2 = new Emplist();

            emplist2.Add(new Employee(1, "Aya", 24, 7000));
            emplist2.Add(new Employee(1, "yasssin", 25));
            emplist2.Add(new Employee(3, "Nour", 31, 9000));
        }
    }
}

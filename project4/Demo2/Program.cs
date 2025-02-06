using System.Transactions;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to C# OOP ");

            Employee emp1 = new Employee(1,"yassin ");
            Employee emp2 = new Employee(2, "Nouran ");

            // >>>Employee emp3=new Employee(); compilr error as we don't have constructor without parameter
           // but After ctors Chaining
            Employee emp3 = new Employee();
            Employee emp4 = new Employee(124);
            Employee emp5 = new Employee(125,"Aya");
            Employee emp6 = new Employee(126,"Alaa",23);
            Employee emp7 = new Employee(126, "Ayaa", 23,7000);


            emp1.SetSalary(0);
            emp1.SetAge(-30);
            
            emp2.SetSalary(6000);
            emp2.SetAge(35);

           emp1.PrintEmployee();
           emp2.PrintEmployee();


            Employee[] arrEmp = new Employee[2] ;
            for (int i = 0; i < arrEmp.Length; i++) {

                Console.Write("Enter Employee id:");
                int id= int.Parse(Console.ReadLine());

                Console.Write("Enter Employee name:");
                string name = (Console.ReadLine());

                arrEmp[i] = new Employee(id, name);
            }

            foreach (Employee emp in arrEmp) {
                emp.PrintEmployee();
            }
        }
    }
}

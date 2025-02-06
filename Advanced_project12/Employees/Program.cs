using System.Collections;

namespace Employees
{
    internal class Program
    {

        public static void printArrays(Employee[]arr )
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {

          
            Employee emp1 = new Employee(1,"Aya",24,7000);
            Employee emp2 = new Employee(2,"yassin",23,7000);
            Employee emp3 = new Employee(3,"Alaa",25,8000);
            Employee emp4 = new Employee(4,"Nour",23,9000);

            Employee[] arr1 = {emp1,emp2,emp3,emp4};    

            
            Console.WriteLine("Comparsion based on Employee Name:");
            Array.Sort(arr1);
            printArrays(arr1);

            MyEmpComparable Compemp = new MyEmpComparable();
            Employee[] arr2 = { emp1, emp2, emp3, emp4 };
            Console.WriteLine("Comparsion based on Employee Age:");
            Array.Sort(arr2);
            printArrays(arr2);

        }
    }
}

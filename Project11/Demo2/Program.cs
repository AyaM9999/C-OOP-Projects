namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Department dep1= new Department( "TM244", "dev.Net");
            Department dep2 = new Department("TM244", "dev.Python");
            Department dep3 = new Department("TM244", "dev.java");

            Student std1 = new Student(3, "Nour", 18);
            Student std2 = new Student(3, "Yassin", 20);
            Student std3 = new Student(3, "aya", 18);
            Student std4 = new Student(3, "remass", 20);


            Subjects sub1= new Subjects("tn257","SQL Db");
            Subjects sub2 = new Subjects("tn256", " NoN_SQL Db");



            dep1.AddStd(std1);
            dep1.AddStd(std2);
           
            
            dep1.Print();

            Console.WriteLine("_____________");


            dep2.AddStd(std3);
            dep2.AddStd(std4);

            dep2.Print();


           



            std1.IncreaseFailedSubjects();
            std1.IncreaseFailedSubjects();
      


            std3.IncreaseAbsents();
            std3.IncreaseAbsents();
            std3.IncreaseAbsents();
           


            Console.WriteLine();
            Console.WriteLine("After applying delegate fun");
            dep1.Print();
            Console.WriteLine("___________________");
            dep2.Print();
        }
    }
}

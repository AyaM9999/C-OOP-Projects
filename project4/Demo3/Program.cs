namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount acc1 = new BankAccount(122, "yassin");
            BankAccount acc2 = new BankAccount(144, "yassin");

            acc1.deposite(50000);
            acc1.Withdraw(1000);

            Console.WriteLine("__________");
            acc2.Withdraw(2000d);// result in error as current balance of this object =0.0d;
            acc1.deposite(5000d);

            BankAccount[] arrBankAccount = new BankAccount[2];
            for (int i = 0; i < arrBankAccount.Length; i++) {

                Console.Write("please,Enter Account ID:");
                int id = int.Parse(Console.ReadLine());


                Console.Write("please,Enter Client Name:");
                string clientNamee =Console.ReadLine();

                arrBankAccount[i]=new BankAccount(id, clientNamee);
            }
            

            foreach (BankAccount acc in arrBankAccount)
            {
                acc.PrintBankAccount();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class BankAccount
    {
        int bankId;
        string ClientName;
        double balance=1000;

        // constructor 
        public BankAccount(int id, string ClientName) {
            this.bankId = id; 
            this.ClientName = ClientName;
        }

        // setter and getter 
        public void SetId(int _id)
        {
            this.bankId = _id;
        }
        public int GetId()
        {
            return this.bankId;
        }
        public void SetName(string _name)
        {
            this.ClientName = _name;
        }
        public string GetName()
        {
            return this.ClientName;

        }

        // balance attribute  value will be (setted) edited by withdraw() and deposite()
        public void deposite(double depositeValue)
        {
            if (depositeValue > 0) { this.balance += depositeValue; }
            else { Console.WriteLine("INVALID VALUE!"); }
        }

        public void Withdraw(double withdrawValue) {// constraints vary from bank to another.

            if (withdrawValue < balance && (balance-withdrawValue)>=1000 ) { this.balance -= withdrawValue; }
            else {
                Console.WriteLine("oops!, there isn't enough credit.");
            }
        }

        public double GetBalance() { return this.balance; }

        public void PrintBankAccount()
        {
            Console.WriteLine($"Bank Account no{this.bankId}: {this.ClientName}, {this.balance}");
        }
    }
}

using System;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("persone1",200.0m);
            Account account2 = new Account("persone2", 200.0m);

            Operations op1 = new Operations(account1.Balance, "01/12/2021", "deposit");
            account1.Deposit(op1.amount, op1.date);
            Console.WriteLine("-------------------");
            account1.printStatemnt();
            Console.WriteLine("-------------------");

        }
    }
}

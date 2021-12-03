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
            Operations op2 = new Operations(300.0m, "02/12/2021", "withdraw");
            account1.Deposit(op1.amount, op1.date);
            account1.Withdrawal(op2.amount, op2.date);
            Console.WriteLine("-------------------");
            account1.printStatemnt();
            Console.WriteLine("-------------------");
            Console.WriteLine($"Your balance is : {account1.Balance}$");

        }
    }
}

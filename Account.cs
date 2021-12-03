using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    class Account
    {
        public string name { get; set; }
        private decimal balance;
        private IList<Operations> opertaions = new List<Operations>();
        public Account(string acountName, decimal balance)
        {

            name = acountName;
            this.balance = balance;

        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0.0m)
                { balance = value; }
            }
        }
        public void Deposit(decimal depositAmount, string date)
        {
            if (depositAmount > 0.0m)
            {
                Balance += depositAmount;
                this.opertaions.Add(new Operations(depositAmount, date, "Deposit"));
            }
        }
        public void Withdrawal(decimal withdrawAmount, string date)
        {
            if (Balance > 0 && Balance - withdrawAmount >= 0.0m)
            {
                Balance -= withdrawAmount;
                this.opertaions.Add(new Operations(withdrawAmount, date, "Withdraw"));
            }
        }
        public void printStatemnt()
        {
            Console.WriteLine($"Client :{name}");
            Console.WriteLine("Amout || Date || Type ");

            foreach (var operation in opertaions)
            {
                Console.WriteLine("{0} || {1} || {2}", operation.amount, operation.date, operation.type);
            }
        }
    }
        struct Operations
        {
            public decimal amount;
            public string date;
            public string type;
            public Operations(decimal amount, string date, string type)
            {
                this.amount = amount;
                this.date = date;
                this.type = type;
            }
        }

    
}

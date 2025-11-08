using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Account
    {
       
        public int AccountNumber { get; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

       
        public Account() : this(0, "Unknown", 0.0) { }

        
        public Account(int number, string owner) : this(number, owner, 0.0) { }

      
        public Account(int number, string owner, double balance)
        {
            AccountNumber = number;
            OwnerName = owner;
            Balance = balance >= 0 ? balance : 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0) Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance) Balance -= amount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account #{AccountNumber}, Owner: {OwnerName}, Balance: ${Balance:F2}");
        }
    }
}
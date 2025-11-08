using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_GPT
{
    public class Account
    {
        public int AccountNumber { get; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        public Account()
        {
            AccountNumber = 0;
            OwnerName = "Unknown Owner";
            Balance = 0.0;
        }

        public Account(int number, string owner) : this()
        {
            AccountNumber = number;
            OwnerName = string.IsNullOrWhiteSpace(owner) ? "Unknown Owner" : owner;
            Balance = 0.0;
        }

        public Account(int number, string owner, double balance) : this(number, owner)
        {
            Balance = balance < 0 ? 0.0 : balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Deposit failed: amount must be positive. Attempted deposit: {amount}");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C2} to account #{AccountNumber}. New balance: {Balance:C2}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Withdraw failed: amount must be positive. Attempted withdraw: {amount}");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"Withdraw failed: insufficient funds. Attempted withdraw: {amount:C2}, available: {Balance:C2}");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C2} from account #{AccountNumber}. New balance: {Balance:C2}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account #{AccountNumber} | Owner: {OwnerName} | Balance: {Balance:C2}");
        }
    }
}
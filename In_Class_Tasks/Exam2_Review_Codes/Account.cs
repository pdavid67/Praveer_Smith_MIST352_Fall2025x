using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Review_Codes
{
    internal class Account
    {
        // Fields
        private int id;
        private string type = "Not Provided";
        private readonly DateTime openDate;
        private Customer customer;
        private double balance;
        private bool isClosed;

        // Properties
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Type
        {
            get => type;
            set => type = value ?? type;
        }

       
        // Constructors 
        public Account(int id)
        {
            openDate = DateTime.Now;
            this.id = id;
        }

        public Account(int id, string type) : this(id)
        {
            this.type = type ?? this.type;
        }

        public Account(Customer customer)
        {
            openDate = DateTime.Now;
            this.customer = customer;
        }

        // Methods
        public void Deposit(double amount)
        {
            balance = amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}.");
        }

        public void Withdraw(double amount)
        {
            balance = amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}.");
        }

     
        

        public override string ToString()
        {
            var cust = customer != null ? $"{customer.Name} (Id {customer.CustomerId})" : "No customer";
            return $"Account Id: {id}, Type: {type}, OpenDate: {openDate}, Balance: {balance:C}";
        }
    }
}

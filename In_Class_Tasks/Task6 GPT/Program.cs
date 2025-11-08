using System;

/*
Promt:Task 6 Car Employee Account Classes

Requirements

1. Create a new In Class Task named Task6

2. Build three classes

Car Class
Default constructor sets generic make model and year
Car string make string model sets current year automatically
Car string make string model int year validates year
DisplayInfo prints the make model and year

Employee Class
Default constructor sets New Hire and default pay values
Employee string name sets the employees name and default hourly pay
Employee string name double rate int hours validates pay and hours
DisplaySummary prints the employees name and yearly salary

Account Class
Default constructor sets unknown owner and zero balance
Account int number string owner balance starts at zero
Account int number string owner double balance validates balance
Deposit adds amount to balance
Withdraw deducts amount if funds are available no overdraft
DisplayInfo prints account number owner and balance

3. In Main
Create three car objects three employee objects and three account objects
Call DisplayInfo or DisplaySummary to show the information on screen
*/
namespace Task6_GPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Cars =====\n");

            Car c1 = new Car(); // default
            Car c2 = new Car("Toyota", "Corolla"); // uses current year
            Car c3 = new Car("Ford", "Mustang", 1967); // specific year (validated)

            c1.DisplayInfo();
            c2.DisplayInfo();
            c3.DisplayInfo();

            Console.WriteLine("\n===== Employees =====\n");

            Employee e1 = new Employee(); // default
            Employee e2 = new Employee("Ava Martinez"); // name only
            Employee e3 = new Employee("Sam Patel", 22.50, 40); // full data

            e1.DisplaySummary();
            e2.DisplaySummary();
            e3.DisplaySummary();

            Console.WriteLine("\n===== Accounts =====\n");

            Account a1 = new Account(); // default
            Account a2 = new Account(1001, "Jordan Lee"); // starts at 0
            Account a3 = new Account(2002, "Maya Nguyen", 1500.75); // full details

            a1.DisplayInfo();
            a2.DisplayInfo();
            a3.DisplayInfo();

            Console.WriteLine("\n-- Transactions on account #2002 --");
            a3.Deposit(250);
            a3.Withdraw(100);
            a3.Withdraw(5000); // should fail - insufficient funds
            a3.DisplayInfo();

            Console.WriteLine("\nDone.");
        }
    }
}
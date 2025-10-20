// ===================================================
// MIST 352 — In-Class Activity 5
// Tip & Tax Splitter Pro
// Praveer Smith
// ---------------------------------------------------
// This program totals a restaurant bill, adds tax and tip,
// and splits the total between a group of people.
// You will complete 3 methods to make it work.
// ===================================================
using System;

namespace TipTaxSplitterPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // beggining title
            Console.WriteLine("=== Tip & Tax Splitter Pro ===");
            Console.WriteLine();

            
            ShowMenu();

            
            double[] arrItems = { 12.50, 9.00, 15.99, 4.25, 7.75, 10.50 };
            int intCount = arrItems.Length;

            // this gets user inputs
            Console.Write("Tax rate (decimal, e.g., 0.07): ");
            double tax = double.Parse(Console.ReadLine());

            Console.Write("Tip rate (decimal, e.g., 0.18): ");
            double tip = double.Parse(Console.ReadLine());

            Console.Write("How many people? ");
            int people = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // subtotal
            double subtotal = ComputeSubtotal(arrItems, intCount);
            Console.WriteLine("[SUBTOTAL] " + subtotal.ToString("0.00"));

            // add tax
            double withTax = subtotal * (1 + tax);
            Console.WriteLine("[WITH_TAX] " + withTax.ToString("0.00"));

            // add tip
            ApplyTip(ref withTax, tip);
            Console.WriteLine("[WITH_TAX_TIP] " + withTax.ToString("0.00"));

            // divide by number of people
            double perHead = PerPerson(withTax, people);
            Console.WriteLine("[PER_PERSON] " + perHead.ToString("0.00"));

            Console.WriteLine("=== Done ===");
        }

        // this just shows instructions
        static void ShowMenu()
        {
            Console.WriteLine("We'll total a fixed order, add tax, add tip, and split the bill.");
            Console.WriteLine("Enter tax/tip as decimals (e.g., 0.07 = 7%, 0.18 = 18%).");
            Console.WriteLine("Finally, we divide by the number of people.");
            Console.WriteLine();
        }

        // made this to add up all prices in the array
        static double ComputeSubtotal(double[] arr, int count)
        {
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total = total + arr[i];
            }
            return total;
        }

        // This adds tip to the total
        static void ApplyTip(ref double amountWithTax, double tipRate)
        {
            amountWithTax = amountWithTax * (1 + tipRate);
        }

        // This splits total between everyone
        static double PerPerson(double grandTotal, int people)
        {
            if (people <= 0)
            {
                people = 1;
            }
            double each = grandTotal / people;
            return each;
        }
    }
}
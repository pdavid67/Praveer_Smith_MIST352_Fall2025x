/*
 * Author: Praveer Smith
 * Task 4
 * 10/3/2025
 * This program defines an array and calls 3 methods to help it with numbers (PrintArray, FindAverage, SearchNumber)
 */




namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here I define an array of at least 6 integers
            int[] intArray = { 10, 5, 15, 20, 8, 12 };

            //Then I call PrintArray
            PrintArray(intArray);

            //Here I call FindAverage and store the result
            double dblAverage = FindAverage(intArray);
            Console.WriteLine($"The average is: {dblAverage:F2}");

            //Then I ask the user for a number to search
            Console.Write("Enter a number to search: ");
            int intTarget = Convert.ToInt32(Console.ReadLine());

            //Here I call SearchNumber
            SearchNumber(intArray, intTarget);
        }
        // Made method PrintArray to print everything in array
        static void PrintArray(int[] intArray)
        {
            Console.Write("Array elements: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();
        }
        // Made method FindAverage to find the average of the numbers
        static double FindAverage(int[] intArray)
        {
            double dblSum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                dblSum += intArray[i];
            }
            return dblSum / intArray.Length;
        }


        // Made method SearchNumber to look for a number in the array
        static void SearchNumber(int[] intArray, int intTarget)
        {
            bool found = false;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == intTarget)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{intTarget} was found in the array!");
            else
                Console.WriteLine($"{intTarget} was NOT found in the array.");
        }
    }
}

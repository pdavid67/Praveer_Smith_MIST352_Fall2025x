/*
 * Tuesday 9/16/25
 * Simple program to evaluate and printout the letter grade of a given grade
 */



using System.ComponentModel.Design;

namespace If_Simple_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a grade");
            double dblgrade = Double.Parse(Console.ReadLine());
            if (dblgrade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (dblgrade >= 80) 
            {
                Console.WriteLine("B");
            }
            else if (dblgrade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (dblgrade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (dblgrade >= 50)
            {
                Console.WriteLine("F");
            }

        }
        }
    }

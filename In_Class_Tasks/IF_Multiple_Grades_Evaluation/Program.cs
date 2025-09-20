/*
 * Ask user for multiple grades, then evaluate and summerize
 */




using System.Diagnostics.CodeAnalysis;

namespace IF_Multiple_Grades_Evaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many grades would you like to evaulate and summarize today?");
           //accept number of grades
            int intNoGrades = Convert.ToInt32(Console.ReadLine());
            int intAs = 0, intBs = 0, intCs = 0, intDs = 0, intFs = 0;
            //create and array to hold grades
            double[] dblGrades = new double[intNoGrades];
            char[] chrLetterGrades = new char[intNoGrades];
            //for loop to interact with the array. Fill it up with grades form the user
            for (int intIndex = 0; intIndex < dblGrades.Length; intIndex++)
            {
                //accept one grade and add it to the current element in the array
                Console.WriteLine($"Give me a grade{intIndex + 1}");
                dblGrades[intIndex] = Convert.ToDouble(Console.ReadLine());
            }
             //an other for loop to evaluate and store in an other array
            //increment the variable that track the number of each letter grade by one when seen
            for (int intIndex = 0; intIndex < dblGrades.Length; intIndex++)
            {
                if (dblGrades[intIndex] >= 90)
                {
                    chrLetterGrades[intIndex] = 'A';
                    intAs++;
                }

                    
                else if (dblGrades[intIndex] >= 80)
                {
                    chrLetterGrades[intIndex] = 'B';
                    intBs++;
                }
                   
                else if (dblGrades[intIndex] >= 70)
                {
                    chrLetterGrades[intIndex] = 'C';
                    intCs++;
                }
                    
                else if (dblGrades[intIndex] >= 60)
                {
                    chrLetterGrades[intIndex] = 'D';
                    intDs++;
                }
                    
                else
                    chrLetterGrades[intIndex] = 'F';
                intFs++;
                


            }


        }
        Console.WriteLine($"8)
    }
}

namespace InClassExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strName = "Praveer Smith";
            double dblGrade1 = 50, dblgrade2 = 90, dblgrade3 = 63, dblGrade4 = 80, dblGrade5 = 70, dblAvg = 0;
            dblAvg = (dblGrade1 + dblgrade2 + dblgrade3 + dblGrade4 + dblGrade5) / 5;
            Console.WriteLine($"Hello {strName}, your average is {dblAvg}");

            //defining array of double to store grades
            //double[] dblgrades = new double[5];
            //dblgrades[0] = 50;
            //dblgrades[1] = 90;
            //dblgrades[2] = 63;
            //dblgrades[3] = 80;
            //dblgrades[4] = 70;
            //define an array of double to store the grades
            double[] dblGradesFancy = { 50, 90, 63, 80, 70, 90, 99 };
            String[] strAssesments = { "Task1", "HW1", "Task2", "Quiz1", "Exam1", "HW2" };
            Console.WriteLine($"{dblGradesFancy[0]} - {dblGradesFancy[1]} - {dblGradesFancy[2]} - {dblGradesFancy[3]} - {dblGradesFancy[4]}");
            //calculating the avg manualy
            dblAvg = (dblGradesFancy[0] + dblGradesFancy[1] + dblGradesFancy[2] + dblGradesFancy[3] + dblGradesFancy[4] / 5);
            Console.WriteLine($"Hello {strName}, your average is {dblAvg}");

            //for loop to interact with arrays
            for (int intIndex = 0; intIndex < dblGradesFancy.Length; intIndex++)

            {
               dblSum = dbl
                //Console.WriteLine(dblGradesFancy[intIndex]);
                //Console.WriteLine($"{strAssesments[intIndex]}==={dblGradesFancy[intIndex]}");



            }
            
        }
    }
}

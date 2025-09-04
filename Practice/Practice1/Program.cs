//Praveer Smith
//Practice1
//Thrusday 8/28/25

/*
 * *Author: Praveer Smith
 * *Practice 1
 * Purpose: Functionality 1 => defined variables and process them to calculate areas of circles
 */

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== This is functionaity 1=============");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("The area of a circle with radius 1 is 3.14");
            //a variable to hold the radius
            double theRadius = 15.5;

            //an other variable to hold the area
            double theArea = (theRadius * theRadius) * 3.14;
            //Print out the info in diffrent ways.
            Console.WriteLine("The circle with a radius of " + theRadius + " is " + theArea);
            Console.WriteLine("The circle with a radius of {0} is {1}", theRadius, theArea);
            Console.WriteLine($"The circle with a radius of {theRadius} is {theArea}");


            Console.WriteLine("=============================================");
        }
    }
}

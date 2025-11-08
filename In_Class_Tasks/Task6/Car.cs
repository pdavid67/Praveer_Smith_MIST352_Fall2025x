using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task6
{
    class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        
        public Car() : this("Generic", "Car", DateTime.Now.Year) { }

       
        public Car(string make, string model) : this(make, model, DateTime.Now.Year) { }

        
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = (year >= 1886 && year <= DateTime.Now.Year) ? year : DateTime.Now.Year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model}, Year: {Year}");
        }
    }
}
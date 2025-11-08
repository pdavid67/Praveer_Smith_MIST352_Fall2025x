using System;

namespace Task6_GPT
{
    public class Car
    {
        private const int EarliestValidYear = 1886;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Make = "Generic";
            Model = "Model";
            Year = DateTime.Now.Year;
        }

        public Car(string make, string model) : this()
        {
            Make = string.IsNullOrWhiteSpace(make) ? "Unknown" : make;
            Model = string.IsNullOrWhiteSpace(model) ? "Unknown" : model;
            Year = DateTime.Now.Year;
        }

        public Car(string make, string model, int year)
        {
            Make = string.IsNullOrWhiteSpace(make) ? "Unknown" : make;
            Model = string.IsNullOrWhiteSpace(model) ? "Unknown" : model;

            int currentYear = DateTime.Now.Year;
            Year = (year < EarliestValidYear || year > currentYear) ? currentYear : year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model} ({Year})");
        }
    }
}

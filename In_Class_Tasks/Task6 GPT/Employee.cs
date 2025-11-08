using System;

namespace Task6_GPT
{
    public class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Employee()
        {
            Name = "Unknown Employee";
            HourlyRate = 15.00;
            HoursWorked = 0;
        }

        public Employee(string name) : this()
        {
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown Employee" : name;
        }

        public Employee(string name, double hourlyRate, int hoursWorked)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown Employee" : name;
            HourlyRate = hourlyRate < 0 ? 0.0 : hourlyRate;
            HoursWorked = hoursWorked < 0 ? 0 : hoursWorked;
        }

        public void DisplaySummary()
        {
            double pay = HourlyRate * HoursWorked;
            Console.WriteLine($"Employee: {Name} | Rate: {HourlyRate:C2} | Hours: {HoursWorked} | Pay: {pay:C2}");
        }
    }
}

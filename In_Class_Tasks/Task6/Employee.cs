using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Employee
    {
        
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursPerWeek { get; set; }

        public double AnnualSalary => HourlyRate * HoursPerWeek * 52;

        
        public Employee() : this("New Hire", 15.0, 40) { }

        
        public Employee(string name) : this(name, 15.0, 40) { }

        
        public Employee(string name, double rate, int hours)
        {
            Name = name;
            HourlyRate = rate > 0 ? rate : 15.0;
            HoursPerWeek = (hours > 0 && hours <= 60) ? hours : 40;
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Employee: {Name}, Annual Salary: ${AnnualSalary:F2}");
        }
    }
}
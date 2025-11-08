namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car
            Console.WriteLine("================CAR================");
            Console.WriteLine("Enter Car Make: ");
            string carMake = Console.ReadLine();

            Console.WriteLine("Enter Car Model: ");
            string carModel = Console.ReadLine();

            Console.WriteLine("Enter Car Year: ");
            int carYear = int.Parse(Console.ReadLine());

            Car myCar = new Car(carMake, carModel, carYear);

            Console.WriteLine();
            myCar.DisplayInfo();
            Console.WriteLine("==============EMPLOYEE=============");


            //Employee

            Console.WriteLine("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Hourly Rate: ");
            double empRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter hours worked: ");
            int empHours = int.Parse(Console.ReadLine());

            Employee myEmployee = new Employee(empName, empRate, empHours);

            Console.WriteLine();
            Console.WriteLine("Employee: " + myEmployee.Name +
                              ", Yearly Salary: " + myEmployee.AnnualSalary.ToString("C2"));
            Console.WriteLine("==============ACCOUNT==============");


            //Account
            Console.WriteLine("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Account Owner: ");
            string accOwner = Console.ReadLine();

            Console.WriteLine("Enter Balance: ");
            double accBalance = double.Parse(Console.ReadLine());

            Account myAccount = new Account(accNum, accOwner, accBalance);

            Console.WriteLine();
            myAccount.DisplayInfo();
            Console.WriteLine("=================================");


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
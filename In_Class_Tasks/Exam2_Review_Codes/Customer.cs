using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Review_Codes
{
    internal class Customer
    {
        private int customerId;
        private string name = string.Empty;
        private string phone = string.Empty;
      

        public int CustomerId
        {
            get => customerId;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("CustomerId must be greater than 0.");
                }
                else
                {
                    customerId = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (value is null)
                {
                    Console.WriteLine("Name cannot be null.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Phone
        {
            get => phone;
            set => phone = value ?? string.Empty;
        }

        public override string ToString() => $"CustomerId: {CustomerId}, Name: {Name}, Phone: {Phone}";
    }
}

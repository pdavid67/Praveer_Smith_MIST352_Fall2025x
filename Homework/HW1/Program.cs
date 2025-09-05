/*Praveer Smith
 * MIST352-001-Fall2025
 * HW #1
 * Item database to store all their details*/




namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName1, productCategory1;
            int productSerial1, productQuantity1;
            double productPrice1;
            //added this console write line to help the user understand what product number their putting information in for
            Console.WriteLine("Enter information for product #1");
            
            Console.WriteLine("Enter product name:");
            productName1 = Console.ReadLine();

            Console.WriteLine("Enter product serial number (numbers only):");
            productSerial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product price:");
            productPrice1 = double.Parse(Console.ReadLine());
            //here I am letting the program know that productQuantity inputed is to be converted from a string to a numerical value
            Console.WriteLine("Enter product quantity:");
            productQuantity1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category:");
            productCategory1 = Console.ReadLine();
            //here I am letting the program know that it should capitalize the first charater of the string and make the rest lowercase 
            productName1 = char.ToUpper(productName1[0]) + productName1.Substring(1).ToLower();
            productCategory1 = char.ToUpper(productCategory1[0]) + productCategory1.Substring(1).ToLower();

            double totalPrice1 = productPrice1 * productQuantity1;
            
            string productName2, productCategory2;
            int productSerial2, productQuantity2;
            double productPrice2;

            Console.WriteLine("Enter information for product #2");

            Console.WriteLine("Enter product name:");
            productName2 = Console.ReadLine();

            Console.WriteLine("Enter product serial number (numbers only):");
            productSerial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product price:");
            productPrice2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product quantity:");
            productQuantity2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category:");
            productCategory2 = Console.ReadLine();

            productName2 = char.ToUpper(productName2[0]) + productName2.Substring(1).ToLower();
            productCategory2 = char.ToUpper(productCategory2[0]) + productCategory2.Substring(1).ToLower();

            double totalPrice2 = productPrice2 * productQuantity2;
            
            string productName3, productCategory3;
            int productSerial3, productQuantity3;
            double productPrice3;

            Console.WriteLine("Enter information for product #3");

            Console.WriteLine("Enter product name:");
            productName3 = Console.ReadLine();

            Console.WriteLine("Enter product serial number (numbers only):");
            productSerial3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product price:");
            productPrice3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product quantity:");
            productQuantity3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category:");
            productCategory3 = Console.ReadLine();

            productName3 = char.ToUpper(productName3[0]) + productName3.Substring(1).ToLower();
            productCategory3 = char.ToUpper(productCategory3[0]) + productCategory3.Substring(1).ToLower();

            double totalPrice3 = productPrice3 * productQuantity3;
            //have been getting null refrence on console read line and belive it may be the reason why equation is not calculating
            string productName4, productCategory4;
            int productSerial4, productQuantity4;
            double productPrice4;

            Console.WriteLine("Enter information for product #4");

            Console.WriteLine("Enter product name:");
            productName4 = Console.ReadLine();

            Console.WriteLine("Enter product serial number (numbers only):");
            productSerial4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product price:");
            productPrice4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product quantity:");
            productQuantity4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category:");
            productCategory4 = Console.ReadLine();

            productName4 = char.ToUpper(productName4[0]) + productName4.Substring(1).ToLower();
            productCategory4 = char.ToUpper(productName4[0]) + productName4.Substring(1).ToLower();

            double totalPrice4 = productPrice4 * productQuantity4;

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"|{"Name",-15}|{"Serial",-10}|{"Category",-12}|{"Price",8}|{"Qty",5}|{"Total",10}|");
            Console.WriteLine("-------------------------------------------------------------------");
            //is not calculating product price and quantiny and information is not showing up on table
            //realaized I needed to add more rows to my table for the information to show
            Console.WriteLine($"|{productName1,-15}|{productSerial1,-10}|{productCategory1,-12}|{productPrice1,8:F2}|{productQuantity1,5}|{totalPrice1,10:F2}|");
            Console.WriteLine($"|{productName2,-15}|{productSerial2,-10}|{productCategory2,-12}|{productPrice2,8:F2}|{productQuantity2,5}|{totalPrice2,10:F2}|");
            Console.WriteLine($"|{productName3,-15}|{productSerial3,-10}|{productCategory3,-12}|{productPrice3,8:F2}|{productQuantity3,5}|{totalPrice3,10:F2}|");
            Console.WriteLine($"|{productName4,-15}|{productSerial4,-10}|{productCategory4,-12}|{productPrice4,8:F2}|{productQuantity4,5}|{totalPrice4,10:F2}|");




        }
    }
}

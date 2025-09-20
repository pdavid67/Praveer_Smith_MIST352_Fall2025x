namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //added tax and discount rate
            double taxRate = 0.06;
            double discountRate = 0.05;
            //asking users quantiny of items in order
            Console.Write("How many items are in this order? ");
            int itemCount = int.Parse(Console.ReadLine());
            //declaring arrays
            string[] strNames = new string[itemCount];
            double[] dblPrices = new double[itemCount];
            double[] dblLineTotals = new double[itemCount];
            double[] dblLineDiscounts = new double[itemCount];
            double[] dblGross = new double[itemCount];
            int[] intQtys = new int[itemCount];
            int[] intStocks = new int[itemCount];
            bool[] boolReorder = new bool[itemCount];

            Console.WriteLine("\n=== Mini POS: Enter item details ===");
            //started for loop
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine("\nItem #" + (i + 1));
                
                Console.Write(" Enter product name: ");
                strNames[i] = Console.ReadLine();

                Console.Write(" Enter unit price (e.g., 12.50): ");
                double price;
               //made it so if the number inputed is not in the specific range then it would warn 
                if (double.TryParse(Console.ReadLine(), out price) || price < 0)
                {
                    Console.WriteLine(" [warn] Invalid price. Defaulting to 0.00");
                    price = 0;
                }
                dblPrices[i] = price;

                Console.Write(" Enter quantity (integer): ");
                int qty;
                if (int.TryParse(Console.ReadLine(), out qty) || qty < 0)
                {
                    Console.WriteLine(" [warn] Invalid quantity. Defaulting to 0");
                    qty = 0;
                }
                intQtys[i] = qty;

                Console.Write(" Enter stock on hand (integer): ");
                int stock;
                if (int.TryParse(Console.ReadLine(), out stock) || stock < 0)
                {
                    Console.WriteLine(" [warn] Invalid stock. Defaulting to 0");
                    stock = 0;
                }
                intStocks[i] = stock;

                dblGross[i] = dblPrices[i] * intQtys[i];
                //making sure that if quantinty is more than 10 then give it 5% discount
                if (intQtys[i] >= 10)
                {
                    dblLineDiscounts[i] = dblGross[i] * discountRate;
                }
                else
                {
                    dblLineDiscounts[i] = 0;
                }

                dblLineTotals[i] = dblGross[i] - dblLineDiscounts[i];
                //added reorder true or false with bool
                int postStock = intStocks[i] - intQtys[i];
                if (postStock < 5)
                {
                    boolReorder[i] = true;
                }
                else
                {
                    boolReorder[i] = false;
                }

                Console.WriteLine();
            }

            double subtotal = 0;
           //adding each items total 
            for (int i = 0; i < itemCount; i++)
            {
                subtotal += dblLineTotals[i];
            }

            double tax = subtotal * taxRate;
            double grand = subtotal + tax;
            //this prints ou the table and all of the calculations but had trouble figuring out how to aling the table until I came accross the command \t
            Console.WriteLine("=== Order Summary ===");
            Console.WriteLine("Name\tPrice\tQty\tGross\tDisc\tLineTotal\tReorder");
            Console.WriteLine("----------------------------------------------------------------");

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(
                    strNames[i] + "\t" +
                    dblPrices[i].ToString("0.00") + "\t" +
                    intQtys[i] + "\t" +
                    intStocks[i].ToString("0.00") + "\t" +
                    dblLineDiscounts[i].ToString("0.00") + "\t" +
                    dblLineTotals[i].ToString("0.00") + "\t\t" +
                    (boolReorder[i] ? "YES" : "NO")
                );
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Subtotal: " + subtotal.ToString("0.00"));
            Console.WriteLine("Tax (6%): " + tax.ToString("0.00"));
            Console.WriteLine("GRAND TOTAL: " + grand.ToString("0.00"));
            Console.ReadLine();

        }
    }



    

}
 
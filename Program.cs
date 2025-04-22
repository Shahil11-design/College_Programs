using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            // Keep The Loop Running Until The Choice Is y/Y
            do
            {
                // Create and Use Customer Object
                Customer customer = new Customer();

                // Input Customer Name
                Console.Write("Enter Customer Name: ");
                customer.Name = Console.ReadLine();
                //string customerName = Console.ReadLine();


                // Input Number Of Coffee Bags
                Console.Write("Enter Number Of Coffee Bags (1-200): ");
                customer.NumCoffeeBags = Int32.Parse(Console.ReadLine());

                // Keep Re-Entering Number Of Coffee Bags
                // If Until User Enters Invalid Value
                while (customer.NumCoffeeBags < 1 || customer.NumCoffeeBags > 200)
                {
                    Console.WriteLine("Value Must Be Between 1 And 200!");
                    Console.Write("Re-Enter Number Of Coffee Bags (1-200): ");
                    customer.NumCoffeeBags = Int32.Parse(Console.ReadLine());
                }

                // Input If The Customer Is A Reseller
                Console.Write("Is Customer A Reseller? (y/Y For Yes): ");
                string resellerStatus = Console.ReadLine().Trim().ToLower();
                choice = resellerStatus.Length > 0 ? resellerStatus[0] : 'n';
                customer.IsReseller = (choice == 'y');


                // ---- Compute Bill ----

                double totalCost = CalculateTotalCost(customer);

                // the commented code section below is the original code that to modified to the as Line 48, for calculating total bill.

                //double totalCost = 0.0;
                //if (numCoffeeBags < 6)
                //{
                //    totalCost += numCoffeeBags * 36;
                //}
                //else if (numCoffeeBags < 16)
                //{
                //    totalCost += numCoffeeBags * 34.5;
                //}
                //else
                //{
                //    totalCost += numCoffeeBags * 32.7;
                //}

                // Compute Discount
                double discount = 0.0;

                if (customer.IsReseller)
                {
                    discount = totalCost * 0.20;
                }


                // Print Bill
                Console.WriteLine();
                PrintBill(customer);

                //Console.WriteLine();
                //Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("------------------- BILL -------------------");
                //Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("Customer Name: {0}", customer.Name);
                //Console.WriteLine("Number Of Coffee Bags: {0}", customer.NumCoffeeBags);
                //Console.WriteLine("Total Cost Of Bags: {0:C}", totalCost);
                //Console.WriteLine("Discount: {0:C}", discount);
                //Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("Amount Payable: {0:C}", totalCost - discount);
                //Console.WriteLine("--------------------------------------------");



                // Input User Choice
                Console.Write("Input Y/y To Continue Or Any Other Key To Exit: ");

                // Get First Letter Of Choice
                string continueInput = Console.ReadLine().Trim().ToLower();
                choice = continueInput.Length > 0 ? continueInput[0] : 'n';
                Console.WriteLine();
            } while (choice == 'y');
        }

        // creating a separate method for total bill calculation
        static double CalculateTotalCost(Customer customer)
        {
            if (customer.NumCoffeeBags < 6)
                return customer.NumCoffeeBags * 36;
            else if (customer.NumCoffeeBags < 16)
                return customer.NumCoffeeBags * 34.5;
            else
                return customer.NumCoffeeBags * 32.7;
        }

        // Creating a separate class for printing the bill
        static void PrintBill(Customer customer)
        {
            double totalCost = CalculateTotalCost(customer);
            double discount = customer.IsReseller ? totalCost * 0.20 : 0.0;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------------- BILL -------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Customer Name: {0}", customer.Name);
            Console.WriteLine("Number Of Coffee Bags: {0}", customer.NumCoffeeBags);
            Console.WriteLine("Total Cost Of Bags: {0:C}", totalCost);
            Console.WriteLine("Discount: {0:C}", discount);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Amount Payable: {0:C}", totalCost - discount);
            Console.WriteLine("--------------------------------------------");
        }

    }


    // New Customer class added 
    class Customer
    {
        public string Name { get; set; }
        public int NumCoffeeBags { get; set; }
        public bool IsReseller { get; set; }
    }

        
}

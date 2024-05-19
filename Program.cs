using System;
namespace Asag
{
    internal class Program
    {
        static void InventoryReport()
        {
            Console.WriteLine("Printing current inventory");
            Product p1 = new Product { prod_description = "Milk", price = 110, quantity = 300 };
            Product p2 = new Product { prod_description = "Bread", price = 67, quantity = 110 };
            Product p3 = new Product { prod_description = "Citrus", price = 20, quantity = 500 };

            Console.WriteLine($"{p1.prod_description}-{p1.quantity}");
            Console.WriteLine($"{p2.prod_description}-{p2.quantity}");
            Console.WriteLine($"{p3.prod_description}-{p3.quantity}");
            Console.ReadKey();
        }

        static void SalesReport()
        {
            Console.WriteLine("Printing sales report");
            Console.ReadKey();
        }

        static void LineGeneration()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to HeavenEleven!");
                LineGeneration();

                Console.WriteLine("What would you like to do?");
                LineGeneration();

                Console.WriteLine("Select a number based on your need.");

                Console.WriteLine("1. Print current inventory");
                Console.WriteLine("2. Print sales report");
                Console.WriteLine("3. Exit HeavenEleven");

                string user_choice = Console.ReadLine();

                switch (user_choice)
                {
                    case "1":
                        InventoryReport();
                        break;

                    case "2":
                        SalesReport();
                        break;

                    case "3":
                        Console.WriteLine("Are you sure? 1 for Yes or 0 for No?");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.WriteLine("Thank you for using HeavenEleven!");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                        

                    default:
                        Console.WriteLine("Not an option. Please try again");
                        break;
                }


            }
        }   
    }
}

using System;
namespace Asag
{
    internal class Program
    {
        static void InventoryReport()
        {
            Console.WriteLine("Printing current inventory");
            Console.WriteLine("Here's the current inventory:");
            Product p1 = new Product { prod_description = "Milk", price = 110, quantity = 300 };
            Product p2 = new Product { prod_description = "Bread", price = 67, quantity = 110 };
            Product p3 = new Product { prod_description = "Citrus", price = 20, quantity = 500 };

            Console.WriteLine($"{p1.prod_description} - {p1.quantity}");
            Console.WriteLine($"{p2.prod_description} - {p2.quantity}");
            Console.WriteLine($"{p3.prod_description} - {p3.quantity}");
            Console.ReadKey();
        }

        static void SalesReport()
        {
            Console.WriteLine("Printing sales report");
            Customer c1 = new Customer { name = "Juan", total_purchase = 5000};
            Customer c2 = new Customer { name = "Pedro", total_purchase = 670 };
            Customer c3 = new Customer { name = "Clara", total_purchase = 2000 };

            Console.WriteLine($"{c1.name} - {c1.total_purchase}");
            Console.WriteLine($"{c2.name} - {c2.total_purchase}");
            Console.WriteLine($"{c3.name}  -  {c3.total_purchase}");
            Console.WriteLine($"Total sales this day: {c1.total_purchase + c2.total_purchase + c3.total_purchase}");
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

        static void secLineGenerator()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
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
                

                Console.WriteLine("Select a number based on your need.");
                secLineGenerator();

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
                        Console.WriteLine("Are you sure? Y for Yes or N for No?");
                        string choice = Console.ReadLine();

                        if (choice == "Y")
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


using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace EmployeeConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of customers.
            var customers = new List<Customer>();

            // Display the main menu.
            int option = 0;
            while (option != 3)
            {
                Console.Clear();
                Console.WriteLine("Employee Console Menu");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Create Customer");
                Console.WriteLine("----------------------");
                Console.WriteLine("2. View Customer Information");
                Console.WriteLine("----------------------");
                Console.WriteLine("3.Set overdrafts");
                Console.WriteLine("----------------------");
                Console.WriteLine("4. Save and Exit");
                Console.WriteLine("----------------------");
                Console.Write("Enter option: ");
             

                // Handle the user's menu choice.
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    // Create a new customer.
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Enter Salary: ");
                    string salary = Console.ReadLine();
                    Console.Write("Enter CustomerID: ");
                    string customerID = Console.ReadLine();
                    customers.Add(new Customer { Name = name, Email = email, Address = address, Salary = salary, CustomerID = customerID });
                }


                else if (option == 2)
                {
                    // View customer information.
                    Console.WriteLine("Customers:");
                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"Name    - {customer.Name}");
                        Console.WriteLine($"Email   - ({customer.Email})");
                        Console.WriteLine($"Address - {customer.Address}");
                        Console.WriteLine($"Salary  - {customer.Salary}");
                        Console.WriteLine($"CustomerID - {customer.CustomerID}");




                    }


                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }
            }

            // Save the customers to a JSON file.
            string json = JsonConvert.SerializeObject(customers);
            File.WriteAllText("CustomersData.json", json);
        }
    }



}
;

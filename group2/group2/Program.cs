using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace group2
{
    class Program
    {
        static void Main()
        {
            List<Accounts> accountsList = new List<Accounts>();
            Accounts example = new Accounts();
            example.name = "John Smith";
            example.age = 21;
            example.address = "10 Downing Street";
            example.salary = 30000;
            example.special = true;
            example.current = 230;
            accountsList.Add(example);
            
            bool mainLoop = true;
            bool employeeLoop = true;
            bool atmLoop = true;
            while (mainLoop = true)
            {
                Console.WriteLine("CHOOSE A WNDOW");
                Console.WriteLine("----------------");
                Console.WriteLine("(1) ATM WINDOW");
                Console.WriteLine("(2) EMPLOYEE WINDOW");
                Console.WriteLine("(Q) QUIT");
                Console.WriteLine();
                Console.Write("Input: ");

                string i = Console.ReadLine();
                if (i == "1")
                {
                    while (atmLoop == true)
                    {
                        
                        Console.WriteLine("ATM");
                        Console.WriteLine();
                        Console.WriteLine("(1) Balance");
                        Console.WriteLine("(2) Withdraw");
                        Console.WriteLine("(3) Deposit");
                        Console.WriteLine("(Q) QUIT");
                        Console.WriteLine();
                        Console.Write("Input: ");
                    }
                }
                else if (i == "2")
                {
                    while (employeeLoop == true)
                    {

                        //create accounts list (need to change this to locate accounts file)
                        Console.WriteLine("Emplayee Menu");
                        Console.WriteLine();
                        Console.WriteLine("CHOOSE AN OPTION");
                        Console.WriteLine("----------------");
                        Console.WriteLine("(1) Create an account");
                        Console.WriteLine("(2) View existing accounts");
                        Console.WriteLine("(Q) QUIT");
                        Console.WriteLine();
                        Console.Write("Input: ");
                        String option = Console.ReadLine();
                        switch (option.ToLower())
                        {
                            case "1":
                                Accounts customer = new Accounts();
                                createAccount(customer);
                                Console.WriteLine();
                                Console.Write("Do you want to save the account? : ");
                                string input = Console.ReadLine();
                                if ((input.ToLower() == "y") || (input.ToLower() == "yes"))
                                {
                                    accountsList.Add(customer);
                                    Accounts saveAccount = new Accounts
                                    {
                                        name = customer.name,
                                        age = customer.age,
                                        address = customer.address,
                                        salary = customer.salary,
                                        customerID = customer.customerID,
                                        current = customer.current,
                                        special = customer.special,
                                        savings = customer.savings,
                                        ISA = customer.ISA,
                                    };

                                    string jsonAccount = JsonSerializer.Serialize(accountsList);
                                    Console.WriteLine(jsonAccount);
                                    string fileName = "AccountData.json";
                                    File.WriteAllText(fileName, jsonAccount);
                                    Console.WriteLine();
                                    Console.WriteLine("ACCOUNT SAVED");
                                    Console.WriteLine();

                                }

                                // save to list
                                break;
                            case "2":
                                // locate accounts --> load onto list --> output list (foreach)
                                // once the accounts been located -- give option to add isa, savings or change the account to special
                                break;
                            case "q":
                                employeeLoop = false;
                                break;
                        }

                        //Functions

                        Accounts createAccount(Accounts account)
                        {
                            Console.WriteLine("CREATING ACCOUNT");
                            Console.WriteLine();
                            Console.Write("Enter Acount Holder's Name: ");   //name
                            account.name = Console.ReadLine();

                            Console.WriteLine();
                            Console.Write("Enter Acount Holder's Age: ");   //age
                            account.age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();
                            Console.Write("Enter Acount Holder's Address: ");   //address
                            account.address = Console.ReadLine();

                            Console.WriteLine();
                            Console.Write("Enter Acount Holder's Salary: ");   //salary
                            account.salary = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();
                            Console.Write("Enter Acount Holder's Customer ID: ");   //Customer ID
                            account.customerID = Console.ReadLine();

                            if (account.salary >= 30000) { account.special = true; }

                            return account;
                        }
                    }
                }
                else if (i.ToLower() == "q")
                {
                    mainLoop = false;
                }
                else
                {
                    Console.WriteLine("wrong input try again");
                }
            }  
        }
    }
}

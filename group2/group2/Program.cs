using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2
{
    class Program
    {
        static void Main()
        {
            bool loop = true;
            while (loop == true)
            {
                
                //create accounts list (need to change this to locate accounts file)
                Console.WriteLine("ATM");
                Console.WriteLine();
                Console.WriteLine("CHOOSE AN OPTION");
                Console.WriteLine("----------------");
                Console.WriteLine("(1) Create an account");
                Console.WriteLine("(2) View existing accounts");
                Console.WriteLine("(Q) To quit");
                String option = Console.ReadLine();
                switch(option.ToLower())
                {
                    case "1":
                        Accounts customer1 = new Accounts();
                        createAccount(customer1);
                        // save to list
                        break;
                    case "2":
                        // locate accounts --> load onto list --> output list (foreach)
                        // once the accounts been located -- give option to add isa, savings or change the account to special
                        break;
                    case "q":
                        loop = false;
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
                    account.age = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Enter Acount Holder's Address: ");   //address
                    account.address = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Enter Acount Holder's Salary: ");   //salary
                    account.salary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Enter Acount Holder's Customer ID: ");   //Customer ID
                    account.customerID = Console.ReadLine();

                    if (account.salary >= 30000) { account.spectial = true; }
                    
                    return account;
                }
            }
            
        }
    }
}

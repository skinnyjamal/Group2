using System;

public class OverdraftAccount
{
    private decimal balance;
    private decimal overdraftLimit;

    public OverdraftAccount(decimal initialBalance, decimal initialOverdraftLimit)
    {
        balance = initialBalance;
        overdraftLimit = initialOverdraftLimit;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance - amount >= -overdraftLimit)
        {
            balance -= amount;
        }
        else
        {
            throw new Exception("Cannot withdraw amount, it would exceed overdraft limit.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public decimal GetOverdraftLimit()
    {
        return overdraftLimit;
    }
}

public class Program
{
    public static void Main()
    {
        OverdraftAccount account = new OverdraftAccount(100, 50);

        while (true)
        {
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Your balance is ${account.GetBalance()}");
            }
            else if (choice == 2)
            {
                Console.Write("Enter amount to deposit: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.Deposit(amount);
                Console.WriteLine("Deposit successful");
            }
            else if (choice == 3)
            {
                Console.Write("Enter amount to withdraw: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                try
                {
                    account.Withdraw(amount);
                    Console.WriteLine("Withdrawal successful");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (choice == 4)
            {
                break;
            }
        }
    }
}
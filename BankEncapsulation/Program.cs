﻿namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Welcome to Driscoll Bank");
            Console.WriteLine("========================");
            while (true)
            {
                Console.WriteLine("\nPlease select an option");
                Console.WriteLine("1. deposit money");
                Console.WriteLine("2. Check balance");
                Console.WriteLine("3. Exit");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("invalid input. Please enter a valid option");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter the amount to deposit");
                        double amount;
                        if(double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("invalid input. Please enter a valid amount");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine("deposit successful");
                        break;


                    case 2:
                        Console.WriteLine($"Current balance: {account.GetBalance}");
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Driscoll Banking app");
                        return;
                    default:
                        Console.WriteLine("invalid option. Please enter a valid option");
                        break;

                }
            }
        }
    }
}

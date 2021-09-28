using System;
using BankyStuffLibrary;

namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Ryan", 10000M);
            Console.WriteLine($"Account created for {account.Owner}, with \n an initial balance of {account.Balance}");

            account.makeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
            account.makeDeposit(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);
            account.makeDeposit(5, DateTime.Now, "Coffee");
            account.makeWithdrawal(5, DateTime.Now, "Juice");
            account.makeWithdrawal(7, DateTime.Now, "Wine");
            account.makeWithdrawal(8, DateTime.Now, "Shot of Whiskey");

            Console.WriteLine(account.getAccountHistory());
        }
    }
}


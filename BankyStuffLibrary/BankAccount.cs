using System;
using System.Collections.Generic;
using System.Text;

namespace BankyStuffLibrary
{
    public class BankAccount
    {
        public int Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions { get; set; }

        public BankAccount(string name, decimal initialBalance)
        {

            this.Owner = name;
            this.Number = accountNumberSeed++;
            this.allTransactions = new List<Transaction>();
            makeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public void makeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void makeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string getAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (Transaction item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.AmountForHuman}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Assignment3_ATM_GUI
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public string AccountHolderName { get; set; }
        public List<string> Transactions { get; set; }

        public Account(int accountNumber, decimal initialBalance, decimal interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            Transactions = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited: {amount:C}");
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add($"Withdrew: {amount:C}");
                return true;
            }
            Transactions.Add($"Failed withdrawal attempt: {amount:C}");
            return false;
        }

        public void DisplayTransactions()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}

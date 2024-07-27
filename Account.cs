using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ATM_GUI
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }
        public double InterestRate { get; set; }
        public string AccountHolderName { get; set; }
        public List<string> Transactions { get; private set; }

        public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            Transactions = new List<string>();
            Transactions.Add($"Account created with initial balance: {initialBalance:C}");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited: {amount:C}");
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transactions.Add($"Withdrew: {amount:C}");
                return true;
            }
            else
            {
                Transactions.Add($"Failed withdrawal attempt of: {amount:C}");
                return false;
            }
        }

        public string GetBalance()
        {
            return $"Balance: {Balance:C}";
        }
    }

}

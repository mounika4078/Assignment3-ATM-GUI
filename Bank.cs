using System.Collections.Generic;

namespace Assignment3_ATM_GUI
{
    public class Bank
    {
        private List<Account> _accounts;

        public Bank()
        {
            _accounts = new List<Account>();
            // Create default accounts
            for (int i = 100; i < 110; i++)
            {
                _accounts.Add(new Account(i, 100, 0.03m, $"Default User {i}"));
            }
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account RetrieveAccount(int accountNumber)
        {
            return _accounts.Find(acc => acc.AccountNumber == accountNumber);
        }
    }
}

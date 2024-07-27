namespace Assignment3_ATM_GUI
{
    public class AtmApplication
    {
        private Bank _bank;
        private Account _selectedAccount;

        public AtmApplication()
        {
            _bank = new Bank();
        }

        public void CreateAccount(int accountNumber, decimal initialBalance, decimal interestRate, string accountHolderName)
        {
            Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
            _bank.AddAccount(newAccount);
        }

        public bool SelectAccount(int accountNumber)
        {
            _selectedAccount = _bank.RetrieveAccount(accountNumber);
            return _selectedAccount != null;
        }

        public decimal CheckBalance()
        {
            return _selectedAccount.Balance;
        }

        public void Deposit(decimal amount)
        {
            _selectedAccount.Deposit(amount);
        }

        public bool Withdraw(decimal amount)
        {
            return _selectedAccount.Withdraw(amount);
        }

        public void DisplayTransactions()
        {
            _selectedAccount.DisplayTransactions();
        }
    }
}

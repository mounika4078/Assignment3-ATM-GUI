using System;
using System.Windows;

namespace Assignment3_ATM_GUI
{
    public partial class MainWindow : Window
    {
        private AtmApplication _atmApp;

        public MainWindow()
        {
            InitializeComponent();
            _atmApp = new AtmApplication();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow createAccountWindow = new CreateAccountWindow(_atmApp);
            createAccountWindow.ShowDialog();
        }

        private void SelectAccountButton_Click(object sender, RoutedEventArgs e)
        {
            int accountNumber = int.Parse(AccountNumberTextBox.Text);
            if (_atmApp.SelectAccount(accountNumber))
            {
                AccountDetailsTextBlock.Text = $"Selected Account: {accountNumber}";
            }
            else
            {
                MessageBox.Show("Account not found!");
            }
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = decimal.Parse(AmountTextBox.Text);
            _atmApp.Deposit(amount);
            MessageBox.Show("Deposit successful!");
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = decimal.Parse(AmountTextBox.Text);
            if (_atmApp.Withdraw(amount))
            {
                MessageBox.Show("Withdrawal successful!");
            }
            else
            {
                MessageBox.Show("Insufficient funds!");
            }
        }

        private void CheckBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            decimal balance = _atmApp.CheckBalance();
            MessageBox.Show($"Current Balance: {balance:C}");
        }

        private void DisplayTransactionsButton_Click(object sender, RoutedEventArgs e)
        {
            _atmApp.DisplayTransactions();
        }
    }
}

using System;
using System.Windows;

namespace Assignment3_ATM_GUI
{
    public partial class CreateAccountWindow : Window
    {
        private AtmApplication _atmApp;

        public CreateAccountWindow(AtmApplication atmApp)
        {
            InitializeComponent();
            _atmApp = atmApp;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(AccountNumberTextBox.Text);
                decimal initialBalance = decimal.Parse(InitialBalanceTextBox.Text);
                decimal interestRate = decimal.Parse(InterestRateTextBox.Text);
                string accountHolderName = AccountHolderNameTextBox.Text;

                _atmApp.CreateAccount(accountNumber, initialBalance, interestRate, accountHolderName);
                MessageBox.Show("Account created successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
            }
        }
    }
}

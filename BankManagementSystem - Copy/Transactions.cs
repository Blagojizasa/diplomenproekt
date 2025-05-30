using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class Transactions : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private bool isDragging = false;
        private Point dragStartPoint;

        public Transactions()
        {
            InitializeComponent();
            balanceLabel.Text = "";
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            balanceTextBox.Focus();
        }

        private void Transactions_MouseDown(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { isDragging = true; dragStartPoint = new Point(e.X, e.Y); } }
        private void Transactions_MouseMove(object sender, MouseEventArgs e) { if (isDragging) { Point currentScreenPos = PointToScreen(e.Location); Location = new Point(currentScreenPos.X - this.dragStartPoint.X, currentScreenPos.Y - this.dragStartPoint.Y); } }
        private void Transactions_MouseUp(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { isDragging = false; } }

        private void closeButton_Click(object sender, EventArgs e) { this.Close(); }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAccountNumberInput(balanceTextBox, out int accountNum)) return;
            try
            {
                decimal balance = GetAccountBalance(accountNum);
                balanceLabel.Text = $"Balance: {balance:C2}";
            }
            catch (AccountNotFoundException anfex) { MessageBox.Show(anfex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); balanceLabel.Text = "N/A"; }
            catch (Exception ex) { MessageBox.Show($"Error checking balance: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); balanceLabel.Text = "Error"; }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (!ValidateTransactionInput(withdrawAccountTextBox, withdrawAmountTextBox, out int accountNum, out decimal amount)) return;

            try
            {
                if (WithdrawAmount(accountNum, amount))
                {
                    MessageBox.Show($"Successfully withdrew {amount:C2}", "Withdrawal Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (balanceTextBox.Text == accountNum.ToString()) checkButton_Click(sender, e);
                    ResetWithdrawFields();
                }
            }
            catch (AccountNotFoundException anfex) { MessageBox.Show(anfex.Message, "Withdrawal Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show($"Error processing withdrawal: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (!ValidateTransactionInput(depositAccountTextBox, depositAmountTextBox, out int accountNum, out decimal amount)) return;

            try
            {
                DepositAmount(accountNum, amount);
                MessageBox.Show($"Successfully deposited {amount:C2}", "Deposit Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (balanceTextBox.Text == accountNum.ToString()) checkButton_Click(sender, e);
                ResetDepositFields();
            }
            catch (AccountNotFoundException anfex) { MessageBox.Show(anfex.Message, "Deposit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show($"Error processing deposit: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAccountNumberInput(fromAccountTextBox, out int fromAccountNum, "Source")) return;
            if (!ValidateAccountNumberInput(toAccountTextBox, out int toAccountNum, "Destination")) return;
            if (!ValidateAmountInput(transferAmountTextBox, out decimal amount, "Transfer")) return;

            if (fromAccountNum == toAccountNum) { MessageBox.Show("Source and Destination accounts cannot be the same.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                if (TransferAmount(fromAccountNum, toAccountNum, amount))
                {
                    MessageBox.Show($"Successfully transferred {amount:C2} from Account {fromAccountNum} to Account {toAccountNum}", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (balanceTextBox.Text == fromAccountNum.ToString()) checkButton_Click(sender, e);
                    ResetTransferFields();
                }
            }
            catch (AccountNotFoundException anfex) { MessageBox.Show(anfex.Message, "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show($"Error processing transfer: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool ValidateAccountNumberInput(TextBox accTb, out int accountNum, string fieldName = "Account")
        { accountNum = 0; if (string.IsNullOrWhiteSpace(accTb.Text)) { MessageBox.Show($"Please enter {fieldName} Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); accTb.Focus(); return false; } if (!int.TryParse(accTb.Text, out accountNum)) { MessageBox.Show($"Invalid {fieldName} Number format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); accTb.Focus(); return false; } return true; }
        private bool ValidateAmountInput(TextBox amtTb, out decimal amount, string fieldName = "Amount")
        { amount = 0; if (string.IsNullOrWhiteSpace(amtTb.Text)) { MessageBox.Show($"Please enter {fieldName}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); amtTb.Focus(); return false; } if (!decimal.TryParse(amtTb.Text, out amount) || amount <= 0) { MessageBox.Show($"Invalid {fieldName}. Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); amtTb.Focus(); return false; } return true; }
        private bool ValidateTransactionInput(TextBox accTb, TextBox amtTb, out int accountNum, out decimal amount)
        {
            accountNum = 0;
            amount = 0;
            return ValidateAccountNumberInput(accTb, out accountNum) && ValidateAmountInput(amtTb, out amount);
        }
        private void ResetWithdrawFields() { withdrawAccountTextBox.Clear(); withdrawAmountTextBox.Clear(); }
        private void ResetDepositFields() { depositAccountTextBox.Clear(); depositAmountTextBox.Clear(); }
        private void ResetTransferFields() { fromAccountTextBox.Clear(); toAccountTextBox.Clear(); transferAmountTextBox.Clear(); }

        private decimal GetAccountBalance(int accountNum)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                string query = "SELECT ACBal FROM AccountTbl WHERE ACNum = @AcN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AcN", accountNum);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value) { return Convert.ToDecimal(result); }
                    else { throw new AccountNotFoundException($"Account Number {accountNum} not found."); }
                }
            }
        }

        private void DepositAmount(int accountNum, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string checkQuery = "SELECT COUNT(*) FROM AccountTbl WHERE ACNum = @AcN";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction))
                    { checkCmd.Parameters.AddWithValue("@AcN", accountNum); int exists = (int)checkCmd.ExecuteScalar(); if (exists == 0) throw new AccountNotFoundException($"Account Number {accountNum} not found for deposit."); }

                    string updateQuery = "UPDATE AccountTbl SET ACBal = ACBal + @Amt WHERE ACNum = @AcN";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                    { updateCmd.Parameters.AddWithValue("@Amt", amount); updateCmd.Parameters.AddWithValue("@AcN", accountNum); updateCmd.ExecuteNonQuery(); }

                    string logQuery = "INSERT INTO TransactionTbl (TName, TDate, [T Amt], TACNum) VALUES (@TName, @TDate, @TAmt, @TACNum)";
                    using (SqlCommand logCmd = new SqlCommand(logQuery, connection, transaction))
                    { logCmd.Parameters.AddWithValue("@TName", "Deposit"); logCmd.Parameters.AddWithValue("@TDate", DateTime.Now.Date); logCmd.Parameters.AddWithValue("@TAmt", (int)amount); logCmd.Parameters.AddWithValue("@TACNum", accountNum); logCmd.ExecuteNonQuery(); }

                    transaction.Commit();
                }
                catch (Exception) { transaction.Rollback(); throw; }
            }
        }

        private bool WithdrawAmount(int accountNum, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    decimal currentBalance = 0;
                    string balanceQuery = "SELECT ACBal FROM AccountTbl WHERE ACNum = @AcN";
                    using (SqlCommand balanceCmd = new SqlCommand(balanceQuery, connection, transaction))
                    { balanceCmd.Parameters.AddWithValue("@AcN", accountNum); object result = balanceCmd.ExecuteScalar(); if (result != null && result != DBNull.Value) { currentBalance = Convert.ToDecimal(result); } else { throw new AccountNotFoundException($"Account Number {accountNum} not found for withdrawal."); } }

                    if (currentBalance < amount) { MessageBox.Show("Insufficient funds for withdrawal.", "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning); transaction.Rollback(); return false; }

                    string updateQuery = "UPDATE AccountTbl SET ACBal = ACBal - @Amt WHERE ACNum = @AcN";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                    { updateCmd.Parameters.AddWithValue("@Amt", amount); updateCmd.Parameters.AddWithValue("@AcN", accountNum); updateCmd.ExecuteNonQuery(); }

                    string logQuery = "INSERT INTO TransactionTbl (TName, TDate, [T Amt], TACNum) VALUES (@TName, @TDate, @TAmt, @TACNum)";
                    using (SqlCommand logCmd = new SqlCommand(logQuery, connection, transaction))
                    { logCmd.Parameters.AddWithValue("@TName", "Withdrawal"); logCmd.Parameters.AddWithValue("@TDate", DateTime.Now.Date); logCmd.Parameters.AddWithValue("@TAmt", (int)amount); logCmd.Parameters.AddWithValue("@TACNum", accountNum); logCmd.ExecuteNonQuery(); }

                    transaction.Commit();
                    return true;
                }
                catch (Exception) { transaction.Rollback(); throw; }
            }
        }

        private bool TransferAmount(int fromAccountNum, int toAccountNum, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    decimal sourceBalance = 0;
                    string balanceQuery = "SELECT ACBal FROM AccountTbl WHERE ACNum = @AcN";
                    using (SqlCommand balanceCmd = new SqlCommand(balanceQuery, connection, transaction))
                    { balanceCmd.Parameters.AddWithValue("@AcN", fromAccountNum); object result = balanceCmd.ExecuteScalar(); if (result != null && result != DBNull.Value) { sourceBalance = Convert.ToDecimal(result); } else { throw new AccountNotFoundException($"Source Account Number {fromAccountNum} not found."); } }

                    string checkQuery = "SELECT COUNT(*) FROM AccountTbl WHERE ACNum = @AcN";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction))
                    { checkCmd.Parameters.AddWithValue("@AcN", toAccountNum); int exists = (int)checkCmd.ExecuteScalar(); if (exists == 0) { throw new AccountNotFoundException($"Destination Account Number {toAccountNum} not found."); } }

                    if (sourceBalance < amount) { MessageBox.Show("Insufficient funds in the source account.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning); transaction.Rollback(); return false; }

                    string withdrawQuery = "UPDATE AccountTbl SET ACBal = ACBal - @Amt WHERE ACNum = @SrcAcN";
                    using (SqlCommand withdrawCmd = new SqlCommand(withdrawQuery, connection, transaction))
                    { withdrawCmd.Parameters.AddWithValue("@Amt", amount); withdrawCmd.Parameters.AddWithValue("@SrcAcN", fromAccountNum); withdrawCmd.ExecuteNonQuery(); }

                    string depositQuery = "UPDATE AccountTbl SET ACBal = ACBal + @Amt WHERE ACNum = @DestAcN";
                    using (SqlCommand depositCmd = new SqlCommand(depositQuery, connection, transaction))
                    { depositCmd.Parameters.AddWithValue("@Amt", amount); depositCmd.Parameters.AddWithValue("@DestAcN", toAccountNum); depositCmd.ExecuteNonQuery(); }

                    string logQuery = "INSERT INTO TransactionTbl (TName, TDate, [T Amt], TACNum) VALUES (@TName, @TDate, @TAmt, @TACNum)";
                    using (SqlCommand logCmdOut = new SqlCommand(logQuery, connection, transaction))
                    { logCmdOut.Parameters.AddWithValue("@TName", "Transfer Out"); logCmdOut.Parameters.AddWithValue("@TDate", DateTime.Now.Date); logCmdOut.Parameters.AddWithValue("@TAmt", (int)amount); logCmdOut.Parameters.AddWithValue("@TACNum", fromAccountNum); logCmdOut.ExecuteNonQuery(); }
                    using (SqlCommand logCmdIn = new SqlCommand(logQuery, connection, transaction))
                    { logCmdIn.Parameters.AddWithValue("@TName", "Transfer In"); logCmdIn.Parameters.AddWithValue("@TDate", DateTime.Now.Date); logCmdIn.Parameters.AddWithValue("@TAmt", (int)amount); logCmdIn.Parameters.AddWithValue("@TACNum", toAccountNum); logCmdIn.ExecuteNonQuery(); }

                    transaction.Commit();
                    return true;
                }
                catch (Exception) { transaction.Rollback(); throw; }
            }
        }
    }

    public class AccountNotFoundException : Exception { public AccountNotFoundException(string message) : base(message) { } }
}
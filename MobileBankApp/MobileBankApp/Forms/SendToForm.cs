using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileBankApp.Forms
{
    public partial class SendToForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        Random rand = new Random();

        public SendToForm()
        {
            InitializeComponent();
        }

        private void SendToForm_Load(object sender, EventArgs e)
        {
            fromCardNumberTextBox.Text = DataStorage.CardNumber;
            toCardNumberTextBox.Text = DataStorage.BankCard;
        }

        private void sendToCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            double dollar = 70.84;
            double euro = 80.38;

            var cardNumber = fromCardNumberTextBox.Text; //textBoxCard
            var cardCvv = fromCardCvvTextBox.Text; //textBoxCvv
            var cardDate = fromCardValidTextBox.Text; //textBoxCardTo
            var toCard = toCardNumberTextBox.Text; //destination
            double amount = Convert.ToDouble(amountTextBox.Text);
            var cardCurrency = "";
            var cardCurrency2 = "";
            var cardCvvCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;

            string queryCheckCard = $"SELECT BankCardCvvCode, CONCAT(FORMAT(BankCardDate, '%M'), '/', FORMAT(BankCardDate, '%y')), BankCardBalance, BankCardCurrency FROM BankCard WHERE BankCardNumber = '{cardNumber}'";
            SqlCommand commandCheckFromCard = new SqlCommand(queryCheckCard, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = commandCheckFromCard.ExecuteReader();

            while (reader.Read())
            {
                cardCvvCheck = reader[0].ToString();
                cardDateCheck = reader[1].ToString();
                cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                cardCurrency = reader[3].ToString();
            }
            reader.Close();

            if (cardCvv != cardCvvCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введен CVV-код", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardDateCheck != cardDate)
            {
                MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            string queryCheckToCardNumber = $"SELECT IdBankCard, BankCardCurrency FROM BankCard WHERE BankCardNumber = '{toCard}'";
            SqlCommand commandCheckToCardNumber = new SqlCommand(queryCheckToCardNumber, database.GetConnection());
            adapter.SelectCommand = commandCheckToCardNumber;
            adapter.Fill(table);
            SqlDataReader reader1 = commandCheckToCardNumber.ExecuteReader();
            while (reader1.Read())
            {
                cardCurrency2 = reader1[1].ToString();
            }
            reader1.Close();

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка. Некорректно введен номер карты получателя", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (Convert.ToDouble(amount)<1.00)
            {
                MessageBox.Show("Ошибка. Минимальная сумма перевода 1.00 RUB", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardNumber == toCard)
            {
                MessageBox.Show("Ошибка. Вы не можете перевести деньги на свою же карту", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (amount > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. У вас недостаточно средств", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (error == false)
            {
                DataStorage.BankCard = fromCardNumberTextBox.Text;
                Validation validation = new Validation();
                validation.ShowDialog();

                if (DataStorage.Attempts > 0)
                {
                    DateTime transactionDate = DateTime.Now;
                    var transactionNumber = "P";
                    for (int i = 0; i < 10; i++)
                    {
                        transactionNumber += Convert.ToString(rand.Next(0, 10));
                    }

                    var queryTransaction1 = $"";
                    var queryTransaction2 = $"";

                    if (cardCurrency == "RUB" && cardCurrency2 == "USD")
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount/=dollar}' WHERE BankCardNumber = '{toCard}'";

                    }

                    else if (cardCurrency == "RUB" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount /= euro}' WHERE BankCardNumber = '{toCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount *= dollar}' WHERE BankCardNumber = '{toCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount *= 0.96}' WHERE BankCardNumber = '{toCard}'";
                    }
                    else if (cardCurrency == "EUR" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount *= euro}' WHERE BankCardNumber = '{toCard}'";
                    }
                    else
                    {
                        queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance + '{amount}' WHERE BankCardNumber = '{toCard}'";
                    }

                    var queryTransaction3 = $"INSERT INTO Transactions(TransactionType, TransactionDestination, TransactionDate, TransactionNumber, TransactionValue, IdBankCard) VALUES( N'Перевод', '{toCard}', '{transactionDate}', '{transactionNumber}', '{amount}', (SELECT IdBankCard FROM BankCard WHERE BankCardNumber = {cardNumber}))";

                    var command1 = new SqlCommand(queryTransaction1, database.GetConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.GetConnection());
                    var command3 = new SqlCommand(queryTransaction3, database.GetConnection());
                    database.OpenConnection();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    database.CloseConnection();

                    Close();
                }
            }
        }
    }
}

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
using System.Text.RegularExpressions;

namespace MobileBankApp.Forms
{
    public partial class CommunalPaymets : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        Random rand = new Random();

        public CommunalPaymets()
        {
            InitializeComponent();
        }

        private void CommunalPaymets_Load(object sender, EventArgs e)
        {
            fromCardNumberTextBox.Text = DataStorage.CardNumber;

            var queryChooseOperator = $"SELECT IdService, ServiceName FROM ClientServices WHERE ServiceType = 'Communal/Internet'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.GetConnection());
            database.OpenConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            operatorComboBox.DataSource = operators;
            operatorComboBox.ValueMember = "IdService";
            operatorComboBox.DisplayMember = "ServiceName";
            database.CloseConnection();

        }


        private void topUpButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string caption = "Окно";

            var accountNumber = numberTextBox.Text; //destination
            var cardNumber = fromCardNumberTextBox.Text; //textBoxCard
            var cardCvv = fromCardCvvTextBox.Text; //textBoxCvv
            var cardDate = fromCardValidTextBox.Text; //textBoxCardTo
            double amount = Convert.ToDouble(amountTextBox.Text);
            var cardCvvCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";


            if (!Regex.IsMatch(numberTextBox.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("Пожалуйста укажите номер счета. Он должен состоять из 10 цифр. ", caption, btn, icon);
                numberTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(operatorComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста укажите вид услуги", caption, btn, icon);
                operatorComboBox.Select();
                return;
            }

            string queryCheckCard = $"SELECT BankCardCvvCode, CONCAT(FORMAT(BankCardDate, '%M'), '/', FORMAT(BankCardDate, '%y')), BankCardBalance, BankCardCurrency FROM BankCard WHERE BankCardNumber = '{cardNumber}'";
            SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = commandCheckCard.ExecuteReader();

            while (reader.Read())
            {
                cardCvvCheck = reader[0].ToString();
                cardDateCheck = reader[1].ToString();
                cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                cardCurrency = reader[3].ToString();
            }
            reader.Close();


            if (cardCurrency != "RUB")
            {
                MessageBox.Show("Для пополнения мобильного выберите рублевую карту", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }


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

                    var queryTransaction1 = $"UPDATE BankCard SET BankCardBalance = BankCardBalance - '{amount}' WHERE BankCardNumber = '{cardNumber}'";
                    var queryTransaction2 = $"INSERT INTO Transactions(TransactionType, TransactionDestination, TransactionDate, TransactionNumber, TransactionValue, IdBankCard) VALUES(N'Оплата коммунальных услуг', '{operatorComboBox.GetItemText(operatorComboBox.SelectedItem)}', '{transactionDate}', '{transactionNumber}', '{amount}', (SELECT IdBankCard FROM BankCard WHERE BankCardNumber = '{cardNumber}'))";
                    var queryTransaction3 = $"UPDATE ClientServices SET ServiceBalance = ServiceBalance + '{amount}' WHERE ServiceName = '{operatorComboBox.GetItemText(operatorComboBox.SelectedItem)}' AND ServiceType = 'Communal/Internet'";

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


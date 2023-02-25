using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MobileBankApp.Forms
{
    public partial class PhoneForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        
        public PhoneForm()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            numberTextBox.Text = DataStorage.PhoneNumber;
            fromCardNumberTextBox.Text = DataStorage.CardNumber;

            var queryChooseOperator = $"SELECT IdService, ServiceName FROM ClientServices WHERE ServiceType = 'Mobile'";
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

            
            if (!Regex.IsMatch(numberTextBox.Text, "^[+][7][0-9]{7,14}$"))
            {
                MessageBox.Show("Пожалуйста укажите ваш номер телефона в формате +70001234567 ", caption, btn, icon);
                numberTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(operatorComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста укажите оператора связи", caption, btn, icon);
                operatorComboBox.Select();
                return;
            }


            var phoneNumber = numberTextBox.Text; //destination
            var cardNumber = fromCardNumberTextBox.Text; //textBoxCard
            var cardCvv = fromCardCvvTextBox.Text; //textBoxCvv
            var cardDate = fromCardValidTextBox.Text; //textBoxCardTo
            double amount = Convert.ToDouble(amountTextBox.Text);
            var cardCvvCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";

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
                    var queryTransaction2 = $"INSERT INTO Transactions(TransactionType, TransactionDestination, TransactionDate, TransactionNumber, TransactionValue, IdBankCard) VALUES(N'Пополнение мобильного', '{phoneNumber}', '{transactionDate}', '{transactionNumber}', '{amount}', (SELECT IdBankCard FROM BankCard WHERE BankCardNumber = '{cardNumber}'))";
                    var queryTransaction3 = $"UPDATE ClientServices SET ServiceBalance = ServiceBalance + '{amount}' WHERE ServiceName = '{operatorComboBox.GetItemText(operatorComboBox.SelectedItem)}' AND ServiceType = 'Mobile'";

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

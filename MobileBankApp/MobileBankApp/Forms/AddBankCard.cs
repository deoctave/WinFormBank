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

namespace MobileBankApp
{
    public partial class AddBankCard : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();



        public AddBankCard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBankCard_Load(object sender, EventArgs e)
        {

        }

        private void addCardCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            var cardType = cardTypeComboBox.GetItemText(cardTypeComboBox.SelectedItem);
            var currency = currencyComboBox.GetItemText(currencyComboBox.SelectedItem);
            var paymentSystem = paymentSystemComboBox.GetItemText(paymentSystemComboBox.SelectedItem);
            var cardNumber = "";
            var pinCode = pinCodeNumericUpDown.Value;
            var cvvCode = "";
            bool isCardFree = false;
            DateTime dateTime = DateTime.Now;
            var cardDate = 2027;
           

            for (int i = 0; i < 3; i++)
            {
                cvvCode += Convert.ToString(rand.Next(0, 10));
            }

            do
            {
                if (paymentSystem == "Visa")
                {
                    cardNumber += "4";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }
                else
                {
                    cardNumber += "5";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }

                var queryChekCardNumber = $"SELECT * FROM BankCard WHERE BankCardNumber = '{cardNumber}'";

                SqlCommand command = new SqlCommand(queryChekCardNumber, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                    isCardFree = true;

            } while (isCardFree == false);

            var queryAddNewCard = $"INSERT INTO BankCard(BankCardType, BankCardNumber, BankCardCvvCode, BankCardCurrency, BankCardPaymentSystem, BankCardDate, IdClient, BankCardPin) VALUES ('{cardType}','{cardNumber}','{cvvCode}','{currency}','{paymentSystem}','{cardDate}', '{DataStorage.IdClient}', '{pinCode}')";
            SqlCommand commandAddNewCard = new SqlCommand(queryAddNewCard, database.GetConnection());
            database.OpenConnection();
            commandAddNewCard.ExecuteNonQuery();
            database.CloseConnection();

            MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}

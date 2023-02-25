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
using MobileBankApp.Forms;
using System.Net.Http.Headers;

namespace MobileBankApp
{
    public partial class MainForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();


        public MainForm()
        {
            InitializeComponent();
        }

        private void mainCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cardNumberLabel.BringToFront();
            cardNumberLabel.Text = "";
            currencyLabel.BringToFront();
            cardBalanceLabel.BringToFront();
            label4.BringToFront();
            validThruLabel.BringToFront();
            label5.BringToFront();
            cvvLabel.BringToFront();
            pictureBoxVisa.Visible = false;
            mastercardPictureBox.Visible = false;

            var queryMyCards = $"SELECT IdBankCard, BankCardNumber FROM BankCard WHERE IdClient = '{DataStorage.IdClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.GetConnection());
            database.OpenConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            switchCardComboBox.DataSource = cards;
            switchCardComboBox.ValueMember = "IdBankCard";
            switchCardComboBox.DisplayMember = "BankCardNumber";
            database.CloseConnection();

            SelectBankCard();
        }


        private void SelectBankCard()
        {
            cardNumberLabel.Text = "";
            string paymentSystem = "";
            string querySelectedCard = $"SELECT BankCardNumber, BankCardCvvCode, CONCAT(FORMAT(BankCardDate, '%M'), '/', FORMAT(BankCardDate, '%y')), BankCardPaymentSystem, BankCardBalance, BankCardCurrency FROM BankCard WHERE BankCardNumber = '{switchCardComboBox.GetItemText(switchCardComboBox.SelectedItem)}'";
            SqlCommand command = new SqlCommand(querySelectedCard, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cardNumber = reader[0].ToString();

                int tmp = 0;
                int tmp1 = 4;
                for (int m = 0; m < 4; m++)
                {
                    for (int n = tmp; n < tmp1; n++)
                    {
                        cardNumberLabel.Text += cardNumber[n].ToString();
                    }
                    cardNumberLabel.Text += " ";
                    tmp += 4;
                    tmp1 += 4;
                }

                cvvLabel.Text = reader[1].ToString();
                validThruLabel.Text = reader[2].ToString();
                paymentSystem = reader[3].ToString();
                cardBalanceLabel.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                currencyLabel.Text = reader[5].ToString();
                DataStorage.CardCVV = cvvLabel.Text;
                cvvLabel.Text = "***";
            }
            reader.Close();

            if (paymentSystem == "Visa")
            {
                pictureBoxVisa.Visible = true;
                mastercardPictureBox.Visible = false;
            }
            else
            {
                pictureBoxVisa.Visible = false;
                mastercardPictureBox.Visible = true;
            }
        }



        private void addNewCardButton_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            addBankCard.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cvvLabel_Click(object sender, EventArgs e)
        {
            if (cvvLabel.Text == "***")
            {
                cvvLabel.Text = DataStorage.CardCVV;
            }
            else
                cvvLabel.Text = "***";

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var queryMyCards = $"SELECT IdBankCard, BankCardNumber FROM BankCard WHERE IdClient = '{DataStorage.IdClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.GetConnection());
            database.OpenConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            switchCardComboBox.DataSource = cards;
            switchCardComboBox.ValueMember = "IdBankCard";
            switchCardComboBox.DisplayMember = "BankCardNumber";
            database.CloseConnection();

            SelectBankCard();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();
            DataStorage.BankCard = transferToCardTextBox.Text;
            DataStorage.CardNumber = switchCardComboBox.GetItemText(switchCardComboBox.SelectedItem);
            switchCardComboBox.Text = "";
            sendToForm.ShowDialog();
        }

        private void toUserButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void transactionHistoryButton_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistory = new TransactionHistoryForm();
            transactionHistory.Show();
        }

        private void mobileTopUpButton_Click(object sender, EventArgs e)
        {
            PhoneForm phoneForm = new PhoneForm();
            DataStorage.CardNumber = switchCardComboBox.GetItemText(switchCardComboBox.SelectedItem);
            DataStorage.PhoneNumber = mobileTopUpTextBox.Text;
            mobileTopUpTextBox.Text = "";
            phoneForm.Show();
        }

        private void communalPaymentButton_Click(object sender, EventArgs e)
        {
            CommunalPaymets cammunalPaymets = new CommunalPaymets();
            DataStorage.CardNumber = switchCardComboBox.GetItemText(switchCardComboBox.SelectedItem);
            cammunalPaymets.Show();
        }

        private void internetTvButton_Click(object sender, EventArgs e)
        {
            CommunalPaymets cammunalPaymets = new CommunalPaymets();
            DataStorage.CardNumber = switchCardComboBox.GetItemText(switchCardComboBox.SelectedItem);
            cammunalPaymets.Show();
        }
    }
}

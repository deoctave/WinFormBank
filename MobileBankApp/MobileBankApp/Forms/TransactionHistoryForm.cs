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

namespace MobileBankApp.Forms
{
    public partial class TransactionHistoryForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            var querySelectTransactions = $"SELECT TransactionType, TransactionDestination, TransactionDate, TransactionNumber, TransactionValue FROM Transactions INNER JOIN BankCard ON Transactions.IdBankCard = BankCard.IdBankCard INNER JOIN Client ON Client.IdClient = BankCard.IdClient WHERE Client.IdClient = '{DataStorage.IdClient}'";
            SqlCommand command = new SqlCommand(querySelectTransactions, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listView = new ListViewItem(reader[0].ToString());
                listView.SubItems.Add(reader[1].ToString());
                listView.SubItems.Add(reader[2].ToString());
                listView.SubItems.Add(reader[3].ToString());
                listView.SubItems.Add(reader[4].ToString());
                listView1.Items.Add(listView);
            }
            reader.Close();

            listView1.Sort();
        }

        private void transacCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

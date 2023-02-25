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
using System.Data.SqlClient;

namespace MobileBankApp
{
    public partial class Validation : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public Validation()
        {
            InitializeComponent();
        }

        private void validationCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okValidationButton_Click(object sender, EventArgs e)
        {
            int attempts = 3;
            int cardPin = Convert.ToInt32(pinValidNumUpDown.Value);
            int pin = 0;

            var queryCheckPin = $"SELECT BankCardPin FROM BankCard WHERE BankCardNumber = '{DataStorage.BankCard}'";
            SqlCommand commandCheckPin = new SqlCommand(queryCheckPin, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = commandCheckPin.ExecuteReader();
            while (reader.Read())
                pin = Convert.ToInt32(reader[0]);
            reader.Close();

            if (cardPin == pin)
            {
                MessageBox.Show("Операция подтверждена", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                DataStorage.Attempts = attempts;
            }
            else 
            {
                MessageBox.Show("Неверный PIN - код", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (attempts > 0)
                    attempts--;
                else 
                {
                    DataStorage.Attempts = attempts;
                    MessageBox.Show("У вас закончились попытки", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }

        }

        private void Validation_Load(object sender, EventArgs e)
        {

        }
    }
}

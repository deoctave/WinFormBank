using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBankApp.Forms
{
    public partial class ChangeNumberForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public ChangeNumberForm()
        {
            InitializeComponent();
        }

        private void changeCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeNumberButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            string caption = "Окно";

            if (!Regex.IsMatch(changeNumberTextBox.Text, "^[+][7][0-9]{7,14}$"))
            {
                MessageBox.Show("Пожалуйста укажите ваш номер телефона в формате +70001234567 ", caption, btn, icon);
                changeNumberTextBox.Select();
                return;
            }

            var phoneNumber = changeNumberTextBox.Text;
            var changeNumQuery = $"UPDATE Client SET ClientPhoneNumber = '{phoneNumber}' WHERE IdClient = '{DataStorage.IdClient}'";
            SqlCommand command = new SqlCommand(changeNumQuery, database.GetConnection());
            database.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Номер телефона успешно изменен");
                Close();
            }
            else
                MessageBox.Show("Ошибка");
            database.CloseConnection();
        }

        private void ChangeNumberForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ChangeEmailForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public ChangeEmailForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string caption = "Окно";


            if (!Regex.IsMatch(changeEmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста укажите вашу почту ", caption, btn, icon);
                changeEmailTextBox.Select();
                return;
            }


            var emailAdress = changeEmailTextBox.Text;
            var changeEmailQuery = $"UPDATE Client SET ClientEmail = '{emailAdress}' WHERE IdClient = '{DataStorage.IdClient}'";
            SqlCommand command = new SqlCommand(changeEmailQuery, database.GetConnection());
            database.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Адрес эл. почты успешно изменен");
                Close();
            }
            else
                MessageBox.Show("Ошибка");
            database.CloseConnection();
        }

        private void changeCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeEmailForm_Load(object sender, EventArgs e)
        {

        }
    }
}

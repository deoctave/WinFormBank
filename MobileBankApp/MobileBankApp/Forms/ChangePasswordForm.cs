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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MobileBankApp.Forms
{
    public partial class ChangePasswordForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string caption = "Окно";

            if (!Regex.IsMatch(changePasswordTextBox.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])).{8,}$"))
            {
                MessageBox.Show("Пароль должен иметь заглавные и строчные буквы латинского алфавита, цифры и состоять из 8 символов", caption, btn, icon);
                changePasswordTextBox.Select();
                return;
            }

            if (changePasswordTextBox.Text != confirmTextBox.Text)
            {
                MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают", caption, btn, icon);
                return;
            }

            var pass = changePasswordTextBox.Text;
            var changePasswordQuery = $"UPDATE Client SET ClientPassword = '{pass}' WHERE IdClient = '{DataStorage.IdClient}'";
            SqlCommand command = new SqlCommand(changePasswordQuery, database.GetConnection());
            database.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль успешно изменен");
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
    }
}

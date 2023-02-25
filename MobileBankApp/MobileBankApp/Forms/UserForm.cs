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
using MobileBankApp.Forms;

namespace MobileBankApp
{
    public partial class UserForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public UserForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            var queryFMF = $"SELECT CONCAT(ClientLastName, ' ', ClientFirstName , ' ' , ClientMiddleName), ClientPhoneNumber, ClientEmail FROM Client WHERE IdClient = {DataStorage.IdClient}";
            SqlCommand command = new SqlCommand(queryFMF, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                fullNameLabel.Text = reader[0].ToString();
                profilePhoneLabel.Text = reader[1].ToString();
                profileEmailLabel.Text = reader[2].ToString();
            }
            reader.Close();
        }

        private void ClearFields() 
        {
            fullNameLabel.Text = string.Empty;
            profilePhoneLabel.Text = string.Empty;
            profileEmailLabel.Text = string.Empty;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void userCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            ChangeEmailForm changeEmail = new ChangeEmailForm();

        }

        private void changePhoneButton_Click(object sender, EventArgs e)
        {
            ChangeNumberForm changeNumber = new ChangeNumberForm();
            changeNumber.Show();
        }


        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            RefreshData();
        }
    }
}

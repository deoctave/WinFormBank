using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace MobileBankApp
{
    public partial class RegistrationForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            firstnameTextBox.Select();
        }

        private void signOnButton_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            string caption = "Окно";

            if (firstnameTextBox.Text == "" || lastnameTextBox.Text == "" || middlenameTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля", caption, btn, icon);
                return;
            }
      
            string firstnameText = (firstnameTextBox.Text).ToUpper();
            string lastnameText = (lastnameTextBox.Text).ToUpper();
            string middlenameText = (middlenameTextBox.Text).ToUpper();
            

            if (string.IsNullOrEmpty(genderComboBox.SelectedItem.ToString())) 
            {
                MessageBox.Show("Пожалуйста укажите пол", caption, btn, icon);
                genderComboBox.Select();
                return;
            }

            if (!Regex.IsMatch(createPasswordTextBox.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])).{8,}$"))
            {
                MessageBox.Show("Пароль должен иметь заглавные и строчные буквы латинского алфавита, цифры и состоять из 8 символов", caption, btn, icon);
                createPasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(confirmPasswordTextBox.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])).{8,}$"))
            {
                MessageBox.Show("Пожалуйста подтвердите пароль", caption, btn, icon);
                confirmPasswordTextBox.Select();
                return;
            }
            if (createPasswordTextBox.Text != confirmPasswordTextBox.Text) 
            {
                MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают", caption, btn, icon);
                confirmPasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста укажите вашу почту ", caption, btn, icon);
                emailTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(phonenumberTextBox.Text, "^[+][7][0-9]{7,14}$"))
            {
                MessageBox.Show("Пожалуйста укажите ваш номер телефона в формате +70001234567 ", caption, btn, icon);
                phonenumberTextBox.Select();
                return;
            }
            

            string yourSQL = "SELECT ClientPhoneNumber FROM Client WHERE ClientPhoneNumber = '" + phonenumberTextBox.Text +"'";


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("На данный номер уже зарегистрирован аккаунт ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phonenumberTextBox.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы хотите сохранить данные? ", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string mySQL = "INSERT INTO Client (ClientFirstName, ClientLastName, ClientMiddleName, ClientGender, ClientPassword, ClientEmail, ClientPhoneNumber) VALUES ('" + firstnameText + "','" + lastnameText + "','" + middlenameText + "','" + genderComboBox.SelectedItem.ToString() + "','" + createPasswordTextBox.Text + "','" + emailTextBox.Text + "','" + phonenumberTextBox.Text + "')";


                dataBase.OpenConnection();
                SqlCommand commandAddNewUser = new SqlCommand(mySQL, dataBase.GetConnection());
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Запись успешно сохранена", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls();
                dataBase.CloseConnection();
                Close();
            }
        }

        private void ClearControls()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>()) 
            {
                textBox.Text = string.Empty;
            }

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>()) 
            {
                comboBox.SelectedItem = null;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                createPasswordTextBox.UseSystemPasswordChar = false;
                confirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else 
            {
                createPasswordTextBox.UseSystemPasswordChar = true;
                confirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void registrationCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

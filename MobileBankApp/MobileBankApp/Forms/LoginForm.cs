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
    public partial class LoginForm : Form
    {

        DataBaseConnection dataBase = new DataBaseConnection();

        public LoginForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordtextBox.Text))
            {
                var querySelectClient = $"SELECT * FROM Client WHERE ClientPhoneNumber = '{usernameTextBox.Text}' AND ClientPassword = '{passwordtextBox.Text}'";
                var queryGetId = $"SELECT IdClient FROM CLient WHERE ClientPhoneNumber = '{usernameTextBox.Text}'";
                var commandGetID = new SqlCommand(queryGetId, dataBase.GetConnection());

                dataBase.OpenConnection();
                SqlDataReader reader = commandGetID.ExecuteReader();
                while (reader.Read())
                {
                    DataStorage.IdClient = reader[0].ToString();
                }
                reader.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(querySelectClient, dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    usernameTextBox.Clear();
                    passwordtextBox.Clear();

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    Show();
                    usernameTextBox.Select();
                }
                else
                {
                    MessageBox.Show("Имя пользователья или пароль не верны. Попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }


            }
            else 
            {
                MessageBox.Show("Пожалуйста введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Select();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void loginCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
                passwordtextBox.UseSystemPasswordChar = false;
            else
                passwordtextBox.UseSystemPasswordChar = true;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CreateAccount : Form
    {
        private LoginAccount login;
        public CreateAccount(LoginAccount login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            registerData();
        }

        private void registerData()
        {
            if (newNameTextbox.Text != "" && newEmailTextbox.Text != "" && newPasswordTextbox.Text != "")
            {
                    string connection = "server=localhost; user id=root; password=; database=ikea_userdata";
                    string query = "INSERT INTO accountcredentials (Name, Email, Password) VALUES ('" + newNameTextbox.Text + "', '" + newEmailTextbox.Text + "', '" + newPasswordTextbox.Text + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connection);
                    databaseConnection.Open();
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    MySqlDataReader dr;
                    dr = commandDatabase.ExecuteReader();
                    MessageBox.Show("Account created successfully");
                    databaseConnection.Close();

                    login.Show();
                    Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}

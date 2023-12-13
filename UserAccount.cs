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
    public partial class UserAccount : Form
    {
        // Open a new connection to the database
        string connection = "server=localhost; user id = root; password = ; database = ikea_userdata";
        MySqlConnection conn;

        private string email;
        private string password;
        MainScreen mainScreen;

        public UserAccount(string email, string password, MainScreen mainScreen)
        {
            InitializeComponent();
            conn = new MySqlConnection(connection);
            conn.Open();
            this.email = email;
            this.password = password;
            this.mainScreen = mainScreen;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                string newEmail = textBox3.Text;

                // Set the query
                string query = "UPDATE accountcredentials SET email = '" + newEmail + "' WHERE email = '" + email + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                // Display a message
                MessageBox.Show("Email changed successfully!");
                // Close the reader
                reader.Close();
                // Get the new email from the database
                email = newEmail;
            }
            if (textBox5.Text == textBox4.Text)
            {
                // Set the query
                string query = "UPDATE accountcredentials SET Password = '" + textBox5.Text + "' WHERE Password = '" + password + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                // Close the connection
                MessageBox.Show("Password changed successfully!");
                reader.Close();
                // Get the new password from the database
                password = textBox5.Text;
            }
            if (textBox6.Text != "")
            {
                // Set the query
                string query = "UPDATE accountcredentials SET PhoneNumber = '" + textBox6.Text + "' WHERE Email = '" + email + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                // Close the connection
                MessageBox.Show("Phone number changed successfully!");
                reader.Close();
            }

            conn.Close();
            mainScreen.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show a warning message
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Set the query
                string query = "DELETE FROM accountcredentials WHERE Email = '" + email + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                // Close the connection
                reader.Close();
                MessageBox.Show("Account deleted successfully!");
                mainScreen.Close();
            }
        }
    }
}

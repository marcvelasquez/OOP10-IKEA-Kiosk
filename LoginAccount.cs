using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class LoginAccount : Form
    {
        public LoginAccount()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter your email and password.");
            }
            else
            {
                CheckAccount();
            }
        }

        private void createAccountButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount(this);
            createAccount.Show();
            this.Hide();
        }

        private void CheckAccount()
        {
            string connection = "server=localhost; user id = root; password = ; database = ikea_userdata";
            string query = "SELECT * FROM accountcredentials WHERE email = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Login successful!");
                MainScreen mainPage = new MainScreen(textBox1.Text, textBox2.Text);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }

            // Close the connection
            conn.Close();
        }
    }
}

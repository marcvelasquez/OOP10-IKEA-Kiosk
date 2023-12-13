using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainScreen : Form
    {
        private Dictionary<Product, int> shoppingCart;

        private string email;
        private string password;

        public MainScreen(string email, string password)
        {
            this.email = email;
            this.password = password;

            InitializeComponent();
            panel1.VerticalScroll.Enabled = false;
            panel1.VerticalScroll.Visible = false;
            panel1.VerticalScroll.Maximum = 0;
            panel1.AutoScroll = true;

            // Make a new Dictionary<Product, int> for the shopping cart
            shoppingCart = new Dictionary<Product, int>();
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void topSellersButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void offersAndPromotions_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.ikea.com/ph/en/cat/lighting-lamps-shades-li001/",
                UseShellExecute = true
            });
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Go to the URL
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.ikea.com/ph/en/cat/kitchenware-tableware-kt001/",
                UseShellExecute = true
            });
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Go to the URL
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.ikea.com/ph/en/cat/storage-organization-st001/",
                UseShellExecute = true
            });
        }

        private void offersButton_Click(object sender, EventArgs e)
        {
            // Change the tab to the third tab
            tabControl1.SelectTab(2);
        }

        private void marketplaceButton_Click(object sender, EventArgs e)
        {
            // Change the tab to the fourth tab
            tabControl1.SelectTab(3);
        }

        private void searchItem(object sender, KeyPressEventArgs e)
        {
            // If the user presses the enter key
            if (e.KeyChar == (char)13)
            {
                // Get the text from the search bar
                string search = searchBar.Text;

                // If the search bar is empty
                if (search == "")
                {
                    // Show a message box
                    MessageBox.Show("Please enter a search term.");
                }
                else
                {
                    // Go to the URL
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.ikea.com/ph/en/search/?query=" + search,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Show a message box to confirm the user if they want to log out
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Go back to the login screen
                LoginAccount loginAccount = new LoginAccount();
                loginAccount.Show();
                Close();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Hide();
            UserAccount userAccount = new UserAccount(email, password, this);
            userAccount.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToCart("Vinterfint - Artificial Christmas Tree", 1990);
        }

        private void AddToCart(string name, int price)
        {
            Product product = new Product(name, price);
            if (shoppingCart.ContainsKey(product))
            {
                shoppingCart[product]++;
            }
            else
            {
                shoppingCart.Add(product, 1);
            }
            UpdateCartPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToCart("Vinterfint - Decoration, wreath", 770);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToCart("Vinterfint - Paper bag", 100);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        // Make a method that will update the cartPanel with the items in the shopping cart without an image
        private void UpdateCartPanel()
        {
            // Clear the cartPanel
            cartPanel.Controls.Clear();

            // Make a new int for the y position
            int y = 0;

            // For each product in the shopping cart
            foreach (KeyValuePair<Product, int> product in shoppingCart)
            {
                // Make a new label for the name of the product
                Label nameLabel = new Label();
                nameLabel.Text = product.Key.name;
                nameLabel.Location = new Point(0, y);
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font("Microsoft Sans Serif", 8);
                cartPanel.Controls.Add(nameLabel);

                // Make a new label for the price of the product
                Label priceLabel = new Label();
                priceLabel.Text = "₱" + product.Key.price.ToString();
                priceLabel.Location = new Point(200, y);
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font("Microsoft Sans Serif", 8);
                cartPanel.Controls.Add(priceLabel);

                // Make a new label for the quantity of the product
                Label quantityLabel = new Label();
                quantityLabel.Text = "x" + product.Value.ToString();
                quantityLabel.Location = new Point(300, y);
                quantityLabel.AutoSize = true;
                quantityLabel.Font = new Font("Microsoft Sans Serif", 8);
                cartPanel.Controls.Add(quantityLabel);

                // Make a new button for the remove button
                Button removeButton = new Button();
                removeButton.Text = "Remove";
                removeButton.Location = new Point(400, y);
                removeButton.AutoSize = true;
                removeButton.Font = new Font("Microsoft Sans Serif", 8);
                removeButton.Click += new EventHandler(RemoveButton_Click);
                cartPanel.Controls.Add(removeButton);

                // Increment the y position by 30
                y += 30;
            }
        }

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            // Get the source of the button and then delete the item from the shopping cary
            Button button = (Button)sender;
            string name = button.Parent.Controls[0].Text;
            // Check if the product is in the shopping cart
            foreach (KeyValuePair<Product, int> product in shoppingCart)
            {
                if (product.Key.name == name)
                {
                    shoppingCart.Remove(product.Key);
                    UpdateCartPanel();
                    break;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Clear the cartPanel
            cartPanel.Controls.Clear();

            // delete all contents of the dictionary
            shoppingCart.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Print the receipt
            Receipt receipt = new Receipt(shoppingCart);
            shoppingCart.Clear();
            UpdateCartPanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToCart("Hammarn - Sleeper Sofa", 5490);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToCart("Barlast - Table Lamp", 200);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToCart("Storavan - Bathroom Set", 100);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToCart("Mopsig", 250);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToCart("Baggebo", 1690);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddToCart("Nolmyra", 2990);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddToCart("Glostad", 5990);
        }
    }
}

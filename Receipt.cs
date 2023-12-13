

using System.Drawing.Printing;

namespace WinFormsApp1
{
    internal class Receipt
    {
        private Dictionary<Product, int> shoppingCart;

        public Receipt(Dictionary<Product, int> shoppingCart)
        {
            this.shoppingCart = shoppingCart;
            printReceipt();
        }

        public void printReceipt()
        {
            // Let the user print the receipt
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printReceiptPage);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printReceiptPage(object sender, PrintPageEventArgs e)
        {
            // Print the receipt
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("IKEA", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Product".PadRight(30) + "Quantity".PadRight(30) + "Price".PadRight(30);
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            foreach (KeyValuePair<Product, int> entry in shoppingCart)
            {
                string productLine = entry.Key.name.PadRight(30) + entry.Value.ToString().PadRight(30) + entry.Key.price.ToString().PadRight(30);
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            offset = offset + 20;
            graphic.DrawString("Total price: ₱" + calculateTotal(), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
        }

        private string calculateTotal()
        {
            // Calculate the total price of the items in the shopping cart
            int total = 0;
            foreach (KeyValuePair<Product, int> entry in shoppingCart)
            {
                total += entry.Key.price * entry.Value;
            }
            return total.ToString();
        }
    }
}
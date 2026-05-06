using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

namespace POS_assesment_task_3___Ria_C___2026
{
    public partial class Oredrs : Form
    {
        public Oredrs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void lstCurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        double subtotal = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItem != null)
            {
                // Gets the full text of the item (e.g."Pants - $30")
                string selectedItem = lstAvailable.SelectedItem.ToString();

                string[] parts = selectedItem.Split('$');

                if (parts.Length > 1)
                {
                    // Take the part after the '$' and turn it into a number
                    double price = double.Parse(parts[1]);

                    // Updates the running subtotal with that specific price
                    subtotal += price;

                    // Adds the item to your 'Current Order' listbox
                    lstCurrentOrder.Items.Add(selectedItem);

                    // Calculates the Tax and the final Total
                    double tax = subtotal * 0.10;
                    double total = subtotal + tax;

                    // this updates the labels on my screen
                    lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
                    lblTax.Text = $"Tax (10%): ${tax:F2}";
                    lblTotal.Text = $"TOTAL: ${total:F2}";
                }
            }
        }

        private void Oredrs_Load(object sender, EventArgs e)
        {
            // this action clear any old items first
            lstAvailable.Items.Clear();

            // Adds the items with the $ sign so the 'Add' button can read them
            lstAvailable.Items.Add("Tops - $15");
            lstAvailable.Items.Add("Pants - $30");
            lstAvailable.Items.Add("Hoodies - $60");
            lstAvailable.Items.Add("Shoes - $100");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            {
                foreach (var item in lstCurrentOrder.Items)
                {
                    Product newTransaction = new Product();
                    newTransaction.Category = item.ToString(); // Grabs the name from your list
                    newTransaction.Price = subtotal;           // Grabs the price already calculated

                    TransactionHistory.SavedOrders.Add(newTransaction); 
                }
                MessageBox.Show("Transaction Successful! Thank you for shopping at TrendFitz. Make sure to spred the love and spred the trend ;)");
                GenerateReceiptPDF(subtotal);
            }

            // Clears the 'Current Order' listbox so it's empty again
            lstCurrentOrder.Items.Clear();

            // Resets the subtotal variable to 0
            subtotal = 0;

            // Resets the labels so they show $0.00 again
            lblSubtotal.Text = "Subtotal: $0.00";
            lblTax.Text = "Tax (10%): $0.00";
            lblTotal.Text = "TOTAL: $0.00";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selectedPage = listBox1.SelectedItem.ToString();

            if (selectedPage == "Inventory")
            {
                Inventory inv = new Inventory();
                inv.Show();
                this.Close();
            }
            else if (selectedPage == "Orders")
            {
                Oredrs ord = new Oredrs();
                ord.Show();
                this.Close();
            }
            else if (selectedPage == "Transactions")
            {
                transactions trans = new transactions();
                trans.Show();
                this.Close();
            }
            else if (selectedPage == "Home")
            {
                Homepage home = new Homepage();
                home.Show();
                this.Close();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GenerateReceiptPDF(double totalAmount)
        {
            // 1. ASK: Do they even want the receipt?
            DialogResult receiptChoice = MessageBox.Show("Would you like to see your receipt?", "Receipt", MessageBoxButtons.YesNo);

            if (receiptChoice == DialogResult.Yes)
            {
                string fileName = $"TrendFitz_Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);
                        document.Add(new Paragraph("TrendFitz - OFFICIAL RECEIPT").SetFontSize(20));
                        document.Add(new Paragraph($"Date: {DateTime.Now}"));
                        document.Add(new Paragraph("--------------------------------------------------"));

                        foreach (var item in lstCurrentOrder.Items)
                        {
                            document.Add(new Paragraph(item.ToString()));
                        }

                        document.Add(new Paragraph("--------------------------------------------------"));
                        document.Add(new Paragraph($"TOTAL PAID: ${totalAmount:F2}").SetFontSize(16));
                        document.Add(new Paragraph("\nThank you for shopping at TrendFitz!"));
                        document.Close();
                    }
                }

                // Auto-opens the PDF
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }

            // 2. askes the personif they want to stay logged in or Log out?
            DialogResult stayLoggedIn = MessageBox.Show("Transaction Complete! Do you wish to stay logged in?", "Continue?", MessageBoxButtons.YesNo);

            if (stayLoggedIn == DialogResult.Yes)
            {
                // Clear the current order so they can start a new one
                lstCurrentOrder.Items.Clear();
                MessageBox.Show("System ready for next customer.");
            }
            else
            {
                // Take them back to the Login screen
                Login loginPage = new Login();
                loginPage.Show();
                this.Close(); // Closes the transaction page
            }
        }
    }
    
}

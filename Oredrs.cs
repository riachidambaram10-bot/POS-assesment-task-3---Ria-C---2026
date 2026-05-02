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
            // Creates a filename with the current date/time so every receipt is unique
            string fileName = $"TrendFitz_Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

            // This saves it directly to your Desktop
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            // This build the PDF
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("TrendFitz - OFFICIAL RECEIPT").SetFontSize(20));
                    document.Add(new Paragraph($"Date: {DateTime.Now}"));
                    document.Add(new Paragraph("--------------------------------------------------"));

                    // This adds every item currently in your order listbox to the PDF
                    foreach (var item in lstCurrentOrder.Items)
                    {
                        document.Add(new Paragraph(item.ToString()));
                    }

                    document.Add(new Paragraph("--------------------------------------------------"));
                    document.Add(new Paragraph($"TOTAL PAID: ${totalAmount:F2}").SetFontSize(16));
                    document.Add(new Paragraph("\nThank you for shopping at TrendFitz!"));
                    document.Close();

                    // auto opens the PDF
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                    MessageBox.Show($"Receipt PDF generated and saved to your Desktop!");
                }
            }
        }
    }
    
}

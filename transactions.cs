using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_assesment_task_3___Ria_C___2026
{
    public partial class transactions : Form
    {
        public transactions()
        {
            InitializeComponent();
            DisplayData(); // This runs when the page opens
        }

        private void DisplayData()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = TransactionHistory.SavedOrders;

            // This part does the math
            double totalRevenue = 0;
            foreach (var item in TransactionHistory.SavedOrders)
            {
                totalRevenue += item.Price;
            }

            // This displays the math on my label
            lblTotalRevenue.Text = $"Total Revenue: ${totalRevenue:F2}";
        }
        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // space is left empty so the designer doesn't crash.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
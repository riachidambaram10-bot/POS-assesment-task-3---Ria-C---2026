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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            transactions transactionsPage = new transactions();

            transactionsPage.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inventory inventoryPage = new Inventory();

            inventoryPage.Show();

            this.Hide(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Oredrs ordersPage = new Oredrs();

            // Shows the orders page
            ordersPage.Show();

            // Hides my the homepage so i don't have too many windows open
            this.Hide();
        }
    }
}

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
    public partial class Inventory : Form
    {
        List<Product> products = new List<Product>();

        public Inventory()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product p = new Product();

                      string stockValue = dgvInventory.CurrentRow.Cells["cmbStock"].Value?.ToString() ?? "0";
            p.Stock = int.Parse(stockValue);

            string priceValue = dgvInventory.CurrentRow.Cells["cmbPrice"].Value?.ToString() ?? "0";
            priceValue = priceValue.Replace("$", "").Trim();
            p.Price = double.Parse(priceValue);

            products.Add(p);

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;

            MessageBox.Show("Item added successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow != null && !dgvInventory.CurrentRow.IsNewRow)
            {
                int index = dgvInventory.CurrentRow.Index;

                if (index < products.Count)
                {
                    products.RemoveAt(index);
                                   
                        dgvInventory.DataSource = null;
                        dgvInventory.DataSource = products;

                        MessageBox.Show("Item deleted!");
                    }
                }
            else
            {
                MessageBox.Show("Please click on a filled-out row first!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (dgvInventory.CurrentRow != null && !dgvInventory.CurrentRow.IsNewRow)
                {
                    dgvInventory.EndEdit();
                    int index = dgvInventory.CurrentRow.Index;

                    if (index < products.Count)
                    {
                        products[index].Category = dgvInventory.CurrentRow.Cells["cmbCategory"].Value?.ToString() ?? "";
                        products[index].Colour = dgvInventory.CurrentRow.Cells["cmbColour"].Value?.ToString() ?? "";
                        products[index].Size = dgvInventory.CurrentRow.Cells["cmbSize"].Value?.ToString() ?? "";

                        string stockVal = dgvInventory.CurrentRow.Cells["cmbStock"].Value?.ToString() ?? "0";
                        string priceVal = dgvInventory.CurrentRow.Cells["cmbPrice"].Value?.ToString() ?? "0";

                        products[index].Stock = int.Parse(stockVal);
                        products[index].Price = double.Parse(priceVal.Replace("$", ""));

                        MessageBox.Show("Item updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please click 'Add Item' first to save this product to the list before updating it!");
                    }
                }
            }
        }
    }
}

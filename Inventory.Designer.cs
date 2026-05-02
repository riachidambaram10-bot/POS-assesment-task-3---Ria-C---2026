namespace POS_assesment_task_3___Ria_C___2026
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbColour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbSize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.listBox1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Items.AddRange(new object[] {
            "Navigation bar",
            "Home",
            "Inventory ",
            "Orders",
            "Transactions"});
            this.listBox1.Location = new System.Drawing.Point(-1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 1120);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(213, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1584, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 843);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1501, 292);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1535, 46);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Search here...\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AccessibleName = "";
            this.dgvInventory.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbCategory,
            this.cmbColour,
            this.cmbSize,
            this.cmbStock,
            this.cmbPrice});
            this.dgvInventory.GridColor = System.Drawing.Color.Black;
            this.dgvInventory.Location = new System.Drawing.Point(221, 469);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.Size = new System.Drawing.Size(814, 312);
            this.dgvInventory.TabIndex = 15;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.HeaderText = "Category";
            this.cmbCategory.Items.AddRange(new object[] {
            "Tops",
            "Pants",
            "Hoodies",
            "Shoes"});
            this.cmbCategory.MinimumWidth = 8;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbCategory.Width = 150;
            // 
            // cmbColour
            // 
            this.cmbColour.HeaderText = "Colour";
            this.cmbColour.Items.AddRange(new object[] {
            "Red, Orange",
            "yellow",
            "Green, Blue",
            "Purple, Pink",
            "Brown, Black",
            "White, Grey "});
            this.cmbColour.MinimumWidth = 8;
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbColour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbColour.Width = 150;
            // 
            // cmbSize
            // 
            this.cmbSize.HeaderText = "Size ";
            this.cmbSize.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.cmbSize.MinimumWidth = 8;
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbSize.Width = 150;
            // 
            // cmbStock
            // 
            this.cmbStock.HeaderText = "Stock quantity";
            this.cmbStock.MinimumWidth = 8;
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbStock.Width = 150;
            // 
            // cmbPrice
            // 
            this.cmbPrice.HeaderText = "Price";
            this.cmbPrice.MinimumWidth = 8;
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbPrice.Width = 150;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Peru;
            this.button4.Location = new System.Drawing.Point(296, 708);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Add Item";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Peru;
            this.button5.Location = new System.Drawing.Point(551, 707);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "Update Item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Peru;
            this.button6.Location = new System.Drawing.Point(805, 707);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 37);
            this.button6.TabIndex = 23;
            this.button6.Text = "delete Item";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1756, 1129);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inventory";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbCategory;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColour;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbPrice;
    }
}
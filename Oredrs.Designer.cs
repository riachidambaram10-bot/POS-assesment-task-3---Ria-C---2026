namespace POS_assesment_task_3___Ria_C___2026
{
    partial class Oredrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oredrs));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.lstCurrentOrder = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(217, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1584, 396);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            this.listBox1.Location = new System.Drawing.Point(2, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 1192);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 866);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1501, 326);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create Customer Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Available Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(909, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Order";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1250, 720);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "TOTAL: $0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lstAvailable
            // 
            this.lstAvailable.BackColor = System.Drawing.Color.Tan;
            this.lstAvailable.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.ItemHeight = 32;
            this.lstAvailable.Items.AddRange(new object[] {
            "Tops",
            "Pants",
            "Hoodies",
            "Shoes"});
            this.lstAvailable.Location = new System.Drawing.Point(576, 524);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(158, 132);
            this.lstAvailable.TabIndex = 16;
            // 
            // lstCurrentOrder
            // 
            this.lstCurrentOrder.BackColor = System.Drawing.Color.Tan;
            this.lstCurrentOrder.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentOrder.FormattingEnabled = true;
            this.lstCurrentOrder.ItemHeight = 32;
            this.lstCurrentOrder.Location = new System.Drawing.Point(914, 524);
            this.lstCurrentOrder.Name = "lstCurrentOrder";
            this.lstCurrentOrder.Size = new System.Drawing.Size(158, 132);
            this.lstCurrentOrder.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(745, 496);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Gold;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(868, 794);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(251, 45);
            this.btnComplete.TabIndex = 20;
            this.btnComplete.Text = "Complete Order!";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(1251, 524);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(134, 21);
            this.lblSubtotal.TabIndex = 21;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(1251, 630);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(153, 21);
            this.lblTax.TabIndex = 22;
            this.lblTax.Text = "Tax (10%): $0.00";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // Oredrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1788, 1170);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCurrentOrder);
            this.Controls.Add(this.lstAvailable);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Oredrs";
            this.Text = "Oredrs";
            this.Load += new System.EventHandler(this.Oredrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.ListBox lstCurrentOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}
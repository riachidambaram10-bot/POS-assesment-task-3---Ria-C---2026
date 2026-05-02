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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Gets the text and makes the username lowercase for easier checking
            string inputUser = txtUsername.Text.ToLower();
            string inputPass = txtPassword.Text;

            // It checks if it ends with my domain AND if the password is correct
            if (inputUser.EndsWith("@trendfitz.com.au") && inputPass == "password123")
            {
                MessageBox.Show("Login Successful! Welcome to TrendFitz!.");

                Homepage home = new Homepage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login. username or password incorrect. Pleast try again with a different username or password");
                txtPassword.Clear();
                txtUsername.Clear();    
            }
        }
    }
}

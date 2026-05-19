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

            UserData.LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.ToLower();
            string inputPass = txtPassword.Text;

            // Search the UserData list for a matching user
            bool userFound = false;
            foreach (var user in UserData.AllUsers)
            {
                if (user.Username == inputUser && user.Password == inputPass)
                {
                    userFound = true;
                    break;
                }
            }

            if (userFound)
            {
                MessageBox.Show("Login Successful! Welcome to TrendFitz!");
                new Homepage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                txtPassword.Clear();
            }
        }
       

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens the Sign Up form
            SignUP signupForm = new SignUP();
            signupForm.Show();
            this.Hide(); // Hide login while signing up
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

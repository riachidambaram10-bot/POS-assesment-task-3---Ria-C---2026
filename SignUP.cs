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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Checks if the boxes are empty 
            if (string.IsNullOrWhiteSpace(txtNewUser.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("Please enter both a username and a password.");
                return;
            }

            // Creates the new user object
            User newUser = new User();
            newUser.Username = txtNewUser.Text.ToLower();
            newUser.Password = txtNewPass.Text;

            // Saves it to my static list
            UserData.AllUsers.Add(newUser);

            MessageBox.Show("Account created! You can now log in.");

            // Closes this page and goes back to Login
            Homepage home = new Homepage();
            home.Show();
            this.Hide(); // Hides the signup page so the app stays open
        }
    }
}

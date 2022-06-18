using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoqueLtd
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "admin" && passwordField.Text == "admin")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");

                usernameField.Clear();
                passwordField.Clear();

                usernameField.Focus();
            }
        }

        private void clientLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard("Client");
            dashboard.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

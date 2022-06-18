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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
            
        public Dashboard(string user)
        {
            InitializeComponent();

            if (user == "Client")
            {
                addServiceBtn.Hide();
                manageOrderBtn.Hide();
                manageBlogs.Hide();
                adminTitle.Hide();
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage Login = new LoginPage();
            Login.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

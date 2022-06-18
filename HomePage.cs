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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 5;
            if (panel1.Width >= 816)
            {
                timer1.Stop();
                this.Hide();
                LoginPage Login = new LoginPage();
                Login.Show();
            }
        }
    }
}

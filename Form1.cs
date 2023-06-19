using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Milestone : Form
    {
        public Milestone()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLogin f2 = new AdminLogin();
            f2.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CostumerPortal f2 = new CostumerPortal();
            f2.Show();
            this.Hide();
        }
    }
}

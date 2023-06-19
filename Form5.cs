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
    public partial class CostumerPortal : Form
    {
        public CostumerPortal()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FirstTextBox.Text +" " + LastTextBox.Text + " Your Order Has Been Confirmed For " + OrderTextBox.Text + " " + "Tacos");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Milestone().Show();
            this.Hide();
        }
    }
}

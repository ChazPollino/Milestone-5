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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            new InventoryPortal().Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
            this.Hide();
        }
    }
}

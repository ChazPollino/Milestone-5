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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "Admin" && PassWordTextBox.Text == "Password")
            {
                new AdminPortal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is invaild");
                UserNameTextBox.Text = "";
                PassWordTextBox.Text = "";
            }
            
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new Milestone().Show();
            this.Hide();
        }
    }
}

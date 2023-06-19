using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class EmployeeForm : Form
    {
        List<String> myEmployees = new List<String>();
        BindingSource bs = new BindingSource();
        public EmployeeForm()
        {
            InitializeComponent();
            bs.DataSource = myEmployees;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            myEmployees.Add(EmployeeTextBox.Text);
            EmployeeListBox.DataSource = bs;
            bs.ResetBindings(false);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AleadingButton_Click(object sender, EventArgs e)
        {
            myEmployees.Sort();
            bs.ResetBindings(false);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            EmployeeListBox.DataSource = bs;
            myEmployees.Add("Adaline");
            myEmployees.Add("Atlas");
            myEmployees.Add("Charlie");
            myEmployees.Add("Jasmine");
            myEmployees.Add("Bob");
            bs.ResetBindings(false);
        }

        private void ZleadingButton_Click(object sender, EventArgs e)
        {

            myEmployees.Sort();
            myEmployees.Reverse();
            bs.ResetBindings(false);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminPortal().Show();
            this.Close();
        }
    }
}

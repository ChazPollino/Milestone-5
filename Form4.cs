using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http.Headers;

namespace Milestone_Project

// CST 150 
// Chaz Pollino
// 6/18/23
// This Is My Work
{


    public partial class InventoryPortal : Form
    {

        DataTable Inventory = new DataTable();

        public InventoryPortal()
        {
            InitializeComponent();

        }
        private List<Object> ConvertArrayToList(object[] array)
        {
            List<Object> list = new List<Object>();

            foreach (object obj in array)
                list.Add(obj);

            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            QuantityTextBox.Text = "";
            PriceTextBox.Text = "";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.Rows[InventoryDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }



        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminPortal().Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String ID = IDTextBox.Text;
            String Name = NameTextBox.Text;
            String Quantity = QuantityTextBox.Text;
            String Price = PriceTextBox.Text;

            Inventory.Rows.Add(ID, Name, Quantity, Price);

            ClearButton_Click(sender, e);


        }

        private void InventoryPortal_Load(object sender, EventArgs e)
        {

            Inventory.Columns.Add("ID");
            Inventory.Columns.Add("Name");
            Inventory.Columns.Add("Quantity");
            Inventory.Columns.Add("Price");
            InventoryDataGrid.DataSource = Inventory;
        }

       

        private void RestockButton_Click(object sender, EventArgs e)
        {
            Inventory.Rows.Clear();

            string[] lines = File.ReadAllLines("D:\\Programming\\Milestone Project\\Milestone Project\\bin\\RestockInventory.txt");

            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                Inventory.Rows.Add(row);

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            string PriceValue = PriceTextBox.Text;
            InventoryDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in InventoryDataGrid.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue + PriceValue))
                        {
                            int rowIndex = row.Index;
                            InventoryDataGrid.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + SearchTextBox.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);



            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("D:\\Programming\\Milestone Project\\Milestone Project\\bin\\DisplayInventory.txt");

            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                Inventory.Rows.Add(row);
            }
        }

        


    }
}

namespace Milestone_Project
{
    partial class InventoryPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RestockButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PriceSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchNameLabel = new System.Windows.Forms.Label();
            this.PriceNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(752, 40);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(572, 105);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Inventory Portal";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(252, 177);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(507, 57);
            this.IDTextBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackButton.Location = new System.Drawing.Point(22, 915);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(229, 78);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RemoveButton.Location = new System.Drawing.Point(22, 559);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(519, 81);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove From Inventory";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClearButton.Location = new System.Drawing.Point(22, 645);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(519, 81);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogoutButton.Location = new System.Drawing.Point(359, 915);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(229, 78);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.InventoryDataGrid.Location = new System.Drawing.Point(803, 164);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersWidth = 82;
            this.InventoryDataGrid.RowTemplate.Height = 33;
            this.InventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDataGrid.Size = new System.Drawing.Size(982, 587);
            this.InventoryDataGrid.TabIndex = 7;
            this.InventoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            
            this.InventoryDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(252, 412);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(507, 51);
            this.PriceTextBox.TabIndex = 8;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(252, 330);
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(507, 52);
            this.QuantityTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(252, 251);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(507, 54);
            this.NameTextBox.TabIndex = 10;
            // 
            // IDLabel
            // 
            this.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IDLabel.Location = new System.Drawing.Point(40, 177);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(211, 54);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductNameLabel.Location = new System.Drawing.Point(40, 254);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(211, 51);
            this.ProductNameLabel.TabIndex = 12;
            this.ProductNameLabel.Text = "Name";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.QuantityLabel.Location = new System.Drawing.Point(40, 330);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(211, 66);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceLabel.Location = new System.Drawing.Point(40, 412);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(211, 48);
            this.PriceLabel.TabIndex = 14;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DisplayButton.Location = new System.Drawing.Point(22, 819);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(519, 81);
            this.DisplayButton.TabIndex = 15;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveButton.Location = new System.Drawing.Point(22, 472);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(519, 81);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save Inventory";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RestockButton
            // 
            this.RestockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RestockButton.Location = new System.Drawing.Point(22, 732);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(519, 81);
            this.RestockButton.TabIndex = 17;
            this.RestockButton.Text = "Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchButton.Location = new System.Drawing.Point(752, 842);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(519, 81);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search Item";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchTextBox.Location = new System.Drawing.Point(1356, 806);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(519, 81);
            this.SearchTextBox.TabIndex = 19;
            // 
            // PriceSearchTextBox
            // 
            this.PriceSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceSearchTextBox.Location = new System.Drawing.Point(1356, 931);
            this.PriceSearchTextBox.Multiline = true;
            this.PriceSearchTextBox.Name = "PriceSearchTextBox";
            this.PriceSearchTextBox.Size = new System.Drawing.Size(519, 81);
            this.PriceSearchTextBox.TabIndex = 20;
            // 
            // SearchNameLabel
            // 
            this.SearchNameLabel.AutoSize = true;
            this.SearchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchNameLabel.Location = new System.Drawing.Point(1536, 766);
            this.SearchNameLabel.Name = "SearchNameLabel";
            this.SearchNameLabel.Size = new System.Drawing.Size(187, 31);
            this.SearchNameLabel.TabIndex = 21;
            this.SearchNameLabel.Text = "Product Name";
            // 
            // PriceNameLabel
            // 
            this.PriceNameLabel.AutoSize = true;
            this.PriceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceNameLabel.Location = new System.Drawing.Point(1536, 897);
            this.PriceNameLabel.Name = "PriceNameLabel";
            this.PriceNameLabel.Size = new System.Drawing.Size(177, 31);
            this.PriceNameLabel.TabIndex = 22;
            this.PriceNameLabel.Text = "Product Price";
            // 
            // InventoryPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2053, 1112);
            this.Controls.Add(this.PriceNameLabel);
            this.Controls.Add(this.SearchNameLabel);
            this.Controls.Add(this.PriceSearchTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryDataGrid);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "InventoryPortal";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox PriceSearchTextBox;
        private System.Windows.Forms.Label SearchNameLabel;
        private System.Windows.Forms.Label PriceNameLabel;
    }
}
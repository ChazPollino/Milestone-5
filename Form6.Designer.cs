namespace Milestone_Project
{
    partial class EmployeeForm
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
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AleadingButton = new System.Windows.Forms.Button();
            this.ZleadingButton = new System.Windows.Forms.Button();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 31;
            this.EmployeeListBox.Location = new System.Drawing.Point(400, 246);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(612, 345);
            this.EmployeeListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddButton.Location = new System.Drawing.Point(400, 151);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(220, 70);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AleadingButton
            // 
            this.AleadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AleadingButton.Location = new System.Drawing.Point(1080, 338);
            this.AleadingButton.Name = "AleadingButton";
            this.AleadingButton.Size = new System.Drawing.Size(192, 73);
            this.AleadingButton.TabIndex = 2;
            this.AleadingButton.Text = "A-Z";
            this.AleadingButton.UseVisualStyleBackColor = true;
            this.AleadingButton.Click += new System.EventHandler(this.AleadingButton_Click);
            // 
            // ZleadingButton
            // 
            this.ZleadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ZleadingButton.Location = new System.Drawing.Point(1080, 486);
            this.ZleadingButton.Name = "ZleadingButton";
            this.ZleadingButton.Size = new System.Drawing.Size(192, 80);
            this.ZleadingButton.TabIndex = 3;
            this.ZleadingButton.Text = "Z-A";
            this.ZleadingButton.UseVisualStyleBackColor = true;
            this.ZleadingButton.Click += new System.EventHandler(this.ZleadingButton_Click);
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmployeeTextBox.Location = new System.Drawing.Point(735, 151);
            this.EmployeeTextBox.Multiline = true;
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(290, 70);
            this.EmployeeTextBox.TabIndex = 4;
            this.EmployeeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowButton.Location = new System.Drawing.Point(503, 42);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(352, 62);
            this.ShowButton.TabIndex = 5;
            this.ShowButton.Text = "Show Employees";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackButton.Location = new System.Drawing.Point(63, 486);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(192, 80);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1398, 710);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.ZleadingButton);
            this.Controls.Add(this.AleadingButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmployeeListBox);
            this.Name = "EmployeeForm";
            this.Text = "Employee Portal";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AleadingButton;
        private System.Windows.Forms.Button ZleadingButton;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button BackButton;
    }
}
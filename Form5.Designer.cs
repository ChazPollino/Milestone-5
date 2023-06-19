namespace Milestone_Project
{
    partial class CostumerPortal
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.LastTextBox = new System.Windows.Forms.TextBox();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(399, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(698, 75);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome Costumers!!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DescriptionLabel.Location = new System.Drawing.Point(107, 178);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(1188, 98);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Please Enter In Your Order Request And We Will Ship Your Order As Soon As Possibl" +
    "e";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FirstNameLabel.Location = new System.Drawing.Point(151, 335);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(206, 48);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LastNameLabel.Location = new System.Drawing.Point(588, 335);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(206, 48);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderLabel
            // 
            this.OrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OrderLabel.Location = new System.Drawing.Point(982, 335);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(259, 48);
            this.OrderLabel.TabIndex = 4;
            this.OrderLabel.Text = "How Many Tacos?";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTextBox.Location = new System.Drawing.Point(151, 447);
            this.FirstTextBox.Multiline = true;
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(206, 51);
            this.FirstTextBox.TabIndex = 5;
            // 
            // LastTextBox
            // 
            this.LastTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTextBox.Location = new System.Drawing.Point(588, 447);
            this.LastTextBox.Multiline = true;
            this.LastTextBox.Name = "LastTextBox";
            this.LastTextBox.Size = new System.Drawing.Size(206, 51);
            this.LastTextBox.TabIndex = 6;
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTextBox.Location = new System.Drawing.Point(1011, 447);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(206, 51);
            this.OrderTextBox.TabIndex = 7;
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(503, 586);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(408, 88);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Confirm Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(617, 680);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(194, 68);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CostumerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1481, 817);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.LastTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CostumerPortal";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox LastTextBox;
        private System.Windows.Forms.TextBox OrderTextBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button BackButton;
    }
}
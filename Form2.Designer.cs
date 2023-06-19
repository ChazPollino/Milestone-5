namespace Milestone_Project
{
    partial class AdminLogin
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(454, 43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(417, 82);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Admin Login";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UsernameLabel.Location = new System.Drawing.Point(156, 236);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(422, 69);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordLabel.Location = new System.Drawing.Point(156, 398);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(422, 69);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Enter Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UserNameTextBox.Location = new System.Drawing.Point(773, 236);
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(297, 69);
            this.UserNameTextBox.TabIndex = 3;
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PassWordTextBox.Location = new System.Drawing.Point(773, 398);
            this.PassWordTextBox.Multiline = true;
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(297, 69);
            this.PassWordTextBox.TabIndex = 4;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EnterButton.Location = new System.Drawing.Point(268, 547);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(310, 81);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LogoutButton.Location = new System.Drawing.Point(655, 547);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(310, 81);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Log-Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 744);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}
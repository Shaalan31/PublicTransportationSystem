namespace DBapplication
{
    partial class CompanyLogin
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
            this.CompanyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompanyNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyPasswordTextBox
            // 
            this.CompanyPasswordTextBox.Location = new System.Drawing.Point(137, 132);
            this.CompanyPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanyPasswordTextBox.Name = "CompanyPasswordTextBox";
            this.CompanyPasswordTextBox.PasswordChar = '*';
            this.CompanyPasswordTextBox.Size = new System.Drawing.Size(106, 20);
            this.CompanyPasswordTextBox.TabIndex = 2;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(26, 71);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanyNameLabel.TabIndex = 2;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(26, 132);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(28, 225);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 26);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CompanyNameMaskedTextBox
            // 
            this.CompanyNameMaskedTextBox.BeepOnError = true;
            this.CompanyNameMaskedTextBox.Location = new System.Drawing.Point(137, 71);
            this.CompanyNameMaskedTextBox.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.CompanyNameMaskedTextBox.Name = "CompanyNameMaskedTextBox";
            this.CompanyNameMaskedTextBox.PromptChar = ' ';
            this.CompanyNameMaskedTextBox.Size = new System.Drawing.Size(106, 20);
            this.CompanyNameMaskedTextBox.TabIndex = 6;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(263, 225);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(56, 26);
            this.SignInButton.TabIndex = 7;
            this.SignInButton.Text = "SignIn";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // CompanyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(340, 260);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.CompanyNameMaskedTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.CompanyPasswordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CompanyLogin";
            this.Text = "Company Login";
            this.Load += new System.EventHandler(this.CompanyLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CompanyPasswordTextBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MaskedTextBox CompanyNameMaskedTextBox;
        private System.Windows.Forms.Button SignInButton;
    }
}
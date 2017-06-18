namespace DBapplication
{
    partial class AddCompany
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
            this.CompanyIDLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AtLabel = new System.Windows.Forms.Label();
            this.EmailDomainComboBox = new System.Windows.Forms.ComboBox();
            this.ComLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CompanyNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CompanyIDLabel
            // 
            this.CompanyIDLabel.AutoSize = true;
            this.CompanyIDLabel.Location = new System.Drawing.Point(35, 33);
            this.CompanyIDLabel.Name = "CompanyIDLabel";
            this.CompanyIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CompanyIDLabel.TabIndex = 0;
            this.CompanyIDLabel.Text = "Company ID";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(35, 75);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanyNameLabel.TabIndex = 1;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(35, 120);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(35, 157);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email ";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(35, 199);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AtLabel
            // 
            this.AtLabel.AutoSize = true;
            this.AtLabel.Location = new System.Drawing.Point(263, 157);
            this.AtLabel.Name = "AtLabel";
            this.AtLabel.Size = new System.Drawing.Size(18, 13);
            this.AtLabel.TabIndex = 9;
            this.AtLabel.Text = "@";
            // 
            // EmailDomainComboBox
            // 
            this.EmailDomainComboBox.FormattingEnabled = true;
            this.EmailDomainComboBox.Items.AddRange(new object[] {
            "yahoo",
            "hotmail",
            "gmail",
            "outlook",
            "live"});
            this.EmailDomainComboBox.Location = new System.Drawing.Point(287, 153);
            this.EmailDomainComboBox.Name = "EmailDomainComboBox";
            this.EmailDomainComboBox.Size = new System.Drawing.Size(84, 21);
            this.EmailDomainComboBox.TabIndex = 10;
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(377, 157);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(30, 13);
            this.ComLabel.TabIndex = 11;
            this.ComLabel.Text = ".com";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(38, 249);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(348, 249);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyIDMaskedTextBox
            // 
            this.CompanyIDMaskedTextBox.BeepOnError = true;
            this.CompanyIDMaskedTextBox.Location = new System.Drawing.Point(157, 26);
            this.CompanyIDMaskedTextBox.Mask = "000";
            this.CompanyIDMaskedTextBox.Name = "CompanyIDMaskedTextBox";
            this.CompanyIDMaskedTextBox.PromptChar = ' ';
            this.CompanyIDMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompanyIDMaskedTextBox.TabIndex = 15;
            this.CompanyIDMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CompanyIDMaskedTextBox_MaskInputRejected);
            this.CompanyIDMaskedTextBox.Leave += new System.EventHandler(this.CompanyIDMaskedTextBox_Leave);
            // 
            // CompanyNameMaskedTextBox
            // 
            this.CompanyNameMaskedTextBox.Location = new System.Drawing.Point(157, 75);
            this.CompanyNameMaskedTextBox.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.CompanyNameMaskedTextBox.Name = "CompanyNameMaskedTextBox";
            this.CompanyNameMaskedTextBox.PromptChar = ' ';
            this.CompanyNameMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompanyNameMaskedTextBox.TabIndex = 16;
            this.CompanyNameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CompanyNameMaskedTextBox_MaskInputRejected);
            this.CompanyNameMaskedTextBox.Leave += new System.EventHandler(this.CompanyNameMaskedTextBox_Leave);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(157, 112);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 17;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(157, 150);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(157, 192);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 19;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CompanyNameMaskedTextBox);
            this.Controls.Add(this.CompanyIDMaskedTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.EmailDomainComboBox);
            this.Controls.Add(this.AtLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.CompanyIDLabel);
            this.Name = "AddCompany";
            this.Text = "Add Company";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyIDLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AtLabel;
        private System.Windows.Forms.ComboBox EmailDomainComboBox;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox CompanyIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CompanyNameMaskedTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
    }
}
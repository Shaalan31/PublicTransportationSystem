namespace DBapplication
{
    partial class UpdateCompany
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
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AtLabel = new System.Windows.Forms.Label();
            this.ComLabel = new System.Windows.Forms.Label();
            this.EmailDomainComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyDetailsGridView = new System.Windows.Forms.DataGridView();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(34, 193);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(34, 240);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(34, 286);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(136, 190);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(121, 20);
            this.AddressTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(136, 233);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(121, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // AtLabel
            // 
            this.AtLabel.AutoSize = true;
            this.AtLabel.Location = new System.Drawing.Point(263, 236);
            this.AtLabel.Name = "AtLabel";
            this.AtLabel.Size = new System.Drawing.Size(18, 13);
            this.AtLabel.TabIndex = 5;
            this.AtLabel.Text = "@";
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(426, 236);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(30, 13);
            this.ComLabel.TabIndex = 6;
            this.ComLabel.Text = ".com";
            // 
            // EmailDomainComboBox
            // 
            this.EmailDomainComboBox.FormattingEnabled = true;
            this.EmailDomainComboBox.Items.AddRange(new object[] {
            "yahoo",
            "gmail",
            "hotmail",
            "outlook",
            "live"});
            this.EmailDomainComboBox.Location = new System.Drawing.Point(300, 233);
            this.EmailDomainComboBox.Name = "EmailDomainComboBox";
            this.EmailDomainComboBox.Size = new System.Drawing.Size(105, 21);
            this.EmailDomainComboBox.TabIndex = 7;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(37, 335);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(504, 322);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(34, 22);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanyNameLabel.TabIndex = 11;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(160, 19);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompanyNameComboBox.TabIndex = 12;
            this.CompanyNameComboBox.Leave += new System.EventHandler(this.CompanyNameComboBox_Leave);
            // 
            // CompanyDetailsGridView
            // 
            this.CompanyDetailsGridView.BackgroundColor = System.Drawing.Color.Firebrick;
            this.CompanyDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDetailsGridView.Location = new System.Drawing.Point(37, 46);
            this.CompanyDetailsGridView.Name = "CompanyDetailsGridView";
            this.CompanyDetailsGridView.Size = new System.Drawing.Size(526, 122);
            this.CompanyDetailsGridView.TabIndex = 13;
            this.CompanyDetailsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDetailsGridView_CellContentClick);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(136, 286);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTextBox.TabIndex = 14;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // UpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.CompanyDetailsGridView);
            this.Controls.Add(this.CompanyNameComboBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmailDomainComboBox);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.AtLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Name = "UpdateCompany";
            this.Text = "Update Company";
            this.Load += new System.EventHandler(this.UpdateCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label AtLabel;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.ComboBox EmailDomainComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.DataGridView CompanyDetailsGridView;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
    }
}
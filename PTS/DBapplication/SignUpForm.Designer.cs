namespace DBapplication
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.DependantLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DependantToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UserPasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AtLabel = new System.Windows.Forms.Label();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.ComLabel = new System.Windows.Forms.Label();
            this.DependantJobCodeLabel = new System.Windows.Forms.Label();
            this.FirstNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DependantSSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.JobCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.SSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 40);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 71);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(12, 177);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(51, 13);
            this.BirthDateLabel.TabIndex = 3;
            this.BirthDateLabel.Text = "BirthDate";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 216);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 251);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 5;
            this.GenderLabel.Text = "Gender";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(127, 71);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(159, 20);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(127, 219);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(64, 20);
            this.EmailTextBox.TabIndex = 11;
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(127, 177);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(159, 20);
            this.BirthDatePicker.TabIndex = 12;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(127, 251);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 13;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(211, 251);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 14;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // DependantLabel
            // 
            this.DependantLabel.AutoSize = true;
            this.DependantLabel.Location = new System.Drawing.Point(12, 311);
            this.DependantLabel.Name = "DependantLabel";
            this.DependantLabel.Size = new System.Drawing.Size(85, 13);
            this.DependantLabel.TabIndex = 15;
            this.DependantLabel.Text = "Dependant SSN";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(197, 397);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(127, 107);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(159, 20);
            this.PasswordTextBox.TabIndex = 18;
            this.UserPasswordToolTip.SetToolTip(this.PasswordTextBox, "Enter a strong password");
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 107);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 19;
            this.PasswordLabel.Text = "Password";
            // 
            // AtLabel
            // 
            this.AtLabel.AutoSize = true;
            this.AtLabel.Location = new System.Drawing.Point(198, 220);
            this.AtLabel.Name = "AtLabel";
            this.AtLabel.Size = new System.Drawing.Size(18, 13);
            this.AtLabel.TabIndex = 20;
            this.AtLabel.Text = "@";
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.AllowDrop = true;
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Items.AddRange(new object[] {
            "yahoo",
            "hotmail",
            "outlook",
            "gmail",
            "live"});
            this.EmailComboBox.Location = new System.Drawing.Point(221, 218);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(65, 21);
            this.EmailComboBox.TabIndex = 21;
            this.EmailComboBox.Leave += new System.EventHandler(this.EmailComboBox_Leave);
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(292, 222);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(30, 13);
            this.ComLabel.TabIndex = 22;
            this.ComLabel.Text = ".com";
            // 
            // DependantJobCodeLabel
            // 
            this.DependantJobCodeLabel.AutoSize = true;
            this.DependantJobCodeLabel.Location = new System.Drawing.Point(12, 344);
            this.DependantJobCodeLabel.Name = "DependantJobCodeLabel";
            this.DependantJobCodeLabel.Size = new System.Drawing.Size(108, 13);
            this.DependantJobCodeLabel.TabIndex = 23;
            this.DependantJobCodeLabel.Text = "Dependant Job Code";
            // 
            // FirstNameMaskedTextBox
            // 
            this.FirstNameMaskedTextBox.Location = new System.Drawing.Point(127, 9);
            this.FirstNameMaskedTextBox.Mask = "LLLLLLLLLL";
            this.FirstNameMaskedTextBox.Name = "FirstNameMaskedTextBox";
            this.FirstNameMaskedTextBox.PromptChar = ' ';
            this.FirstNameMaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.FirstNameMaskedTextBox.TabIndex = 25;
            this.FirstNameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FirstNameMaskedTextBox_MaskInputRejected);
            // 
            // LastNameMaskedTextBox
            // 
            this.LastNameMaskedTextBox.BeepOnError = true;
            this.LastNameMaskedTextBox.Location = new System.Drawing.Point(127, 40);
            this.LastNameMaskedTextBox.Mask = "LLLLLLLLLL";
            this.LastNameMaskedTextBox.Name = "LastNameMaskedTextBox";
            this.LastNameMaskedTextBox.PromptChar = ' ';
            this.LastNameMaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.LastNameMaskedTextBox.TabIndex = 26;
            this.LastNameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.LastNameMaskedTextBox_MaskInputRejected);
            // 
            // DependantSSNMaskedTextBox
            // 
            this.DependantSSNMaskedTextBox.BeepOnError = true;
            this.DependantSSNMaskedTextBox.Location = new System.Drawing.Point(127, 308);
            this.DependantSSNMaskedTextBox.Mask = "000000000";
            this.DependantSSNMaskedTextBox.Name = "DependantSSNMaskedTextBox";
            this.DependantSSNMaskedTextBox.PromptChar = ' ';
            this.DependantSSNMaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.DependantSSNMaskedTextBox.TabIndex = 28;
            this.DependantSSNMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DependantSSNMaskedTextBox_MaskInputRejected);
            this.DependantSSNMaskedTextBox.Leave += new System.EventHandler(this.DependantSSNMaskedTextBox_Leave);
            // 
            // JobCodeMaskedTextBox
            // 
            this.JobCodeMaskedTextBox.BeepOnError = true;
            this.JobCodeMaskedTextBox.Location = new System.Drawing.Point(127, 341);
            this.JobCodeMaskedTextBox.Mask = "LLL0000";
            this.JobCodeMaskedTextBox.Name = "JobCodeMaskedTextBox";
            this.JobCodeMaskedTextBox.PromptChar = ' ';
            this.JobCodeMaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.JobCodeMaskedTextBox.TabIndex = 29;
            this.JobCodeMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.JobCodeMaskedTextBox_MaskInputRejected);
            this.JobCodeMaskedTextBox.Leave += new System.EventHandler(this.JobCodeMaskedTextBox_Leave_1);
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(12, 278);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(29, 13);
            this.SSNLabel.TabIndex = 31;
            this.SSNLabel.Text = "SSN";
            // 
            // SSNMaskedTextBox
            // 
            this.SSNMaskedTextBox.BeepOnError = true;
            this.SSNMaskedTextBox.Location = new System.Drawing.Point(127, 278);
            this.SSNMaskedTextBox.Mask = "000000000";
            this.SSNMaskedTextBox.Name = "SSNMaskedTextBox";
            this.SSNMaskedTextBox.PromptChar = ' ';
            this.SSNMaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.SSNMaskedTextBox.TabIndex = 32;
            this.SSNMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SSNMaskedTextBox_MaskInputRejected);
            this.SSNMaskedTextBox.Leave += new System.EventHandler(this.SSNMaskedTextBox_Leave);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(127, 142);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(159, 20);
            this.AddressTextBox.TabIndex = 33;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(12, 145);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 34;
            this.AddressLabel.Text = "Address";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 397);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 35;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(334, 448);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.SSNMaskedTextBox);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.JobCodeMaskedTextBox);
            this.Controls.Add(this.DependantSSNMaskedTextBox);
            this.Controls.Add(this.LastNameMaskedTextBox);
            this.Controls.Add(this.FirstNameMaskedTextBox);
            this.Controls.Add(this.DependantJobCodeLabel);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.AtLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DependantLabel);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Label DependantLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.ToolTip DependantToolTip;
        private System.Windows.Forms.ToolTip UserPasswordToolTip;
        private System.Windows.Forms.Label AtLabel;
        private System.Windows.Forms.ComboBox EmailComboBox;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.Label DependantJobCodeLabel;
        private System.Windows.Forms.MaskedTextBox FirstNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox LastNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox DependantSSNMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox JobCodeMaskedTextBox;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.MaskedTextBox SSNMaskedTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button BackButton;
    }
}
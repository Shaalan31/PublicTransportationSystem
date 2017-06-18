namespace DBapplication
{
    partial class AddEmployee
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
            this.SSNLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.MaleradioButton1 = new System.Windows.Forms.RadioButton();
            this.FemaleradioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailAt = new System.Windows.Forms.Label();
            this.ComLabel = new System.Windows.Forms.Label();
            this.JobCodeLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.SupervisorLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.SupervisorComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SalaryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FirstNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.JobCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(33, 18);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(33, 58);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(33, 97);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(29, 13);
            this.SSNLabel.TabIndex = 2;
            this.SSNLabel.Text = "SSN";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(33, 137);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Gender";
            // 
            // MaleradioButton1
            // 
            this.MaleradioButton1.AutoSize = true;
            this.MaleradioButton1.Location = new System.Drawing.Point(155, 137);
            this.MaleradioButton1.Name = "MaleradioButton1";
            this.MaleradioButton1.Size = new System.Drawing.Size(48, 17);
            this.MaleradioButton1.TabIndex = 4;
            this.MaleradioButton1.TabStop = true;
            this.MaleradioButton1.Text = "Male";
            this.MaleradioButton1.UseVisualStyleBackColor = true;
            this.MaleradioButton1.CheckedChanged += new System.EventHandler(this.MaleradioButton1_CheckedChanged);
            // 
            // FemaleradioButton2
            // 
            this.FemaleradioButton2.AutoSize = true;
            this.FemaleradioButton2.Location = new System.Drawing.Point(250, 137);
            this.FemaleradioButton2.Name = "FemaleradioButton2";
            this.FemaleradioButton2.Size = new System.Drawing.Size(59, 17);
            this.FemaleradioButton2.TabIndex = 5;
            this.FemaleradioButton2.TabStop = true;
            this.FemaleradioButton2.Text = "Female";
            this.FemaleradioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // EmailAt
            // 
            this.EmailAt.AutoSize = true;
            this.EmailAt.Location = new System.Drawing.Point(315, 175);
            this.EmailAt.Name = "EmailAt";
            this.EmailAt.Size = new System.Drawing.Size(18, 13);
            this.EmailAt.TabIndex = 7;
            this.EmailAt.Text = "@";
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(468, 172);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(30, 13);
            this.ComLabel.TabIndex = 8;
            this.ComLabel.Text = ".com";
            // 
            // JobCodeLabel
            // 
            this.JobCodeLabel.AutoSize = true;
            this.JobCodeLabel.Location = new System.Drawing.Point(33, 256);
            this.JobCodeLabel.Name = "JobCodeLabel";
            this.JobCodeLabel.Size = new System.Drawing.Size(52, 13);
            this.JobCodeLabel.TabIndex = 9;
            this.JobCodeLabel.Text = "Job Code";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(33, 300);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.SalaryLabel.TabIndex = 10;
            this.SalaryLabel.Text = "Salary";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(33, 341);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 11;
            this.StartDateLabel.Text = "Start Date";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(33, 379);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 12;
            this.DepartmentLabel.Text = "Department";
            // 
            // SupervisorLabel
            // 
            this.SupervisorLabel.AutoSize = true;
            this.SupervisorLabel.Location = new System.Drawing.Point(33, 429);
            this.SupervisorLabel.Name = "SupervisorLabel";
            this.SupervisorLabel.Size = new System.Drawing.Size(57, 13);
            this.SupervisorLabel.TabIndex = 13;
            this.SupervisorLabel.Text = "Supervisor";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(155, 172);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(154, 20);
            this.EmailTextBox.TabIndex = 17;
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(33, 217);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(54, 13);
            this.BirthDateLabel.TabIndex = 20;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(155, 217);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.BirthDateDateTimePicker.TabIndex = 21;
            this.BirthDateDateTimePicker.ValueChanged += new System.EventHandler(this.BirthDateDateTimePicker_ValueChanged);
            // 
            // StartDateDateTimePicker
            // 
            this.StartDateDateTimePicker.Location = new System.Drawing.Point(155, 341);
            this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
            this.StartDateDateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.StartDateDateTimePicker.TabIndex = 22;
            this.StartDateDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateDateTimePicker_ValueChanged);
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Items.AddRange(new object[] {
            "yahoo",
            "hotmail",
            "gmail",
            "outlook",
            "live"});
            this.EmailComboBox.Location = new System.Drawing.Point(341, 171);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmailComboBox.TabIndex = 23;
            this.EmailComboBox.SelectedIndexChanged += new System.EventHandler(this.EmailComboBox_SelectedIndexChanged);
            this.EmailComboBox.Leave += new System.EventHandler(this.EmailComboBox_Leave);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(155, 379);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(178, 21);
            this.DepartmentComboBox.TabIndex = 24;
            // 
            // SupervisorComboBox
            // 
            this.SupervisorComboBox.FormattingEnabled = true;
            this.SupervisorComboBox.Location = new System.Drawing.Point(155, 429);
            this.SupervisorComboBox.Name = "SupervisorComboBox";
            this.SupervisorComboBox.Size = new System.Drawing.Size(178, 21);
            this.SupervisorComboBox.TabIndex = 25;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(36, 477);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(423, 477);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SalaryMaskedTextBox
            // 
            this.SalaryMaskedTextBox.BeepOnError = true;
            this.SalaryMaskedTextBox.Location = new System.Drawing.Point(155, 300);
            this.SalaryMaskedTextBox.Mask = "00000";
            this.SalaryMaskedTextBox.Name = "SalaryMaskedTextBox";
            this.SalaryMaskedTextBox.PromptChar = ' ';
            this.SalaryMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.SalaryMaskedTextBox.TabIndex = 28;
            this.SalaryMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SalaryMaskedTextBox_MaskInputRejected);
            // 
            // SSNMaskedTextBox
            // 
            this.SSNMaskedTextBox.BeepOnError = true;
            this.SSNMaskedTextBox.Location = new System.Drawing.Point(155, 97);
            this.SSNMaskedTextBox.Mask = "000000000";
            this.SSNMaskedTextBox.Name = "SSNMaskedTextBox";
            this.SSNMaskedTextBox.PromptChar = ' ';
            this.SSNMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.SSNMaskedTextBox.TabIndex = 29;
            this.SSNMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SSNMaskedTextBox_MaskInputRejected);
            this.SSNMaskedTextBox.Leave += new System.EventHandler(this.SSNMaskedTextBox_Leave);
            // 
            // FirstNameMaskedTextBox
            // 
            this.FirstNameMaskedTextBox.BeepOnError = true;
            this.FirstNameMaskedTextBox.Location = new System.Drawing.Point(155, 18);
            this.FirstNameMaskedTextBox.Mask = "LLLLLLLLLL";
            this.FirstNameMaskedTextBox.Name = "FirstNameMaskedTextBox";
            this.FirstNameMaskedTextBox.PromptChar = ' ';
            this.FirstNameMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.FirstNameMaskedTextBox.TabIndex = 30;
            this.FirstNameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FirstNameMaskedTextBox_MaskInputRejected);
            // 
            // LastNameMaskedTextBox
            // 
            this.LastNameMaskedTextBox.BeepOnError = true;
            this.LastNameMaskedTextBox.Location = new System.Drawing.Point(155, 58);
            this.LastNameMaskedTextBox.Mask = "LLLLLLLLLL";
            this.LastNameMaskedTextBox.Name = "LastNameMaskedTextBox";
            this.LastNameMaskedTextBox.PromptChar = ' ';
            this.LastNameMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.LastNameMaskedTextBox.TabIndex = 31;
            this.LastNameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.LastNameMaskedTextBox_MaskInputRejected);
            // 
            // JobCodeMaskedTextBox
            // 
            this.JobCodeMaskedTextBox.BeepOnError = true;
            this.JobCodeMaskedTextBox.Location = new System.Drawing.Point(155, 256);
            this.JobCodeMaskedTextBox.Mask = "LLL0000";
            this.JobCodeMaskedTextBox.Name = "JobCodeMaskedTextBox";
            this.JobCodeMaskedTextBox.PromptChar = ' ';
            this.JobCodeMaskedTextBox.Size = new System.Drawing.Size(178, 20);
            this.JobCodeMaskedTextBox.TabIndex = 32;
            this.JobCodeMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.JobCodeMaskedTextBox_MaskInputRejected);
            this.JobCodeMaskedTextBox.Leave += new System.EventHandler(this.JobCodeMaskedTextBox_Leave);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(552, 527);
            this.Controls.Add(this.JobCodeMaskedTextBox);
            this.Controls.Add(this.LastNameMaskedTextBox);
            this.Controls.Add(this.FirstNameMaskedTextBox);
            this.Controls.Add(this.SSNMaskedTextBox);
            this.Controls.Add(this.SalaryMaskedTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.StartDateDateTimePicker);
            this.Controls.Add(this.BirthDateDateTimePicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SupervisorLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.JobCodeLabel);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.EmailAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FemaleradioButton2);
            this.Controls.Add(this.MaleradioButton1);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton MaleradioButton1;
        private System.Windows.Forms.RadioButton FemaleradioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailAt;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.Label JobCodeLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label SupervisorLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker BirthDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
        private System.Windows.Forms.ComboBox EmailComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox SupervisorComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox SalaryMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox SSNMaskedTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox FirstNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox LastNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox JobCodeMaskedTextBox;
    }
}
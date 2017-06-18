namespace DBapplication
{
    partial class UpdateEmployee
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
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeTextBox = new System.Windows.Forms.ComboBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SupervisorLabel = new System.Windows.Forms.Label();
            this.SupervisorComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SalaryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(26, 42);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(53, 13);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.FormattingEnabled = true;
            this.EmployeeTextBox.Location = new System.Drawing.Point(114, 42);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeeTextBox.TabIndex = 1;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(26, 87);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.SalaryLabel.TabIndex = 2;
            this.SalaryLabel.Text = "Salary";
            // 
            // SupervisorLabel
            // 
            this.SupervisorLabel.AutoSize = true;
            this.SupervisorLabel.Location = new System.Drawing.Point(26, 137);
            this.SupervisorLabel.Name = "SupervisorLabel";
            this.SupervisorLabel.Size = new System.Drawing.Size(57, 13);
            this.SupervisorLabel.TabIndex = 6;
            this.SupervisorLabel.Text = "Supervisor";
            // 
            // SupervisorComboBox
            // 
            this.SupervisorComboBox.FormattingEnabled = true;
            this.SupervisorComboBox.Location = new System.Drawing.Point(114, 137);
            this.SupervisorComboBox.Name = "SupervisorComboBox";
            this.SupervisorComboBox.Size = new System.Drawing.Size(121, 21);
            this.SupervisorComboBox.TabIndex = 7;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(29, 214);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(259, 214);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SalaryMaskedTextBox
            // 
            this.SalaryMaskedTextBox.BeepOnError = true;
            this.SalaryMaskedTextBox.Location = new System.Drawing.Point(114, 87);
            this.SalaryMaskedTextBox.Mask = "00000";
            this.SalaryMaskedTextBox.Name = "SalaryMaskedTextBox";
            this.SalaryMaskedTextBox.PromptChar = ' ';
            this.SalaryMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.SalaryMaskedTextBox.TabIndex = 10;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(259, 42);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(373, 252);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SalaryMaskedTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.SupervisorLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.EmployeeLabel);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox EmployeeTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label SupervisorLabel;
        private System.Windows.Forms.ComboBox SupervisorComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.MaskedTextBox SalaryMaskedTextBox;
        private System.Windows.Forms.Button LoadButton;
    }
}
namespace DBapplication
{
    partial class DeleteEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(141, 47);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeeComboBox.TabIndex = 1;
            this.EmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeComboBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 216);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(186, 216);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(282, 264);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
namespace DBapplication
{
    partial class HRStatistics
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
            this.TotalEmployeesLabel = new System.Windows.Forms.Label();
            this.CountEmployeesLabel = new System.Windows.Forms.Label();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.FindButton = new System.Windows.Forms.Button();
            this.TotalEmployeesAtCertainDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CountDateLabel = new System.Windows.Forms.Label();
            this.FindButton2 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalEmployeesLabel
            // 
            this.TotalEmployeesLabel.AutoSize = true;
            this.TotalEmployeesLabel.Location = new System.Drawing.Point(16, 34);
            this.TotalEmployeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalEmployeesLabel.Name = "TotalEmployeesLabel";
            this.TotalEmployeesLabel.Size = new System.Drawing.Size(85, 13);
            this.TotalEmployeesLabel.TabIndex = 0;
            this.TotalEmployeesLabel.Text = "Total Employees";
            // 
            // CountEmployeesLabel
            // 
            this.CountEmployeesLabel.AutoSize = true;
            this.CountEmployeesLabel.Location = new System.Drawing.Point(182, 34);
            this.CountEmployeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountEmployeesLabel.Name = "CountEmployeesLabel";
            this.CountEmployeesLabel.Size = new System.Drawing.Size(35, 13);
            this.CountEmployeesLabel.TabIndex = 1;
            this.CountEmployeesLabel.Text = "Count";
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(19, 73);
            this.MaleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(53, 17);
            this.MaleRadioButton.TabIndex = 2;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Males";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(87, 73);
            this.FemaleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(64, 17);
            this.FemaleRadioButton.TabIndex = 3;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Females";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(165, 73);
            this.AllRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.AllRadioButton.TabIndex = 4;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(302, 72);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(56, 19);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click_1);
            // 
            // TotalEmployeesAtCertainDateLabel
            // 
            this.TotalEmployeesAtCertainDateLabel.AutoSize = true;
            this.TotalEmployeesAtCertainDateLabel.Location = new System.Drawing.Point(16, 135);
            this.TotalEmployeesAtCertainDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalEmployeesAtCertainDateLabel.Name = "TotalEmployeesAtCertainDateLabel";
            this.TotalEmployeesAtCertainDateLabel.Size = new System.Drawing.Size(181, 13);
            this.TotalEmployeesAtCertainDateLabel.TabIndex = 6;
            this.TotalEmployeesAtCertainDateLabel.Text = "Employees Employed From The Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 170);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // CountDateLabel
            // 
            this.CountDateLabel.AutoSize = true;
            this.CountDateLabel.Location = new System.Drawing.Point(232, 135);
            this.CountDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountDateLabel.Name = "CountDateLabel";
            this.CountDateLabel.Size = new System.Drawing.Size(41, 13);
            this.CountDateLabel.TabIndex = 8;
            this.CountDateLabel.Text = "Count2";
            // 
            // FindButton2
            // 
            this.FindButton2.Location = new System.Drawing.Point(302, 171);
            this.FindButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindButton2.Name = "FindButton2";
            this.FindButton2.Size = new System.Drawing.Size(56, 19);
            this.FindButton2.TabIndex = 9;
            this.FindButton2.Text = "Find";
            this.FindButton2.UseVisualStyleBackColor = true;
            this.FindButton2.Click += new System.EventHandler(this.FindButton2_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(19, 260);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 19);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HRStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(495, 319);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FindButton2);
            this.Controls.Add(this.CountDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TotalEmployeesAtCertainDateLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AllRadioButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.CountEmployeesLabel);
            this.Controls.Add(this.TotalEmployeesLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HRStatistics";
            this.Text = "HRStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalEmployeesLabel;
        private System.Windows.Forms.Label CountEmployeesLabel;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton AllRadioButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label TotalEmployeesAtCertainDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label CountDateLabel;
        private System.Windows.Forms.Button FindButton2;
        private System.Windows.Forms.Button BackButton;
    }
}
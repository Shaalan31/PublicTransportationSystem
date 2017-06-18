namespace DBapplication
{
    partial class ContactingMaintenance
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
            this.NameOfCompanyLabel = new System.Windows.Forms.Label();
            this.NameOfCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.MaintenanceMsgComboBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CompanyNumberLabel = new System.Windows.Forms.Label();
            this.TransportationLabel = new System.Windows.Forms.Label();
            this.TransportationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameOfCompanyLabel
            // 
            this.NameOfCompanyLabel.AutoSize = true;
            this.NameOfCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfCompanyLabel.Location = new System.Drawing.Point(33, 33);
            this.NameOfCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfCompanyLabel.Name = "NameOfCompanyLabel";
            this.NameOfCompanyLabel.Size = new System.Drawing.Size(142, 17);
            this.NameOfCompanyLabel.TabIndex = 0;
            this.NameOfCompanyLabel.Text = "Name Of Company";
            // 
            // NameOfCompanyComboBox
            // 
            this.NameOfCompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfCompanyComboBox.FormattingEnabled = true;
            this.NameOfCompanyComboBox.Location = new System.Drawing.Point(208, 27);
            this.NameOfCompanyComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameOfCompanyComboBox.Name = "NameOfCompanyComboBox";
            this.NameOfCompanyComboBox.Size = new System.Drawing.Size(152, 25);
            this.NameOfCompanyComboBox.TabIndex = 1;
            this.NameOfCompanyComboBox.DisplayMemberChanged += new System.EventHandler(this.NameOfCompanyComboBox_DisplayMemberChanged);
            this.NameOfCompanyComboBox.ValueMemberChanged += new System.EventHandler(this.NameOfCompanyComboBox_ValueMemberChanged);
            this.NameOfCompanyComboBox.SelectedValueChanged += new System.EventHandler(this.NameOfCompanyComboBox_SelectedValueChanged);
            this.NameOfCompanyComboBox.Leave += new System.EventHandler(this.NameOfCompanyComboBox_Leave);
            // 
            // MaintenanceMsgComboBox
            // 
            this.MaintenanceMsgComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceMsgComboBox.Location = new System.Drawing.Point(35, 117);
            this.MaintenanceMsgComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaintenanceMsgComboBox.Name = "MaintenanceMsgComboBox";
            this.MaintenanceMsgComboBox.Size = new System.Drawing.Size(508, 111);
            this.MaintenanceMsgComboBox.TabIndex = 3;
            this.MaintenanceMsgComboBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(486, 253);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(56, 21);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CompanyNumberLabel
            // 
            this.CompanyNumberLabel.AutoSize = true;
            this.CompanyNumberLabel.BackColor = System.Drawing.Color.Firebrick;
            this.CompanyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNumberLabel.Location = new System.Drawing.Point(427, 33);
            this.CompanyNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyNumberLabel.Name = "CompanyNumberLabel";
            this.CompanyNumberLabel.Size = new System.Drawing.Size(115, 17);
            this.CompanyNumberLabel.TabIndex = 5;
            this.CompanyNumberLabel.Text = "Phone Number";
            // 
            // TransportationLabel
            // 
            this.TransportationLabel.AutoSize = true;
            this.TransportationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportationLabel.Location = new System.Drawing.Point(33, 81);
            this.TransportationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TransportationLabel.Name = "TransportationLabel";
            this.TransportationLabel.Size = new System.Drawing.Size(115, 17);
            this.TransportationLabel.TabIndex = 6;
            this.TransportationLabel.Text = "Transportation";
            // 
            // TransportationComboBox
            // 
            this.TransportationComboBox.FormattingEnabled = true;
            this.TransportationComboBox.Location = new System.Drawing.Point(208, 81);
            this.TransportationComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransportationComboBox.Name = "TransportationComboBox";
            this.TransportationComboBox.Size = new System.Drawing.Size(152, 21);
            this.TransportationComboBox.TabIndex = 7;
            // 
            // ContactingMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(586, 297);
            this.Controls.Add(this.TransportationComboBox);
            this.Controls.Add(this.TransportationLabel);
            this.Controls.Add(this.CompanyNumberLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MaintenanceMsgComboBox);
            this.Controls.Add(this.NameOfCompanyComboBox);
            this.Controls.Add(this.NameOfCompanyLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContactingMaintenance";
            this.Text = "ContactingMaintenance";
            this.Load += new System.EventHandler(this.ContactingMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfCompanyLabel;
        private System.Windows.Forms.ComboBox NameOfCompanyComboBox;
        private System.Windows.Forms.RichTextBox MaintenanceMsgComboBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label CompanyNumberLabel;
        private System.Windows.Forms.Label TransportationLabel;
        private System.Windows.Forms.ComboBox TransportationComboBox;
    }
}
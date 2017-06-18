namespace DBapplication
{
    partial class EditInformation
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LabelAt = new System.Windows.Forms.Label();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.ComLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(50, 31);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(138, 97);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(138, 20);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(50, 96);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // LabelAt
            // 
            this.LabelAt.AutoSize = true;
            this.LabelAt.Location = new System.Drawing.Point(282, 104);
            this.LabelAt.Name = "LabelAt";
            this.LabelAt.Size = new System.Drawing.Size(18, 13);
            this.LabelAt.TabIndex = 4;
            this.LabelAt.Text = "@";
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
            this.EmailComboBox.Location = new System.Drawing.Point(306, 97);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(90, 21);
            this.EmailComboBox.TabIndex = 5;
            this.EmailComboBox.SelectedIndexChanged += new System.EventHandler(this.EmailComboBox_SelectedIndexChanged);
            this.EmailComboBox.Leave += new System.EventHandler(this.EmailComboBox_Leave);
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(405, 104);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(30, 13);
            this.ComLabel.TabIndex = 6;
            this.ComLabel.Text = ".com";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(53, 158);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(320, 158);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(138, 31);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(138, 20);
            this.AddressTextBox.TabIndex = 10;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // EditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.LabelAt);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Name = "EditInformation";
            this.Text = "EditInformation";
            this.Load += new System.EventHandler(this.EditInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LabelAt;
        private System.Windows.Forms.ComboBox EmailComboBox;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AddressTextBox;
    }
}
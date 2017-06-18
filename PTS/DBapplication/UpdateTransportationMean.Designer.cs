namespace DBapplication
{
    partial class UpdateTransportationMean
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
            this.TransportationCode_IDComboBox = new System.Windows.Forms.ComboBox();
            this.TransportationLabel = new System.Windows.Forms.Label();
            this.AirConditionLabel = new System.Windows.Forms.Label();
            this.FareLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CapacityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FareMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TransportationCode_IDComboBox
            // 
            this.TransportationCode_IDComboBox.FormattingEnabled = true;
            this.TransportationCode_IDComboBox.Location = new System.Drawing.Point(127, 34);
            this.TransportationCode_IDComboBox.Name = "TransportationCode_IDComboBox";
            this.TransportationCode_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.TransportationCode_IDComboBox.TabIndex = 0;
            this.TransportationCode_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportationCode_IDComboBox_SelectedIndexChanged);
            // 
            // TransportationLabel
            // 
            this.TransportationLabel.AutoSize = true;
            this.TransportationLabel.Location = new System.Drawing.Point(12, 34);
            this.TransportationLabel.Name = "TransportationLabel";
            this.TransportationLabel.Size = new System.Drawing.Size(75, 13);
            this.TransportationLabel.TabIndex = 1;
            this.TransportationLabel.Text = "Transportation";
            // 
            // AirConditionLabel
            // 
            this.AirConditionLabel.AutoSize = true;
            this.AirConditionLabel.Location = new System.Drawing.Point(12, 120);
            this.AirConditionLabel.Name = "AirConditionLabel";
            this.AirConditionLabel.Size = new System.Drawing.Size(84, 13);
            this.AirConditionLabel.TabIndex = 2;
            this.AirConditionLabel.Text = "Air Conditioned?";
            // 
            // FareLabel
            // 
            this.FareLabel.AutoSize = true;
            this.FareLabel.Location = new System.Drawing.Point(12, 154);
            this.FareLabel.Name = "FareLabel";
            this.FareLabel.Size = new System.Drawing.Size(28, 13);
            this.FareLabel.TabIndex = 3;
            this.FareLabel.Text = "Fare";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(12, 83);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(48, 13);
            this.CapacityLabel.TabIndex = 4;
            this.CapacityLabel.Text = "Capacity";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(127, 124);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.YesRadioButton.TabIndex = 7;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(205, 124);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.NoRadioButton.TabIndex = 9;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 202);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(173, 202);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CapacityMaskedTextBox
            // 
            this.CapacityMaskedTextBox.BeepOnError = true;
            this.CapacityMaskedTextBox.Location = new System.Drawing.Point(127, 83);
            this.CapacityMaskedTextBox.Mask = "000";
            this.CapacityMaskedTextBox.Name = "CapacityMaskedTextBox";
            this.CapacityMaskedTextBox.PromptChar = ' ';
            this.CapacityMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.CapacityMaskedTextBox.TabIndex = 12;
            this.CapacityMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CapacityMaskedTextBox_MaskInputRejected);
            // 
            // FareMaskedTextBox
            // 
            this.FareMaskedTextBox.BeepOnError = true;
            this.FareMaskedTextBox.Location = new System.Drawing.Point(127, 154);
            this.FareMaskedTextBox.Mask = "0";
            this.FareMaskedTextBox.Name = "FareMaskedTextBox";
            this.FareMaskedTextBox.PromptChar = ' ';
            this.FareMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.FareMaskedTextBox.TabIndex = 13;
            this.FareMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FareMaskedTextBox_MaskInputRejected);
            // 
            // UpdateTransportationMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FareMaskedTextBox);
            this.Controls.Add(this.CapacityMaskedTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.FareLabel);
            this.Controls.Add(this.AirConditionLabel);
            this.Controls.Add(this.TransportationLabel);
            this.Controls.Add(this.TransportationCode_IDComboBox);
            this.Name = "UpdateTransportationMean";
            this.Text = "UpdateTransportationMean";
            this.Load += new System.EventHandler(this.UpdateTransportationMean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TransportationCode_IDComboBox;
        private System.Windows.Forms.Label TransportationLabel;
        private System.Windows.Forms.Label AirConditionLabel;
        private System.Windows.Forms.Label FareLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox CapacityMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox FareMaskedTextBox;
    }
}
namespace DBapplication
{
    partial class AddTransportationMean
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
            this.TransportationCodeLabel = new System.Windows.Forms.Label();
            this.TransportationIDLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.AirConditionLabel = new System.Windows.Forms.Label();
            this.FareLabel = new System.Windows.Forms.Label();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TransportationCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TransportationIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FareMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CapacityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TransportationCodeLabel
            // 
            this.TransportationCodeLabel.AutoSize = true;
            this.TransportationCodeLabel.Location = new System.Drawing.Point(22, 33);
            this.TransportationCodeLabel.Name = "TransportationCodeLabel";
            this.TransportationCodeLabel.Size = new System.Drawing.Size(103, 13);
            this.TransportationCodeLabel.TabIndex = 0;
            this.TransportationCodeLabel.Text = "Transportation Code";
            // 
            // TransportationIDLabel
            // 
            this.TransportationIDLabel.AutoSize = true;
            this.TransportationIDLabel.Location = new System.Drawing.Point(22, 69);
            this.TransportationIDLabel.Name = "TransportationIDLabel";
            this.TransportationIDLabel.Size = new System.Drawing.Size(89, 13);
            this.TransportationIDLabel.TabIndex = 1;
            this.TransportationIDLabel.Text = "Transportation ID";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(22, 100);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(48, 13);
            this.CapacityLabel.TabIndex = 2;
            this.CapacityLabel.Text = "Capacity";
            // 
            // AirConditionLabel
            // 
            this.AirConditionLabel.AutoSize = true;
            this.AirConditionLabel.Location = new System.Drawing.Point(22, 133);
            this.AirConditionLabel.Name = "AirConditionLabel";
            this.AirConditionLabel.Size = new System.Drawing.Size(90, 13);
            this.AirConditionLabel.TabIndex = 3;
            this.AirConditionLabel.Text = "Air Conditioned ? ";
            // 
            // FareLabel
            // 
            this.FareLabel.AutoSize = true;
            this.FareLabel.Location = new System.Drawing.Point(22, 167);
            this.FareLabel.Name = "FareLabel";
            this.FareLabel.Size = new System.Drawing.Size(31, 13);
            this.FareLabel.TabIndex = 4;
            this.FareLabel.Text = "Fare ";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(161, 133);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.YesRadioButton.TabIndex = 10;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            this.YesRadioButton.CheckedChanged += new System.EventHandler(this.YesRadioButton_CheckedChanged);
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(222, 133);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.NoRadioButton.TabIndex = 11;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(25, 216);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(222, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TransportationCodeMaskedTextBox
            // 
            this.TransportationCodeMaskedTextBox.BeepOnError = true;
            this.TransportationCodeMaskedTextBox.Location = new System.Drawing.Point(161, 30);
            this.TransportationCodeMaskedTextBox.Mask = "LLL";
            this.TransportationCodeMaskedTextBox.Name = "TransportationCodeMaskedTextBox";
            this.TransportationCodeMaskedTextBox.PromptChar = ' ';
            this.TransportationCodeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransportationCodeMaskedTextBox.TabIndex = 14;
            this.TransportationCodeMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TransportationCodeMaskedTextBox_MaskInputRejected);
            // 
            // TransportationIDMaskedTextBox
            // 
            this.TransportationIDMaskedTextBox.BeepOnError = true;
            this.TransportationIDMaskedTextBox.Location = new System.Drawing.Point(161, 66);
            this.TransportationIDMaskedTextBox.Mask = "000";
            this.TransportationIDMaskedTextBox.Name = "TransportationIDMaskedTextBox";
            this.TransportationIDMaskedTextBox.PromptChar = ' ';
            this.TransportationIDMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransportationIDMaskedTextBox.TabIndex = 15;
            this.TransportationIDMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TransportationIDMaskedTextBox_MaskInputRejected);
            this.TransportationIDMaskedTextBox.Leave += new System.EventHandler(this.TransportationIDMaskedTextBox_Leave);
            // 
            // FareMaskedTextBox
            // 
            this.FareMaskedTextBox.BeepOnError = true;
            this.FareMaskedTextBox.Location = new System.Drawing.Point(161, 160);
            this.FareMaskedTextBox.Mask = "0";
            this.FareMaskedTextBox.Name = "FareMaskedTextBox";
            this.FareMaskedTextBox.PromptChar = ' ';
            this.FareMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.FareMaskedTextBox.TabIndex = 16;
            this.FareMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FareMaskedTextBox_MaskInputRejected);
            // 
            // CapacityMaskedTextBox
            // 
            this.CapacityMaskedTextBox.BeepOnError = true;
            this.CapacityMaskedTextBox.Location = new System.Drawing.Point(161, 100);
            this.CapacityMaskedTextBox.Mask = "000";
            this.CapacityMaskedTextBox.Name = "CapacityMaskedTextBox";
            this.CapacityMaskedTextBox.PromptChar = ' ';
            this.CapacityMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CapacityMaskedTextBox.TabIndex = 17;
            this.CapacityMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CapacityMaskedTextBox_MaskInputRejected);
            // 
            // AddTransportationMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.CapacityMaskedTextBox);
            this.Controls.Add(this.FareMaskedTextBox);
            this.Controls.Add(this.TransportationIDMaskedTextBox);
            this.Controls.Add(this.TransportationCodeMaskedTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.FareLabel);
            this.Controls.Add(this.AirConditionLabel);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.TransportationIDLabel);
            this.Controls.Add(this.TransportationCodeLabel);
            this.Name = "AddTransportationMean";
            this.Text = "AddTransportationMean";
            this.Load += new System.EventHandler(this.AddTransportationMean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransportationCodeLabel;
        private System.Windows.Forms.Label TransportationIDLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label AirConditionLabel;
        private System.Windows.Forms.Label FareLabel;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox TransportationCodeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TransportationIDMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox FareMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CapacityMaskedTextBox;
    }
}
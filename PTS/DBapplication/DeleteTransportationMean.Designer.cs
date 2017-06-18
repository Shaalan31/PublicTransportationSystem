namespace DBapplication
{
    partial class DeleteTransportationMean
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
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TransportationCode_IDComboBox = new System.Windows.Forms.ComboBox();
            this.TransportationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(23, 206);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(197, 206);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TransportationCode_IDComboBox
            // 
            this.TransportationCode_IDComboBox.FormattingEnabled = true;
            this.TransportationCode_IDComboBox.Location = new System.Drawing.Point(151, 34);
            this.TransportationCode_IDComboBox.Name = "TransportationCode_IDComboBox";
            this.TransportationCode_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.TransportationCode_IDComboBox.TabIndex = 2;
            this.TransportationCode_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportationCode_IDComboBox_SelectedIndexChanged);
            // 
            // TransportationLabel
            // 
            this.TransportationLabel.AutoSize = true;
            this.TransportationLabel.Location = new System.Drawing.Point(20, 37);
            this.TransportationLabel.Name = "TransportationLabel";
            this.TransportationLabel.Size = new System.Drawing.Size(75, 13);
            this.TransportationLabel.TabIndex = 3;
            this.TransportationLabel.Text = "Transportation";
            // 
            // DeleteTransportationMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TransportationLabel);
            this.Controls.Add(this.TransportationCode_IDComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Name = "DeleteTransportationMean";
            this.Text = "DeleteTransportationMean";
            this.Load += new System.EventHandler(this.DeleteTransportationMean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox TransportationCode_IDComboBox;
        private System.Windows.Forms.Label TransportationLabel;
    }
}
namespace DBapplication
{
    partial class ViewEmployees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeesInformationLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmployeesInformationLabel
            // 
            this.EmployeesInformationLabel.AutoSize = true;
            this.EmployeesInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesInformationLabel.Location = new System.Drawing.Point(230, 24);
            this.EmployeesInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeesInformationLabel.Name = "EmployeesInformationLabel";
            this.EmployeesInformationLabel.Size = new System.Drawing.Size(151, 17);
            this.EmployeesInformationLabel.TabIndex = 1;
            this.EmployeesInformationLabel.Text = "Employees Information";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(44, 345);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 19);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(592, 385);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeesInformationLabel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EmployeesInformationLabel;
        private System.Windows.Forms.Button BackButton;
    }
}
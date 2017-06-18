namespace DBapplication
{
    partial class FinanceStatistics
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
            this.TotalOrdersLabel = new System.Windows.Forms.Label();
            this.OrdersCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FindButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CountOrders2 = new System.Windows.Forms.Label();
            this.SalaryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalOrdersLabel
            // 
            this.TotalOrdersLabel.AutoSize = true;
            this.TotalOrdersLabel.Location = new System.Drawing.Point(26, 45);
            this.TotalOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalOrdersLabel.Name = "TotalOrdersLabel";
            this.TotalOrdersLabel.Size = new System.Drawing.Size(65, 13);
            this.TotalOrdersLabel.TabIndex = 0;
            this.TotalOrdersLabel.Text = "Total Orders";
            // 
            // OrdersCount
            // 
            this.OrdersCount.AutoSize = true;
            this.OrdersCount.Location = new System.Drawing.Point(164, 45);
            this.OrdersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrdersCount.Name = "OrdersCount";
            this.OrdersCount.Size = new System.Drawing.Size(83, 13);
            this.OrdersCount.TabIndex = 1;
            this.OrdersCount.Text = "Count Of Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Orders From ";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(127, 106);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.DateTimePicker1.TabIndex = 3;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(294, 110);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "To";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(327, 106);
            this.DateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.DateTimePicker2.TabIndex = 5;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(506, 105);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(56, 19);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(28, 328);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 19);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CountOrders2
            // 
            this.CountOrders2.AutoSize = true;
            this.CountOrders2.Location = new System.Drawing.Point(597, 110);
            this.CountOrders2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountOrders2.Name = "CountOrders2";
            this.CountOrders2.Size = new System.Drawing.Size(92, 13);
            this.CountOrders2.TabIndex = 8;
            this.CountOrders2.Text = "Count Of Orders 2";
            // 
            // SalaryDataGridView
            // 
            this.SalaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryDataGridView.Location = new System.Drawing.Point(28, 171);
            this.SalaryDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalaryDataGridView.Name = "SalaryDataGridView";
            this.SalaryDataGridView.RowTemplate.Height = 24;
            this.SalaryDataGridView.Size = new System.Drawing.Size(448, 126);
            this.SalaryDataGridView.TabIndex = 9;
            // 
            // FinanceStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(730, 379);
            this.Controls.Add(this.SalaryDataGridView);
            this.Controls.Add(this.CountOrders2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersCount);
            this.Controls.Add(this.TotalOrdersLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FinanceStatistics";
            this.Text = "FinanceEmployee";
            this.Load += new System.EventHandler(this.FinanceEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalOrdersLabel;
        private System.Windows.Forms.Label OrdersCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CountOrders2;
        private System.Windows.Forms.DataGridView SalaryDataGridView;
    }
}
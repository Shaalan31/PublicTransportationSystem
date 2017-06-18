namespace DBapplication
{
    partial class CheckMaintenanceReviews
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
            this.DoneDataGridView = new System.Windows.Forms.DataGridView();
            this.NotDoneDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotDoneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoneDataGridView
            // 
            this.DoneDataGridView.BackgroundColor = System.Drawing.Color.Firebrick;
            this.DoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoneDataGridView.Location = new System.Drawing.Point(44, 52);
            this.DoneDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoneDataGridView.Name = "DoneDataGridView";
            this.DoneDataGridView.ReadOnly = true;
            this.DoneDataGridView.RowTemplate.Height = 24;
            this.DoneDataGridView.Size = new System.Drawing.Size(390, 197);
            this.DoneDataGridView.TabIndex = 0;
            // 
            // NotDoneDataGridView
            // 
            this.NotDoneDataGridView.BackgroundColor = System.Drawing.Color.Firebrick;
            this.NotDoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotDoneDataGridView.Location = new System.Drawing.Point(510, 52);
            this.NotDoneDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NotDoneDataGridView.Name = "NotDoneDataGridView";
            this.NotDoneDataGridView.ReadOnly = true;
            this.NotDoneDataGridView.RowTemplate.Height = 24;
            this.NotDoneDataGridView.Size = new System.Drawing.Size(390, 197);
            this.NotDoneDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job Done";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job Not Done Yet";
            // 
            // CheckMaintenanceReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(900, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotDoneDataGridView);
            this.Controls.Add(this.DoneDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckMaintenanceReviews";
            this.Text = "CheckMaintenanceReviews";
            ((System.ComponentModel.ISupportInitialize)(this.DoneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotDoneDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DoneDataGridView;
        private System.Windows.Forms.DataGridView NotDoneDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
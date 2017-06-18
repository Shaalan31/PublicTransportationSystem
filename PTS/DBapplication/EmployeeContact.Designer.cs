namespace DBapplication
{
    partial class EmployeeContact
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInformation = new System.Windows.Forms.ToolTip(this.components);
            this.ContactMaintenanceButton = new System.Windows.Forms.Button();
            this.CheckMaintenanceReviewsButton = new System.Windows.Forms.Button();
            this.ViewStatistics = new System.Windows.Forms.ToolTip(this.components);
            this.EditInformationButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "EmployeeMenuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ContactMaintenanceButton
            // 
            this.ContactMaintenanceButton.Location = new System.Drawing.Point(127, 141);
            this.ContactMaintenanceButton.Name = "ContactMaintenanceButton";
            this.ContactMaintenanceButton.Size = new System.Drawing.Size(148, 23);
            this.ContactMaintenanceButton.TabIndex = 3;
            this.ContactMaintenanceButton.Text = "Contact Maintenance";
            this.EditInformation.SetToolTip(this.ContactMaintenanceButton, "Edit your Address/Email");
            this.ContactMaintenanceButton.UseVisualStyleBackColor = true;
            this.ContactMaintenanceButton.Click += new System.EventHandler(this.MaintenanceButton_Click);
            // 
            // CheckMaintenanceReviewsButton
            // 
            this.CheckMaintenanceReviewsButton.Location = new System.Drawing.Point(127, 198);
            this.CheckMaintenanceReviewsButton.Name = "CheckMaintenanceReviewsButton";
            this.CheckMaintenanceReviewsButton.Size = new System.Drawing.Size(148, 23);
            this.CheckMaintenanceReviewsButton.TabIndex = 6;
            this.CheckMaintenanceReviewsButton.Text = "Check Maintenance Reviews";
            this.EditInformation.SetToolTip(this.CheckMaintenanceReviewsButton, "Edit your Address/Email");
            this.CheckMaintenanceReviewsButton.UseVisualStyleBackColor = true;
            this.CheckMaintenanceReviewsButton.Click += new System.EventHandler(this.CheckMaintenanceReviewsButton_Click);
            // 
            // EditInformationButton
            // 
            this.EditInformationButton.Location = new System.Drawing.Point(127, 248);
            this.EditInformationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditInformationButton.Name = "EditInformationButton";
            this.EditInformationButton.Size = new System.Drawing.Size(148, 25);
            this.EditInformationButton.TabIndex = 7;
            this.EditInformationButton.Text = "Edit Information";
            this.EditInformationButton.UseVisualStyleBackColor = true;
            this.EditInformationButton.Click += new System.EventHandler(this.EditInformationButton_Click);
            // 
            // EmployeeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(398, 375);
            this.Controls.Add(this.EditInformationButton);
            this.Controls.Add(this.CheckMaintenanceReviewsButton);
            this.Controls.Add(this.ContactMaintenanceButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EmployeeContact";
            this.Text = "Employee (Contact)";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip EditInformation;
        private System.Windows.Forms.ToolTip ViewStatistics;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button ContactMaintenanceButton;
        private System.Windows.Forms.Button CheckMaintenanceReviewsButton;
        private System.Windows.Forms.Button EditInformationButton;
    }
}
namespace DBapplication
{
    partial class Admin
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
            this.EditInformationButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.AddTransportationMeanButton = new System.Windows.Forms.Button();
            this.UpdateTransportationMeanButton = new System.Windows.Forms.Button();
            this.DeleteTransportationMeanButton = new System.Windows.Forms.Button();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.EditInformationtoolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ViewStatisticsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.DeleteCompanyButton = new System.Windows.Forms.Button();
            this.UpdateCompanyButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // EditInformationButton
            // 
            this.EditInformationButton.Location = new System.Drawing.Point(86, 46);
            this.EditInformationButton.Name = "EditInformationButton";
            this.EditInformationButton.Size = new System.Drawing.Size(159, 23);
            this.EditInformationButton.TabIndex = 1;
            this.EditInformationButton.Text = "Edit Information";
            this.EditInformationtoolTip1.SetToolTip(this.EditInformationButton, "Edit Email/Address");
            this.EditInformationButton.UseVisualStyleBackColor = true;
            this.EditInformationButton.Click += new System.EventHandler(this.EditInformationButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(86, 75);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(159, 23);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(86, 104);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(159, 23);
            this.UpdateEmployeeButton.TabIndex = 3;
            this.UpdateEmployeeButton.Text = "UpdateEmployee";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(86, 133);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(159, 23);
            this.DeleteEmployeeButton.TabIndex = 4;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // AddTransportationMeanButton
            // 
            this.AddTransportationMeanButton.Location = new System.Drawing.Point(86, 162);
            this.AddTransportationMeanButton.Name = "AddTransportationMeanButton";
            this.AddTransportationMeanButton.Size = new System.Drawing.Size(159, 23);
            this.AddTransportationMeanButton.TabIndex = 5;
            this.AddTransportationMeanButton.Text = "Add Transportation Mean";
            this.AddTransportationMeanButton.UseVisualStyleBackColor = true;
            this.AddTransportationMeanButton.Click += new System.EventHandler(this.AddTransportationMeanButton_Click);
            // 
            // UpdateTransportationMeanButton
            // 
            this.UpdateTransportationMeanButton.Location = new System.Drawing.Point(86, 191);
            this.UpdateTransportationMeanButton.Name = "UpdateTransportationMeanButton";
            this.UpdateTransportationMeanButton.Size = new System.Drawing.Size(159, 23);
            this.UpdateTransportationMeanButton.TabIndex = 6;
            this.UpdateTransportationMeanButton.Text = "Update Transportation Mean";
            this.UpdateTransportationMeanButton.UseVisualStyleBackColor = true;
            this.UpdateTransportationMeanButton.Click += new System.EventHandler(this.UpdateTransportationMeanButton_Click);
            // 
            // DeleteTransportationMeanButton
            // 
            this.DeleteTransportationMeanButton.Location = new System.Drawing.Point(86, 220);
            this.DeleteTransportationMeanButton.Name = "DeleteTransportationMeanButton";
            this.DeleteTransportationMeanButton.Size = new System.Drawing.Size(159, 23);
            this.DeleteTransportationMeanButton.TabIndex = 7;
            this.DeleteTransportationMeanButton.Text = "Delete Transportation Mean";
            this.DeleteTransportationMeanButton.UseVisualStyleBackColor = true;
            this.DeleteTransportationMeanButton.Click += new System.EventHandler(this.DeleteTransportationMeanButton_Click);
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(86, 336);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(159, 23);
            this.AddEdgeButton.TabIndex = 8;
            this.AddEdgeButton.Text = "Add Edge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(86, 249);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(159, 23);
            this.AddCompanyButton.TabIndex = 10;
            this.AddCompanyButton.Text = "Add Company";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
            // 
            // DeleteCompanyButton
            // 
            this.DeleteCompanyButton.Location = new System.Drawing.Point(86, 278);
            this.DeleteCompanyButton.Name = "DeleteCompanyButton";
            this.DeleteCompanyButton.Size = new System.Drawing.Size(159, 23);
            this.DeleteCompanyButton.TabIndex = 12;
            this.DeleteCompanyButton.Text = "Delete Company";
            this.DeleteCompanyButton.UseVisualStyleBackColor = true;
            this.DeleteCompanyButton.Click += new System.EventHandler(this.DeleteCompanyButton_Click);
            // 
            // UpdateCompanyButton
            // 
            this.UpdateCompanyButton.Location = new System.Drawing.Point(86, 307);
            this.UpdateCompanyButton.Name = "UpdateCompanyButton";
            this.UpdateCompanyButton.Size = new System.Drawing.Size(159, 23);
            this.UpdateCompanyButton.TabIndex = 13;
            this.UpdateCompanyButton.Text = "Update Company";
            this.UpdateCompanyButton.UseVisualStyleBackColor = true;
            this.UpdateCompanyButton.Click += new System.EventHandler(this.UpdateCompanyButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(324, 408);
            this.Controls.Add(this.UpdateCompanyButton);
            this.Controls.Add(this.DeleteCompanyButton);
            this.Controls.Add(this.AddCompanyButton);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.DeleteTransportationMeanButton);
            this.Controls.Add(this.UpdateTransportationMeanButton);
            this.Controls.Add(this.AddTransportationMeanButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EditInformationButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button EditInformationButton;
        private System.Windows.Forms.ToolTip EditInformationtoolTip1;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button AddTransportationMeanButton;
        private System.Windows.Forms.Button UpdateTransportationMeanButton;
        private System.Windows.Forms.Button DeleteTransportationMeanButton;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.ToolTip ViewStatisticsToolTip;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.Button DeleteCompanyButton;
        private System.Windows.Forms.Button UpdateCompanyButton;
    }
}
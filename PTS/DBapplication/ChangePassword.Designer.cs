namespace DBapplication
{
    partial class ChangePassword
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
            this.EnterCurrentPassword = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EnterNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterCurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterCurrentPassword
            // 
            this.EnterCurrentPassword.AutoSize = true;
            this.EnterCurrentPassword.Location = new System.Drawing.Point(12, 33);
            this.EnterCurrentPassword.Name = "EnterCurrentPassword";
            this.EnterCurrentPassword.Size = new System.Drawing.Size(118, 13);
            this.EnterCurrentPassword.TabIndex = 0;
            this.EnterCurrentPassword.Text = "Enter Current Password";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 80);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(106, 13);
            this.NewPasswordLabel.TabIndex = 1;
            this.NewPasswordLabel.Text = "Enter New Password";
            // 
            // ConfirmNewPasswordLabel
            // 
            this.ConfirmNewPasswordLabel.AutoSize = true;
            this.ConfirmNewPasswordLabel.Location = new System.Drawing.Point(12, 124);
            this.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel";
            this.ConfirmNewPasswordLabel.Size = new System.Drawing.Size(116, 13);
            this.ConfirmNewPasswordLabel.TabIndex = 2;
            this.ConfirmNewPasswordLabel.Text = "Confirm New Password";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(281, 210);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 4;
            this.ProceedButton.Text = "Proceed>";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(206, 165);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EnterNewPasswordTextBox
            // 
            this.EnterNewPasswordTextBox.Location = new System.Drawing.Point(195, 73);
            this.EnterNewPasswordTextBox.Name = "EnterNewPasswordTextBox";
            this.EnterNewPasswordTextBox.PasswordChar = '*';
            this.EnterNewPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterNewPasswordTextBox.TabIndex = 7;
            this.EnterNewPasswordTextBox.Leave += new System.EventHandler(this.EnterNewPasswordTextBox_Leave);
            // 
            // ConfirmNewPasswordTextBox
            // 
            this.ConfirmNewPasswordTextBox.Location = new System.Drawing.Point(195, 117);
            this.ConfirmNewPasswordTextBox.Name = "ConfirmNewPasswordTextBox";
            this.ConfirmNewPasswordTextBox.PasswordChar = '*';
            this.ConfirmNewPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmNewPasswordTextBox.TabIndex = 8;
            this.ConfirmNewPasswordTextBox.Leave += new System.EventHandler(this.ConfirmNewPasswordTextBox_Leave);
            // 
            // EnterCurrentPasswordTextBox
            // 
            this.EnterCurrentPasswordTextBox.Location = new System.Drawing.Point(195, 30);
            this.EnterCurrentPasswordTextBox.Name = "EnterCurrentPasswordTextBox";
            this.EnterCurrentPasswordTextBox.PasswordChar = '*';
            this.EnterCurrentPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterCurrentPasswordTextBox.TabIndex = 6;
            this.EnterCurrentPasswordTextBox.Leave += new System.EventHandler(this.EnterCurrentPasswordTextBox_Leave);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ConfirmNewPasswordTextBox);
            this.Controls.Add(this.EnterNewPasswordTextBox);
            this.Controls.Add(this.EnterCurrentPasswordTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmNewPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.EnterCurrentPassword);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterCurrentPassword;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ConfirmNewPasswordLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox EnterNewPasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmNewPasswordTextBox;
        private System.Windows.Forms.TextBox EnterCurrentPasswordTextBox;
    }
}
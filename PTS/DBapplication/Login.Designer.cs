namespace DBapplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignUpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.IfCompanyLabel = new System.Windows.Forms.Label();
            this.ClickHereLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(342, 60);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(466, 58);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_pass.TabIndex = 2;
            this.TxtBx_pass.TextChanged += new System.EventHandler(this.TxtBx_pass_TextChanged);
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoEllipsis = true;
            this.Btn_Login.Location = new System.Drawing.Point(402, 99);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(99, 23);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Tag = "";
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(466, 19);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_username.TabIndex = 1;
            this.TxtBx_username.TextChanged += new System.EventHandler(this.TxtBx_username_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(340, 20);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 16);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.AutoEllipsis = true;
            this.SignUpButton.Location = new System.Drawing.Point(402, 166);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(99, 23);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Tag = "";
            this.SignUpButton.Text = "Sign Up";
            this.SignUpToolTip.SetToolTip(this.SignUpButton, "Create a new account");
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Location = new System.Drawing.Point(420, 254);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(29, 13);
            this.HelpLinkLabel.TabIndex = 6;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
            this.HelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLinkLabel_LinkClicked);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.Location = new System.Drawing.Point(338, 135);
            this.HelpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(277, 15);
            this.HelpLabel.TabIndex = 7;
            this.HelpLabel.Text = "If you don\'t have an account,click the button below";
            // 
            // IfCompanyLabel
            // 
            this.IfCompanyLabel.AutoSize = true;
            this.IfCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IfCompanyLabel.Location = new System.Drawing.Point(338, 210);
            this.IfCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IfCompanyLabel.Name = "IfCompanyLabel";
            this.IfCompanyLabel.Size = new System.Drawing.Size(71, 15);
            this.IfCompanyLabel.TabIndex = 8;
            this.IfCompanyLabel.Text = "If Company ";
            // 
            // ClickHereLinkLabel
            // 
            this.ClickHereLinkLabel.AutoSize = true;
            this.ClickHereLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ClickHereLinkLabel.Location = new System.Drawing.Point(420, 210);
            this.ClickHereLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClickHereLinkLabel.Name = "ClickHereLinkLabel";
            this.ClickHereLinkLabel.Size = new System.Drawing.Size(56, 13);
            this.ClickHereLinkLabel.TabIndex = 9;
            this.ClickHereLinkLabel.TabStop = true;
            this.ClickHereLinkLabel.Text = "Click Here";
            this.ClickHereLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClickHereLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 275);
            this.Controls.Add(this.ClickHereLinkLabel);
            this.Controls.Add(this.IfCompanyLabel);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.HelpLinkLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "Login";
            this.Text = "UNDERGROUND";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.ToolTip SignUpToolTip;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label IfCompanyLabel;
        private System.Windows.Forms.LinkLabel ClickHereLinkLabel;
    }
}
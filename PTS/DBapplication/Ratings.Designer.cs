namespace DBapplication
{
    partial class Ratings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ratings));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EmailAt = new System.Windows.Forms.Label();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.YESradioButton = new System.Windows.Forms.RadioButton();
            this.NOradioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.oneStar = new System.Windows.Forms.CheckBox();
            this.twoStar = new System.Windows.Forms.CheckBox();
            this.threeStar = new System.Windows.Forms.CheckBox();
            this.fourStar = new System.Windows.Forms.CheckBox();
            this.fiveStar = new System.Windows.Forms.CheckBox();
            this.SuggestionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuggestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you recommend this application to a friend?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "If yes, please enter his/her email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 5;
            // 
            // EmailAt
            // 
            this.EmailAt.AutoSize = true;
            this.EmailAt.Location = new System.Drawing.Point(156, 145);
            this.EmailAt.Name = "EmailAt";
            this.EmailAt.Size = new System.Drawing.Size(18, 13);
            this.EmailAt.TabIndex = 8;
            this.EmailAt.Text = "@";
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Items.AddRange(new object[] {
            "yahoo",
            "hotmail",
            "gmail",
            "outlook",
            "live"});
            this.EmailComboBox.Location = new System.Drawing.Point(180, 141);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmailComboBox.TabIndex = 24;
            this.EmailComboBox.SelectedIndexChanged += new System.EventHandler(this.EmailComboBox_SelectedIndexChanged);
            // 
            // YESradioButton
            // 
            this.YESradioButton.AutoSize = true;
            this.YESradioButton.Location = new System.Drawing.Point(67, 105);
            this.YESradioButton.Name = "YESradioButton";
            this.YESradioButton.Size = new System.Drawing.Size(49, 17);
            this.YESradioButton.TabIndex = 25;
            this.YESradioButton.TabStop = true;
            this.YESradioButton.Text = "YES!";
            this.YESradioButton.UseVisualStyleBackColor = true;
            this.YESradioButton.CheckedChanged += new System.EventHandler(this.YESradioButton_CheckedChanged);
            // 
            // NOradioButton
            // 
            this.NOradioButton.AutoSize = true;
            this.NOradioButton.Location = new System.Drawing.Point(186, 105);
            this.NOradioButton.Name = "NOradioButton";
            this.NOradioButton.Size = new System.Drawing.Size(39, 17);
            this.NOradioButton.TabIndex = 26;
            this.NOradioButton.TabStop = true;
            this.NOradioButton.Text = "No";
            this.NOradioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kindly, rate our app!";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(116, 375);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(109, 23);
            this.Submit.TabIndex = 33;
            this.Submit.Text = "Submit Rating!";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // oneStar
            // 
            this.oneStar.AutoSize = true;
            this.oneStar.Location = new System.Drawing.Point(74, 187);
            this.oneStar.Name = "oneStar";
            this.oneStar.Size = new System.Drawing.Size(15, 14);
            this.oneStar.TabIndex = 34;
            this.oneStar.UseVisualStyleBackColor = true;
            this.oneStar.CheckedChanged += new System.EventHandler(this.oneStar_CheckedChanged);
            // 
            // twoStar
            // 
            this.twoStar.AutoSize = true;
            this.twoStar.Location = new System.Drawing.Point(116, 187);
            this.twoStar.Name = "twoStar";
            this.twoStar.Size = new System.Drawing.Size(15, 14);
            this.twoStar.TabIndex = 35;
            this.twoStar.UseVisualStyleBackColor = true;
            this.twoStar.CheckedChanged += new System.EventHandler(this.twoStar_CheckedChanged);
            // 
            // threeStar
            // 
            this.threeStar.AutoSize = true;
            this.threeStar.Location = new System.Drawing.Point(159, 187);
            this.threeStar.Name = "threeStar";
            this.threeStar.Size = new System.Drawing.Size(15, 14);
            this.threeStar.TabIndex = 36;
            this.threeStar.UseVisualStyleBackColor = true;
            this.threeStar.CheckedChanged += new System.EventHandler(this.threeStar_CheckedChanged_1);
            // 
            // fourStar
            // 
            this.fourStar.AutoSize = true;
            this.fourStar.Location = new System.Drawing.Point(201, 187);
            this.fourStar.Name = "fourStar";
            this.fourStar.Size = new System.Drawing.Size(15, 14);
            this.fourStar.TabIndex = 37;
            this.fourStar.UseVisualStyleBackColor = true;
            this.fourStar.CheckedChanged += new System.EventHandler(this.fourStar_CheckedChanged_1);
            // 
            // fiveStar
            // 
            this.fiveStar.AutoSize = true;
            this.fiveStar.Location = new System.Drawing.Point(241, 187);
            this.fiveStar.Name = "fiveStar";
            this.fiveStar.Size = new System.Drawing.Size(15, 14);
            this.fiveStar.TabIndex = 38;
            this.fiveStar.UseVisualStyleBackColor = true;
            this.fiveStar.CheckedChanged += new System.EventHandler(this.fiveStar_CheckedChanged_1);
            // 
            // SuggestionTextBox
            // 
            this.SuggestionTextBox.Location = new System.Drawing.Point(44, 253);
            this.SuggestionTextBox.Name = "SuggestionTextBox";
            this.SuggestionTextBox.Size = new System.Drawing.Size(257, 96);
            this.SuggestionTextBox.TabIndex = 39;
            this.SuggestionTextBox.Text = "";
            // 
            // SuggestionLabel
            // 
            this.SuggestionLabel.AutoSize = true;
            this.SuggestionLabel.Location = new System.Drawing.Point(113, 225);
            this.SuggestionLabel.Name = "SuggestionLabel";
            this.SuggestionLabel.Size = new System.Drawing.Size(117, 13);
            this.SuggestionLabel.TabIndex = 40;
            this.SuggestionLabel.Text = "Please Add Suggestion";
            // 
            // Ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(345, 410);
            this.Controls.Add(this.SuggestionLabel);
            this.Controls.Add(this.SuggestionTextBox);
            this.Controls.Add(this.fiveStar);
            this.Controls.Add(this.fourStar);
            this.Controls.Add(this.threeStar);
            this.Controls.Add(this.twoStar);
            this.Controls.Add(this.oneStar);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOradioButton);
            this.Controls.Add(this.YESradioButton);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.EmailAt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ratings";
            this.Text = "Ratings";
            this.Load += new System.EventHandler(this.Ratings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EmailAt;
        private System.Windows.Forms.ComboBox EmailComboBox;
        private System.Windows.Forms.RadioButton YESradioButton;
        private System.Windows.Forms.RadioButton NOradioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.CheckBox oneStar;
        private System.Windows.Forms.CheckBox twoStar;
        private System.Windows.Forms.CheckBox threeStar;
        private System.Windows.Forms.CheckBox fourStar;
        private System.Windows.Forms.CheckBox fiveStar;
        private System.Windows.Forms.RichTextBox SuggestionTextBox;
        private System.Windows.Forms.Label SuggestionLabel;
    }
}
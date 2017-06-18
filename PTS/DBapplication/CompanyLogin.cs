using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class CompanyLogin : Form
    {
        private Controller controllerObj;
        string Username;
        public CompanyLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }
        public CompanyLogin(string Username)
        {
            this.Username = Username;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }


        private void CompanyLogin_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            int Exists = controllerObj.CheckCompanyPassword_Basic(CompanyNameMaskedTextBox.Text, CompanyPasswordTextBox.Text);
            if (Exists > 0)
            {
                new MaintenanceCompany(CompanyNameMaskedTextBox.Text).Show();
                CompanyNameMaskedTextBox.Clear();
                CompanyPasswordTextBox.Clear();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}

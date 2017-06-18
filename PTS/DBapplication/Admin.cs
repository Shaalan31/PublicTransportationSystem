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
    public partial class Admin : Form
    {
        string Username;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string Username)
        {
            this.Username = Username;
            InitializeComponent();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ChangePassword(Username,this).Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void EditInformationButton_Click(object sender, EventArgs e)
        {
            Hide();
            new EditInformation(this,Username).Show();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddEmployee(Username).Show();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteEmployee(Username).Show();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new UpdateEmployee(Username).Show();
        }

        private void AddTransportationMeanButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddTransportationMean(Username).Show();
        }

        private void UpdateTransportationMeanButton_Click(object sender, EventArgs e)
        {
            Hide();
            new UpdateTransportationMean(Username).Show();
        }

        private void DeleteTransportationMeanButton_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteTransportationMean(Username).Show();
        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            new AddCompany(Username).Show();
            Hide();
        }

        private void DeleteCompanyButton_Click(object sender, EventArgs e)
        {
            new DeleteCompany(Username).Show();
            Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCompanyButton_Click(object sender, EventArgs e)
        {
            new UpdateCompany(Username).Show();
            Hide();
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Option Will Be Available In The Next Update");
            MessageBox.Show("Promise :)");
        }
    }
}

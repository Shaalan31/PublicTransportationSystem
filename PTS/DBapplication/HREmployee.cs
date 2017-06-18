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
    public partial class HREmployee : Form
    {
        string Username;
        public HREmployee()
        {
            InitializeComponent();
        }
        public HREmployee(string _Username)
        {
            InitializeComponent();
            Username = _Username;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword(Username,this).Show();
            Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void HREmployee_Load(object sender, EventArgs e)
        {
        }

        private void ViewEmployeesButton_Click(object sender, EventArgs e)
        {
            new ViewEmployees(Username).Show();
            Hide();
        }

        private void ViewStatisticsButton_Click(object sender, EventArgs e)
        {
            new HRStatistics(Username).Show();
            Hide();
        }

        private void EditInformationButton_Click(object sender, EventArgs e)
        {
            new EditInformation(this,Username).Show();
            Hide();
        }
    }
}

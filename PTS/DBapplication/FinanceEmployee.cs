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
    public partial class FinanceEmployee : Form
    {
        string Username;
        public FinanceEmployee()
        {
            InitializeComponent();
        }
        public FinanceEmployee(string _Username)
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

        private void EditInformationButton_Click(object sender, EventArgs e)
        {
            new EditInformation(this, Username).Show();
            Hide();
        }

        private void ViewStatisticsButton_Click(object sender, EventArgs e)
        {
            new FinanceStatistics(Username).Show();
            Hide();
        }
    }
}

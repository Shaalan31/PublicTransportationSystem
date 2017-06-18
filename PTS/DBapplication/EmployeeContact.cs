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
    public partial class EmployeeContact : Form
    {
        string Username;
        Controller ControllerObject;
        public EmployeeContact()
        {
            InitializeComponent();
            ControllerObject = new Controller();
        }
        public EmployeeContact(string _Username)
        {
            InitializeComponent();
            Username = _Username;
            ControllerObject = new Controller();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ChangePassword(Username,this).Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }


        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactingMaintenance(Username).Show();
        }

        private void CheckMaintenanceReviewsButton_Click(object sender, EventArgs e)
        {
            //Hide();
            new CheckMaintenanceReviews().Show();
        }

        private void EditInformationButton_Click(object sender, EventArgs e)
        {
            new EditInformation(this,Username).Show();
        }
    }
}

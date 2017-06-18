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
    public partial class Employee : Form
    {
        string Username;
        public Employee()
        {
            InitializeComponent();
        }
        public Employee(string _Username)
        {
            InitializeComponent();
            Username = _Username;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ChangePassword(Username,this).Show();
            Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditInformationButton_Click(object sender, EventArgs e)
        {
            new EditInformation(this,Username).Show();
            Hide();
        }
    }
}

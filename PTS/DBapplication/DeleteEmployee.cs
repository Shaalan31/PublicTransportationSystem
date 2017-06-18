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
    public partial class DeleteEmployee : Form
    {
        private Controller controllerObj;
        string Username;
        public DeleteEmployee()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getEmployeeNames();
            EmployeeComboBox.DataSource = dt;
            EmployeeComboBox.DisplayMember = "EmployeeName";
            EmployeeComboBox.ValueMember = "E_SSN";
        }
        public DeleteEmployee(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getEmployeeNames();
            EmployeeComboBox.DataSource = dt;
            EmployeeComboBox.DisplayMember = "EmployeeName";
            EmployeeComboBox.ValueMember = "E_SSN";
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Admin(Username).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Hide();
            //add are you sure you want to delete
            new DeleteMessage(this, Convert.ToInt32(EmployeeComboBox.SelectedValue),Username).Show();
            //controllerObj.deleteEmployee(Convert.ToInt32(EmployeeComboBox.SelectedValue));
            //new Admin().Show();
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}

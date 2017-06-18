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
    public partial class UpdateEmployee : Form
    {

        private Controller controllerObj;
        string Username;
        public UpdateEmployee()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getEmployeeNames();
            EmployeeTextBox.DataSource = dt;
            EmployeeTextBox.DisplayMember = "EmployeeName";
            EmployeeTextBox.ValueMember = "E_SSN";
        }
        public UpdateEmployee(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getEmployeeNames();
            EmployeeTextBox.DataSource = dt;
            EmployeeTextBox.DisplayMember = "EmployeeName";
            EmployeeTextBox.ValueMember = "E_SSN";
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Admin(Username).Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (SalaryMaskedTextBox.Text=="")
            {
                MessageBox.Show("Please Insert All Fields");
                return;
            }
            Hide();
            int r = controllerObj.UpdateEmp(Convert.ToInt16(SalaryMaskedTextBox.Text), Convert.ToInt32(EmployeeTextBox.SelectedValue), Convert.ToInt32(SupervisorComboBox.SelectedValue));
            new Admin(Username).Show();
        }

        private void JobCodeMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void EmployeeTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SupervisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SalaryMaskedTextBox.Text = Convert.ToString(controllerObj.GetSalary(Convert.ToInt32(EmployeeTextBox.SelectedValue)));
            DataTable ds = controllerObj.getSupervisorsNames();
            DataRow dt = controllerObj.getSuperVisorSSN(Convert.ToInt32(EmployeeTextBox.SelectedValue.ToString())).Rows[0];
            SupervisorComboBox.DataSource = ds;
            //
            SupervisorComboBox.DisplayMember = "SuperNames";
            SupervisorComboBox.ValueMember = "SuperSSN";
            SupervisorComboBox.SelectedValue = dt["SupervisorSSN"];
        }

        private void SalaryMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
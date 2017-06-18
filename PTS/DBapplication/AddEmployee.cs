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
    public partial class AddEmployee : Form
    {
        Controller ControllerObject;
        string Username;
        public AddEmployee()
        {
            ControllerObject = new Controller();
            InitializeComponent();
            DataTable dt = ControllerObject.getSupervisorsNames();
            SupervisorComboBox.DataSource = dt;
            SupervisorComboBox.DisplayMember = "SuperNames";
            SupervisorComboBox.ValueMember = "SuperSSN";
            DataTable dt2 = ControllerObject.getDeptName();
            DepartmentComboBox.DataSource = dt2;
            DepartmentComboBox.DisplayMember = "Name";
            DepartmentComboBox.ValueMember = "Number";
        }
        public AddEmployee(string Username)
        {
            ControllerObject = new Controller();
            InitializeComponent();
            DataTable dt = ControllerObject.getSupervisorsNames();
            SupervisorComboBox.DataSource = dt;
            SupervisorComboBox.DisplayMember = "SuperNames";
            SupervisorComboBox.ValueMember = "SuperSSN";
            DataTable dt2 = ControllerObject.getDeptName();
            DepartmentComboBox.DataSource = dt2;
            DepartmentComboBox.DisplayMember = "Name";
            DepartmentComboBox.ValueMember = "Number";
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Admin(Username).Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SSNMaskedTextBox.Text=="" || JobCodeMaskedTextBox.Text=="" || SalaryMaskedTextBox.Text=="" || FirstNameMaskedTextBox.Text=="" || LastNameMaskedTextBox.Text=="" || EmailTextBox.Text=="" || (!MaleradioButton1.Checked && !FemaleradioButton2.Checked))
            {
                MessageBox.Show("Insert All Fields Please");
            }
            else
            {
                if (MaleradioButton1.Checked)
                {
                    //revise
                    int r = ControllerObject.insertEmployee(Convert.ToInt32(SSNMaskedTextBox.Text), JobCodeMaskedTextBox.Text.ToString(), Convert.ToInt32(SalaryMaskedTextBox.Text), Convert.ToInt32(DepartmentComboBox.SelectedValue), Convert.ToInt32(SupervisorComboBox.SelectedValue), StartDateDateTimePicker.Value, FirstNameMaskedTextBox.Text.ToString(), LastNameMaskedTextBox.Text.ToString(), MaleradioButton1.Text[0], EmailTextBox.Text + "@" + EmailComboBox.Text + ".com", BirthDateDateTimePicker.Value);
                    if (r > 0)
                    {
                        MessageBox.Show(FirstNameMaskedTextBox.Text+" "+LastNameMaskedTextBox.Text+" "+"inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error inserting"+" "+ FirstNameMaskedTextBox.Text + " " + LastNameMaskedTextBox.Text);
                    }
                }
                else
                {
                    int r=ControllerObject.insertEmployee(Convert.ToInt32(SSNMaskedTextBox.Text), JobCodeMaskedTextBox.Text, Convert.ToInt32(SalaryMaskedTextBox.Text), Convert.ToInt32(DepartmentComboBox.SelectedValue), Convert.ToInt32(SupervisorComboBox.SelectedValue), StartDateDateTimePicker.Value, FirstNameMaskedTextBox.Text, LastNameMaskedTextBox.Text, FemaleradioButton2.Text[0], EmailTextBox.Text + "@" + EmailComboBox.Text + ".com", BirthDateDateTimePicker.Value);
                    if (r > 0)
                    {
                        MessageBox.Show(FirstNameMaskedTextBox.Text + " " + LastNameMaskedTextBox.Text + " " + "inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error inserting" + " " + FirstNameMaskedTextBox.Text + " " + LastNameMaskedTextBox.Text);
                    }
                }
                Hide();
                new Admin(Username).Show();
            }
            
        }

        private void EmailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaleradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SalaryMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void SSNMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void FirstNameMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void LastNameMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

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

        private void BirthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SSNMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (SSNMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckSSNEmp(Convert.ToInt32(SSNMaskedTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("You are already signed up on PTS using the same SSN");
                SSNMaskedTextBox.Text = "";
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            string Email = EmailTextBox.Text + "@" + EmailComboBox.Text + ".com";
            if (EmailTextBox.Text == "" || EmailComboBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.EmailAvaliable(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Email is already used");
                EmailTextBox.Text = "";
            }
        }

        private void EmailComboBox_Leave(object sender, EventArgs e)
        {
            string Email = EmailTextBox.Text + "@" + EmailComboBox.Text + ".com";
            if (EmailTextBox.Text == "" || EmailComboBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.EmailAvaliable(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Email is already used");
                EmailTextBox.Text = "";
            }
        }

        private void JobCodeMaskedTextBox_Leave(object sender, EventArgs e)
        {
            //JobCodeAvailable

              string Email = JobCodeMaskedTextBox.Text;
            if (JobCodeMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.JobCodeAvailable(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Job Code is already used");
                JobCodeMaskedTextBox.Text = "";
            }


        }
    }
}

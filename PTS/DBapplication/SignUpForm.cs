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
    public partial class SignUpForm : Form
    {
        Controller ControllerObj;
        public SignUpForm()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

      

        private void DependantTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (FirstNameMaskedTextBox.Text == "" || LastNameMaskedTextBox.Text == "" || AddressTextBox.Text=="" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "" || (!MaleRadioButton.Checked && !FemaleRadioButton.Checked) || SSNMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please Insert All Values");
                return;
            }
            Controller C = new Controller();
            int IsDependent = 0;
            if (DependantSSNMaskedTextBox.Text == "" || JobCodeMaskedTextBox.Text == "")
                IsDependent = 0;
            else
            {
                DataTable DT = new DataTable();
                DT = C.CheckSSNJobCodeEmp(Convert.ToInt32(DependantSSNMaskedTextBox.Text), Convert.ToString(JobCodeMaskedTextBox.Text));
                IsDependent = Convert.ToInt32(DT.Rows[0][0]);
            }
            if (MaleRadioButton.Checked)
            {
                int r=ControllerObj.insertUser(UsernameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, 3, Convert.ToInt32(SSNMaskedTextBox.Text), FirstNameMaskedTextBox.Text, LastNameMaskedTextBox.Text, MaleRadioButton.Text[0], EmailTextBox.Text + AtLabel.Text + EmailComboBox.Text + ComLabel.Text, BirthDatePicker.Value, IsDependent);
                if (r!=0)
                {
                    MessageBox.Show("Congratulations"+" "+FirstNameMaskedTextBox.Text+" "+LastNameMaskedTextBox.Text+" "+"Registration Successful");
                }
                else
                {
                    MessageBox.Show("Error in Registeration");
                    return;
                }
            }
            else
            {
                int r=ControllerObj.insertUser(UsernameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, 3, Convert.ToInt32(SSNMaskedTextBox.Text), FirstNameMaskedTextBox.Text, LastNameMaskedTextBox.Text, FemaleRadioButton.Text[0], EmailTextBox.Text + AtLabel.Text + EmailComboBox.Text + ComLabel.Text, BirthDatePicker.Value, IsDependent);
                if (r!=0)
                {
                    MessageBox.Show("Congratulations" + " " + FirstNameMaskedTextBox.Text + " " + LastNameMaskedTextBox.Text + " " + "Registration Successful");
                }
                else
                {
                    MessageBox.Show("Error in Registeration");
                    return;
                }
            }
            Hide();
            new Login().Show();
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
        private void DependantSSNMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
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

        private void SSNMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }


        

        private void JobCodeMaskedTextBox_Leave_1(object sender, EventArgs e)
        {
            if (JobCodeMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckJobCode(Convert.ToString(JobCodeMaskedTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking != 1)
            {
                MessageBox.Show("This JobCode is not even in our company :) please enter another Job Code");
                JobCodeMaskedTextBox.Text = "";
            }

        }

        private void DependantSSNMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (DependantSSNMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckSSNEmp(Convert.ToInt32(DependantSSNMaskedTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking != 1)
            {
                MessageBox.Show("This SSN is not even in our company :) please enter another SSN");
                DependantSSNMaskedTextBox.Text = "";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
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
            string Email = EmailTextBox.Text + AtLabel.Text + EmailComboBox.Text + ComLabel.Text;
            if (EmailTextBox.Text == "" || EmailComboBox.Text=="")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.EmailAvaliable(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("You are already signed up on PTS using the same SSN");
                EmailTextBox.Text = "";
            }

        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            string User = UsernameTextBox.Text;
            if (UsernameTextBox.Text == "" )
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.UserNameAvaliable(User);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Username is already used");
                UsernameTextBox.Text = "";
            }
        }

        private void EmailComboBox_Leave(object sender, EventArgs e)
        {
            string Email = EmailTextBox.Text + AtLabel.Text + EmailComboBox.Text + ComLabel.Text;
            if (EmailTextBox.Text == "" || EmailComboBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.EmailAvaliable(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This email is already used");
                EmailTextBox.Text = "";
            }
        }
    }
}

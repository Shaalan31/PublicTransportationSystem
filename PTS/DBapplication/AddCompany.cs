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
    public partial class AddCompany : Form
    {
        Controller ControllerObject;
        string Username;
        public AddCompany()
        {
            InitializeComponent();
            ControllerObject = new Controller();
        }
        public AddCompany(string Username)
        {
            InitializeComponent();
            ControllerObject = new Controller();
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Admin(Username).Show();
            Hide();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text=="" || CompanyIDMaskedTextBox.Text=="" || AddressTextBox.Text=="" || EmailTextBox.Text=="" )
            {
                MessageBox.Show("Insert All Fields");
            }
            else
            {
                string PhoneNum = PhoneTextBox.Text;
                int Error = 0;
                int z;
                for (int i = 0; i < PhoneNum.Length; i++)
                {
                    z = (int)PhoneNum[i];
                    if (z < 40 || z > 57)
                    {
                        Error = 1;
                        break;
                    }
                }
                if (Error == 0)
                {
                    int r=ControllerObject.AddCompany(Convert.ToInt32(CompanyIDMaskedTextBox.Text), CompanyNameMaskedTextBox.Text, AddressTextBox.Text, Convert.ToInt32(PhoneTextBox.Text), EmailTextBox.Text + AtLabel.Text + EmailDomainComboBox.Text + ComLabel.Text);
                    if (r!=0)
                    {
                        MessageBox.Show(CompanyNameMaskedTextBox.Text+ " " +"is Added");
                        Hide();
                        new Admin(Username).Show();
                    }
                    else
                    {
                        MessageBox.Show("Error in Adding"+" "+ CompanyNameMaskedTextBox.Text);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Phone Number! Check Your Entry");
                }
            }

        }

        private void PhoneNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void CompanyIDMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void CompanyNameMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyIDMaskedTextBox_Leave(object sender, EventArgs e)
        {
            string Email = CompanyIDMaskedTextBox.Text;
            if (CompanyIDMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckCompanyID(Convert.ToInt32(Email));
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Company ID is already used");
                CompanyIDMaskedTextBox.Text = "";
            }
        }

        private void CompanyNameMaskedTextBox_Leave(object sender, EventArgs e)
        {
            string Email = CompanyNameMaskedTextBox.Text;
            if (CompanyNameMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckCompanyName(Email);
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("This Job Code is already used, are you sure you want to use it");
                //CompanyNameMaskedTextBox.Text = "";
            }

        }
    }
}

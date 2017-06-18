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
    public partial class UpdateCompany : Form
    {
        string Username;
        Controller controllerObj;
        public UpdateCompany(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            controllerObj = new Controller();
            DataTable dt = controllerObj.getCompanyName(null);
            CompanyNameComboBox.DataSource = dt;
            CompanyNameComboBox.DisplayMember = "CompanyName";
            CompanyNameComboBox.ValueMember = "CompanyID";
            CompanyDetailsGridView.DataSource = controllerObj.getCompanyDetails(Convert.ToInt16(CompanyNameComboBox.SelectedValue));
           
        }

        private void UpdateCompany_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Admin(Username).Show();
            Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(AddressTextBox.Text=="" || PhoneNumberTextBox.Text=="" || EmailTextBox.Text=="" )
            {
                MessageBox.Show("Please fill the boxes");
                return;
            }
            string PhoneNum = PhoneNumberTextBox.Text;
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
                int r = controllerObj.UpdateCompany(Convert.ToInt16(CompanyNameComboBox.SelectedValue), Convert.ToInt32(PhoneNumberTextBox.Text), AddressTextBox.Text, EmailTextBox.Text + "@" + EmailDomainComboBox.Text + ".com");
                if (r != 0)
                {
                    MessageBox.Show(CompanyNameComboBox.Text + " " + "Updated Successfully");
                    new Admin(Username).Show();
                    Hide();
                }
                else
                    MessageBox.Show("Error Updating" + " " + CompanyNameComboBox.Text);
            }
            else
                MessageBox.Show("Enter a Valid Phone Number");
        }
        private void CompanyDetailsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompanyNameComboBox_Leave(object sender, EventArgs e)
        {
            CompanyDetailsGridView.DataSource = controllerObj.getCompanyDetails(Convert.ToInt16(CompanyNameComboBox.SelectedValue));
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

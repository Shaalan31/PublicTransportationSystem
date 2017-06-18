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
    public partial class ContactingMaintenance : Form
    {
        private Controller controllerObj;
        String Username;
        public ContactingMaintenance(String Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Username = Username;
            NameOfCompanyComboBox.DataSource = controllerObj.getCompanyName(null);
            NameOfCompanyComboBox.ValueMember = "CompanyID";
            NameOfCompanyComboBox.DisplayMember = "CompanyName";
            TransportationComboBox.DataSource = controllerObj.getTransportationNames();
            TransportationComboBox.ValueMember = "TransID";
            TransportationComboBox.DisplayMember = "TransName";
            CompanyNumberLabel.Text = Convert.ToString(controllerObj.GetCompanyNumber(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue)));
        }

        private void ContactingMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            int r = controllerObj.sendRequest(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue),"MET", Convert.ToInt16(TransportationComboBox.SelectedValue),0, MaintenanceMsgComboBox.Text);
            if (r != 0)
            { MessageBox.Show("Request Sent"); }
            else
            {
                MessageBox.Show("Error Sending Request ");
            }
            this.Hide();
            new EmployeeContact(Username).Show();
        }

        private void NameOfCompanyComboBox_Leave(object sender, EventArgs e)
        {
            CompanyNumberLabel.Text = Convert.ToString(controllerObj.GetCompanyNumber(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue)));
        }

        private void NameOfCompanyComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
           // CompanyNumberLabel.Text = Convert.ToString(controllerObj.GetCompanyNumber(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue)));

        }

        private void NameOfCompanyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
           // CompanyNumberLabel.Text = Convert.ToString(controllerObj.GetCompanyNumber(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue)));

        }

        private void NameOfCompanyComboBox_DisplayMemberChanged(object sender, EventArgs e)
        {
            //CompanyNumberLabel.Text = Convert.ToString(controllerObj.GetCompanyNumber(Convert.ToInt16(NameOfCompanyComboBox.SelectedValue)));

        }
    }
}

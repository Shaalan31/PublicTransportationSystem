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
    public partial class EditInformation : Form
    {
        Controller ControllerObject;
        string Username;
        Form Sender;
        public EditInformation()
        {
            InitializeComponent();
            ControllerObject = new Controller();
        }
        public EditInformation(Form SenderForm, string _Username)
        {
            InitializeComponent();
            ControllerObject = new Controller();
            Username = _Username;
            Sender = SenderForm;
        }

        private void EditInformation_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (Sender is Admin)
                new Admin(Username).Show();
            else if (Sender is HREmployee)
                new HREmployee(Username).Show();
            else if (Sender is Employee)
                new Employee(Username).Show();
            else if (Sender is FinanceEmployee)
                new FinanceEmployee(Username).Show();
            else if (Sender is EmployeeContact)
                new EmployeeContact(Username).Show();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AddressTextBox.Text == "" || EmailTextBox.Text == "" || EmailComboBox.Text == "")
            {
                MessageBox.Show("Please Insert All Values");
                return;
            }
            int r=ControllerObject.EditInformation(Username, AddressTextBox.Text, EmailTextBox.Text + "@" + EmailComboBox.Text);
            if (r!=0)
            {
                MessageBox.Show(Username + " " + "Edited");
                Hide();
                if (Sender is Admin)
                    new Admin(Username).Show();
                else if (Sender is HREmployee)
                    new HREmployee(Username).Show();
                else if (Sender is Employee)
                    new Employee(Username).Show();
                else if (Sender is FinanceEmployee)
                    new FinanceEmployee(Username).Show();
                else if (Sender is EmployeeContact)
                    new EmployeeContact(Username).Show();
            }
            else
            {
                MessageBox.Show("Error in Editing"+" "+ Username);
            }
            
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}

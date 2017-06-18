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
    public partial class ChangePassword : Form
    {
        string Username;
        Controller C;
        Form SenderForm;
        public ChangePassword()
        {
            InitializeComponent();
            C = new Controller();
        }
        public ChangePassword(string User, Form Sender)
        {
            InitializeComponent();
            Username = User;
            SenderForm = Sender;
            C = new Controller();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (SenderForm is User)
            {
                new User(Username).Show();
            }
            else if (SenderForm is Admin)
            {
                new Admin(Username).Show();
            }
            else if (SenderForm is Employee)
            {
                new Employee(Username).Show();
            }
            else if (SenderForm is HREmployee)
            {
                new HREmployee(Username).Show();
            }
            else if (SenderForm is FinanceEmployee)
            {
                new FinanceEmployee(Username).Show();
            }
            Hide();
        }

        private void EnterCurrentPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (EnterCurrentPasswordTextBox.Text == "")
            {
                return;
            }
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckOldPassword(Username, Convert.ToString(EnterCurrentPasswordTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);
            if (Checking == 0)
            {
                EnterCurrentPasswordTextBox.Text = "";
                MessageBox.Show("Wrong Old Password");
            }
        }
        private void EnterNewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmNewPasswordTextBox.Text != EnterNewPasswordTextBox.Text)
            {
                ConfirmNewPasswordTextBox.Text = "";

            }
        }

        private void ConfirmNewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmNewPasswordTextBox.Text != EnterNewPasswordTextBox.Text)
            {
                ConfirmNewPasswordTextBox.Text = "";
                MessageBox.Show("Not Same password");

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (EnterCurrentPasswordTextBox.Text == "" || EnterNewPasswordTextBox.Text == "" || ConfirmNewPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
                return;
            }
            C.uChangePassword(Username, EnterCurrentPasswordTextBox.Text, EnterNewPasswordTextBox.Text);
            MessageBox.Show("Password Changed");

            if (EnterCurrentPasswordTextBox.Text == "")
                return;
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.CheckOldPassword(Username, Convert.ToString(EnterCurrentPasswordTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);
            if (Checking == 0)
            {
                EnterCurrentPasswordTextBox.Text = "";
            }
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (SenderForm is User)
            {
                new User(Username).Show();
            }
            else if (SenderForm is Admin)
            {
                new Admin(Username).Show();
            }
            else if (SenderForm is Employee)
            {
                new Employee(Username).Show();
            }
            else if (SenderForm is HREmployee)
            {
                new HREmployee(Username).Show();
            }
            else if (SenderForm is FinanceEmployee)
            {
                new FinanceEmployee(Username).Show();
            }
            Hide();
        }
    }
}

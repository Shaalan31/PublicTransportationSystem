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
    public partial class HRStatistics : Form
    {
        private Controller controllerObj;
        string Username;
        public HRStatistics(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.Username = Username;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees(MaleRadioButton.Text));
            }
            else if (FemaleRadioButton.Checked)
            {
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees(FemaleRadioButton.Text));
            }
            else
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees());
        }

        private void FindButton2_Click(object sender, EventArgs e)
        {
            CountDateLabel.Text = Convert.ToString(controllerObj.CountDate(dateTimePicker1.Value));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new HREmployee(Username).Show();
            Hide();
        }

        private void FindButton_Click_1(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees(MaleRadioButton.Text));
            }
            else if (FemaleRadioButton.Checked)
            {
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees(FemaleRadioButton.Text));
            }
            else
                CountEmployeesLabel.Text = Convert.ToString(controllerObj.CountAllEmployees());
        }

        private void FindButton2_Click_1(object sender, EventArgs e)
        {
            CountDateLabel.Text = Convert.ToString(controllerObj.CountDate(dateTimePicker1.Value));
        }
    }
}

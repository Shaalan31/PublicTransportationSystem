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
    public partial class DeleteCompany : Form
    {
        private Controller controllerObj;
        string Username;
        public DeleteCompany()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getCompanyName(null);
            CompanyNameComboBox.DataSource = dt;
            CompanyNameComboBox.DisplayMember = "CompanyName";
            CompanyNameComboBox.ValueMember = "CompanyID";
        }
        public DeleteCompany(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getCompanyName(null);
            CompanyNameComboBox.DataSource = dt;
            CompanyNameComboBox.DisplayMember = "CompanyName";
            CompanyNameComboBox.ValueMember = "CompanyID";
            this.Username = Username;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //controllerObj.DeleteCompany(Convert.ToInt16(CompanyNameComboBox.SelectedValue));
            new DeleteMessage(this, Convert.ToInt16(CompanyNameComboBox.SelectedValue),Username).Show();
            //Hide();
        }

        private void CompanyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCompany_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Admin(Username).Show();
            Hide();
        }
    }
}

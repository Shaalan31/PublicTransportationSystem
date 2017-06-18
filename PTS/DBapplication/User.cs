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
    public partial class User : Form
    {
        string Username;
        Controller C;
        public User()
        {
            InitializeComponent();
            C = new Controller();

        }
        public User(string username)
        {
            InitializeComponent();
            Username = username;
            C = new Controller();
            DataTable SourceTable = new DataTable();
            DataTable DestinationTable = new DataTable();
            SourceTable = C.allDistricts(0);
            DestinationTable = C.allDistricts(0);
            FromComboBox1.DataSource = SourceTable;
            FromComboBox1.ValueMember = "DistrictID";
            FromComboBox1.DisplayMember = "DistrictName";

            ToComboBox.DataSource = DestinationTable;
            ToComboBox.ValueMember = "DistrictID";
            ToComboBox.DisplayMember = "DistrictName";


        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ChangePassword(Username,this).Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void viewHistoryOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewHistoryOfOrders(Username).Show();
            //Hide();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(FromComboBox1.SelectedValue) == Convert.ToInt32(ToComboBox.SelectedValue))
            {
                MessageBox.Show("Please Dont go from the same place to the same place");
                return;
            }
            ExcuteRoute ER = new ExcuteRoute(Convert.ToInt16(FromComboBox1.SelectedValue), Convert.ToInt16(ToComboBox.SelectedValue), Username);
            ER.Show();
            Hide();
        }
    }
}

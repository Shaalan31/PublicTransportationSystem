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
    public partial class DeleteTransportationMean : Form
    {
        Controller ControllerObj;
        string Username;
        public DeleteTransportationMean()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.getTransportationNames();
            TransportationCode_IDComboBox.DataSource = dt;
            TransportationCode_IDComboBox.ValueMember = "TransID";
            TransportationCode_IDComboBox.DisplayMember = "NameID";
        }
        public DeleteTransportationMean(string Username)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.getTransportationNames();
            TransportationCode_IDComboBox.DataSource = dt;
            TransportationCode_IDComboBox.ValueMember = "TransID";
            TransportationCode_IDComboBox.DisplayMember = "NameID";
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Admin(Username).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt16(TransportationCode_IDComboBox.SelectedValue);
            new DeleteMessage(this,key, Username).Show();
        }

        private void TransportationCode_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteTransportationMean_Load(object sender, EventArgs e)
        {

        }
    }
}

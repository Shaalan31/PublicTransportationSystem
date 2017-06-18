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
    public partial class UpdateTransportationMean : Form
    {
        Controller ControllerObj;
        string Username;
        public UpdateTransportationMean()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.getTransportationNames();
            TransportationCode_IDComboBox.DataSource = dt;
            TransportationCode_IDComboBox.ValueMember = "TransID";
            TransportationCode_IDComboBox.DisplayMember = "NameID";
        }
        public UpdateTransportationMean(string Username)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CapacityMaskedTextBox.Text ==  "" || FareMaskedTextBox.Text == "" || (!YesRadioButton.Checked && !NoRadioButton.Checked))//validation part
            {
                MessageBox.Show("Please, insert all values");
                return;
            }
            else

            {
                int r;
                if (YesRadioButton.Checked)
                {
                    r = ControllerObj.UpdateTransportation("MET", Convert.ToInt16(TransportationCode_IDComboBox.SelectedValue), Convert.ToInt16(CapacityMaskedTextBox.Text), true, float.Parse(FareMaskedTextBox.Text));
                    if (r > 0)
                    { MessageBox.Show("transportation updated successfully"); }
                    else
                    {
                        MessageBox.Show("Error updated transportation");
                        Show();
                        return;
                    }
                }
                else if (NoRadioButton.Checked)
                {
                    r = ControllerObj.UpdateTransportation("MET", Convert.ToInt16(TransportationCode_IDComboBox.SelectedValue), Convert.ToInt16(CapacityMaskedTextBox.Text), false, float.Parse(FareMaskedTextBox.Text));
                    if (r > 0)
                    {
                        MessageBox.Show("transportation updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error updated transportation");
                        Show();
                        return;
                    }

                }
            }
            Hide();
            new Admin(Username).Show();
        }

        private void CapacityMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void FareMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void TransportationCode_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTransportationMean_Load(object sender, EventArgs e)
        {

        }
    }
}

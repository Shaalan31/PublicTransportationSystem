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
    public partial class AddTransportationMean : Form
    {
        private Controller Controllerobj;
        string Username;
        public AddTransportationMean()
        {
            InitializeComponent();
            Controllerobj = new Controller();
        }
        public AddTransportationMean(string Username)
        {
            InitializeComponent();
            Controllerobj = new Controller();
            this.Username = Username;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Admin(Username).Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (TransportationCodeMaskedTextBox.Text == "" || CapacityMaskedTextBox.Text == "" || FareMaskedTextBox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else

            {
                int r;
                if (YesRadioButton.Checked)
                {
                    r = Controllerobj.insertTransportation(TransportationCodeMaskedTextBox.Text, Convert.ToInt16(TransportationIDMaskedTextBox.Text), Convert.ToInt16(CapacityMaskedTextBox.Text), true, float.Parse(FareMaskedTextBox.Text));
                    if (r > 0)
                    { MessageBox.Show("transportation inserted successfully"); }
                    else
                    { MessageBox.Show("Error inserting transportation"); }
                }

                else if (NoRadioButton.Checked)
                {
                    r = Controllerobj.insertTransportation(TransportationCodeMaskedTextBox.Text, Convert.ToInt16(TransportationIDMaskedTextBox.Text), Convert.ToInt16(CapacityMaskedTextBox.Text), false, float.Parse(FareMaskedTextBox.Text));
                    if (r > 0)
                    { MessageBox.Show("transportation inserted successfully"); }
                    else
                    { MessageBox.Show("Error inserting transportation"); }

                }
            }

                new Admin(Username).Show();
        }

        private void TransportationCodeMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void TransportationIDMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void CapacityMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Invalid Entry");
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} : {1}", "Hint", e.RejectionHint);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MaskInputRejected Event");
        }

        private void YesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddTransportationMean_Load(object sender, EventArgs e)
        {

        }

        private void TransportationIDMaskedTextBox_Leave(object sender, EventArgs e)
        {
            

                if (TransportationIDMaskedTextBox.Text == "")
                return;
            Controller C = new Controller();
            int Checking = 0;
            DataTable DT = new DataTable();
            DT = C.UniqueTransID(Convert.ToInt32(TransportationIDMaskedTextBox.Text));
            Checking = Convert.ToInt32(DT.Rows[0][0]);

            if (Checking == 1)
            {
                MessageBox.Show("The ID already used");
                TransportationIDMaskedTextBox.Text = "";
            }
        }
    }
}

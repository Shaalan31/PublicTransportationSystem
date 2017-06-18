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
    public partial class DeleteMessage : Form
    {

        Form Sender;
        int Key;
        Controller controllerObj;
        string Username;
        public DeleteMessage()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }
        //Overloaded Constructor
        public DeleteMessage (Form SenderForm,int Key,string Username)
        {
            InitializeComponent();
            Sender = SenderForm;
            this.Key = Key;
            controllerObj = new Controller();
            this.Username = Username;
        }
        

        private void NoButton_Click(object sender, EventArgs e)
        {
            Hide();
            Sender.Show();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
         
           
            if (Sender is DeleteCompany)
            {
               int r= controllerObj.DeleteCompany(Key);
                if (r!=0)
                {
                    MessageBox.Show("Company Deleted");
                }
                else
                {
                    MessageBox.Show("Error in Deletion");
                }
            }
            else if (Sender is DeleteEmployee)
            {
               int r= controllerObj.deleteEmployee(Key);
                if (r != 0)
                {
                    MessageBox.Show("Employee Deleted");
                }
                else
                {
                    MessageBox.Show("Error in Deletion");
                }
            }
            else if (Sender is DeleteTransportationMean)
            {
                int r=controllerObj.deleteTransportation(Key);
                if (r != 0)
                {
                    MessageBox.Show("Transportation Deleted");
                }
                else
                {
                    MessageBox.Show("Error in Deletion");
                }
            }
            Hide();
            Sender.Hide();
            new Admin(Username).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMessage_Load(object sender, EventArgs e)
        {

        }
    }
}

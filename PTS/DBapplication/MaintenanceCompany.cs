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
    public partial class MaintenanceCompany : Form
    {
        string Username;
        int CompanyCode;
        public MaintenanceCompany()
        {
            InitializeComponent();
        }
        public MaintenanceCompany(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            //retrieve the requests that came from the users 
            Controller C = new Controller();
            DataTable CompanyInfo = new DataTable();
            CompanyInfo = C.getCompanyName(Username);
            CompanyCode = Convert.ToInt32(CompanyInfo.Rows[0][1]);
            DataTable PendingJobs = new DataTable();
            PendingJobs = C.pendingRequest(CompanyCode,0);
            PendingRequestDataGridView.DataSource = PendingJobs;


        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaintenanceCompany_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login temp = new Login();
            temp.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RequestID = (int)PendingRequestDataGridView.Rows[e.RowIndex].Cells[0].Value;
            //Create new form that take the request ID
            string JobOver = "The Pending request with ID  " + Convert.ToString(RequestID) + " is done ";
            MessageBox.Show(JobOver);
            //If this is working, once you double click we will consider the job done
            Controller C = new Controller();
            C.JobDone(RequestID);
            DataTable PendingJobs = new DataTable();
            PendingJobs = C.pendingRequest(CompanyCode,0);
            PendingRequestDataGridView.DataSource = PendingJobs;
            PendingRequestDataGridView.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void PendingRequestDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RequestID = (int)PendingRequestDataGridView.Rows[e.RowIndex].Cells[0].Value;
            //Create new form that take the request ID
            string JobOver = "The Pending request with ID  " + Convert.ToString(RequestID) + " is done ";
            MessageBox.Show(JobOver);
            //If this is working, once you double click we will consider the job done
            Controller C = new Controller();
            C.JobDone(RequestID);
            DataTable PendingJobs = new DataTable();
            PendingJobs = C.pendingRequest(CompanyCode,0);
            PendingRequestDataGridView.DataSource = PendingJobs;
            PendingRequestDataGridView.Refresh();
        }
    }

}

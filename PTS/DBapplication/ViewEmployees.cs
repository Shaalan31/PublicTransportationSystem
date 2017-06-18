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
    public partial class ViewEmployees : Form
    {
        string Username;
        private Controller controllerObj;
        public ViewEmployees()
        {
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.GetAllEmployees();

        }
        public ViewEmployees(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.GetAllEmployees();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new HREmployee(Username).Show();
            Hide();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}

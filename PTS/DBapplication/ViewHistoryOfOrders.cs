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
    public partial class ViewHistoryOfOrders : Form
    {
        private Controller controllerObj;
        string Username;
        public ViewHistoryOfOrders(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;
            DataTable dt = controllerObj.viewHistory(Username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void ViewHistoryOfOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

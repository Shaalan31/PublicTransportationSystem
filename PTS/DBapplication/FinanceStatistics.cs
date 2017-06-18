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
    public partial class FinanceStatistics : Form
    {
        private Controller controllerObj;
        string Username;
        public FinanceStatistics(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            OrdersCount.Text = Convert.ToString(controllerObj.CountTotalOrders());
            SalaryDataGridView.DataSource = controllerObj.SalaryStatistics();
            this.Username = Username;
        }

        private void FinanceEmployee_Load(object sender, EventArgs e)
        {

        }

       

        private void FindButton_Click(object sender, EventArgs e)
        {
            CountOrders2.Text = Convert.ToString(controllerObj.CountOrders(DateTimePicker1.Value, DateTimePicker2.Value));
        }

        private void SalaryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindButton_Click_1(object sender, EventArgs e)
        {
            CountOrders2.Text = Convert.ToString(controllerObj.CountOrders(DateTimePicker1.Value, DateTimePicker2.Value));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new FinanceEmployee(Username).Show();
            Hide();
        }
    }
}

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
    public partial class CheckMaintenanceReviews : Form
    {
        public CheckMaintenanceReviews()
        {
            Controller C = new Controller();
            InitializeComponent();
            DataTable Done = new DataTable();
            DataTable NotDone = new DataTable();
            Done = C.ReviewingRquest(1);
            NotDone = C.ReviewingRquest(0);
            DoneDataGridView.DataSource = Done;
            NotDoneDataGridView.DataSource = NotDone;

        }
    }
}

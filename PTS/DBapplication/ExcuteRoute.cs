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
    public partial class ExcuteRoute : Form
    {
        int Source;
        int Destination;
        string Username;
        Controller ControllerObj;
        public ExcuteRoute()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }
        //Overriden  constructor that take data with it
        public ExcuteRoute(int S,int D, string User)
        {
            InitializeComponent();
            Source = S;
            Destination = D;
            Username = User;
            ControllerObj = new Controller();
            DataTable ShortestPath = new DataTable();
            //Fill the ShortestPath with the data from the query
            //Excute some function that will return a table filled with From To ID (will be made in Controller)
            ShortestPath = ControllerObj.ShortestPath(Source, Destination);
            DataTable Path = new DataTable();
            Path = ControllerObj.Route(Convert.ToString(ShortestPath.Rows[0][5]), Convert.ToString(ShortestPath.Rows[0][3]));
            dataGridView1.DataSource = Path;
        }

        private void GoToRate_Click(object sender, EventArgs e)
        {
            Ratings Rate = new Ratings(Source,Destination,Username);
            this.Hide();
            Rate.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

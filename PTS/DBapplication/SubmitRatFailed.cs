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
    public partial class SubmitRatFailed : Form
    {
        public SubmitRatFailed()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Hide();
            new Ratings().Show();
        }
    }
}

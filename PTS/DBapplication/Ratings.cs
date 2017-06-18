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
    public partial class Ratings : Form
    {
        int Source;
        int Destination;
        string Username;
        
        public Ratings()
        {
            InitializeComponent();
        }
        //This will take the rating and add it to the orders table
        public Ratings(int Source, int Destination, string Username)
        {
            InitializeComponent();
            this.Source = Source;
            this.Destination = Destination;
            this.Username = Username;
        }

        private void Ratings_Load(object sender, EventArgs e)
        {

        }

        private void EmailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YESradioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void threeStar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void fourStar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void fiveStar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Controller C = new Controller();
            if (YESradioButton.Checked && textBox1.Text == "")
            {
                new SubmitRatFailed().Show();
                return;
            }
            else if (YESradioButton.Checked)
            {
                //Send real email idk how
                MessageBox.Show("Invitation sent");
            }
            int rate = 0;
            if (fiveStar.Checked)
                rate = 5;
            else if (fourStar.Checked)
                rate = 4;
            else if (threeStar.Checked)
                rate = 3;
            else if (twoStar.Checked)
                rate = 2;
            else if (oneStar.Checked)
                rate = 1;

            DateTime Date = DateTime.Now;
            int Query = C.StoreOrder(Username, Source, Destination, rate, SuggestionTextBox.Text, DateTime.Now, DateTime.Now, 1);
            User Back = new User(Username);
            this.Hide();
            Back.Show();
        }

        //recheck for errors here
        bool Entered = false;
        private void oneStar_CheckedChanged(object sender, EventArgs e)
        {
            if (Entered)
            {
                return;
            }
            Entered = true;
            oneStar.Checked = true;
            twoStar.Checked = false;
            threeStar.Checked = false;
            fourStar.Checked = false;
            fiveStar.Checked = false;
            Entered = false;
        }

        private void twoStar_CheckedChanged(object sender, EventArgs e)
        {
            if (Entered)
            {
                return;
            }
            Entered = true;
            oneStar.Checked = true;
            twoStar.Checked = true;
            threeStar.Checked = false;
            fourStar.Checked = false;
            fiveStar.Checked = false;
            Entered = false;
        }

        private void threeStar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Entered)
            {
                return;
            }
            Entered = true;
            oneStar.Checked = true;
            twoStar.Checked = true;
            threeStar.Checked = true;
            fourStar.Checked = false;
            fiveStar.Checked = false;
            Entered = false;
        }

        private void fourStar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Entered)
            {
                return;
            }
            Entered = true;
            oneStar.Checked = true;
            twoStar.Checked = true;
            threeStar.Checked = true;
            fourStar.Checked = true;
            fiveStar.Checked = false;
            Entered = false;
        }

        private void fiveStar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Entered)
            {
                return;
            }
            Entered = true;
            oneStar.Checked = true;
            twoStar.Checked = true;
            threeStar.Checked = true;
            fourStar.Checked = true;
            fiveStar.Checked = true;
            Entered = false;
        }
    }
}

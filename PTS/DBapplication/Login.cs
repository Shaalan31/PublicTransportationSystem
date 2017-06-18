using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//This Form is related to the users and priviliges

namespace DBapplication
{
    public enum Privileges
    {
        ADMIN = 1,
        EMPLOYEE = 2,
        USER = 3
    }

    public partial class Login : Form
    {
        private Controller controllerObj;
        public Login()
        {
            InitializeComponent();
        }
        //checks the username/password and returns the privlidges associated with this user
        //Returns 0 in case of error
        private int CheckPassword_Basic(string username, string password)
        {


            controllerObj = new Controller();
            return controllerObj.CheckPassword_Basic(username, password);
            //return password == "1234";  //Password can be saved in the DB encrypted rather than being hardcoded.
            //Even if it is stored in a DB, keeping passwords in it's raw form is prone to attacks
        }


        private bool CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed == "w+0fHMgNFl7jSDJ7WpvRfIQLzfflSi9pPNdiQg+v4/E=";    //The Hash should be stored in the DB
                                                                                //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
                                                                                //So even if they are stolen from the database, 
                                                                                //you should have enough time to notify users to change it
                                                                                //before the attacker can use them.
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int Privilege = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);
            if (Privilege > 0)
            {
                Hide();

                Privileges _Privileges = (Privileges)Privilege;
                //Login successful

                switch(_Privileges)
                {
                    case Privileges.ADMIN:
                        new Admin(TxtBx_username.Text).Show();
                        break;
                    case Privileges.EMPLOYEE:
                        int Dno = controllerObj.FindEmployeeDno(TxtBx_username.Text);
                        if (Dno!=-1)
                        {
                            switch (Dno)
                            {
                                case 1:
                                    new FinanceEmployee(TxtBx_username.Text).Show();
                                    break;
                                case 2:
                                    new HREmployee(TxtBx_username.Text).Show();
                                    break;
                                case 3:
                                    new Employee(TxtBx_username.Text).Show();
                                    break;
                                case 4:
                                    new EmployeeContact(TxtBx_username.Text).Show();
                                    break;
                                case 5:
                                    new Employee(TxtBx_username.Text).Show();
                                    break;
                            }
                        }
                        //new Employee().Show();
                        break;
                    case Privileges.USER:
                        new User(TxtBx_username.Text).Show();
                        break;
                }
                // MainMenu func = new MainMenu((Privileges) privlg);
                //func.Show(this);
                TxtBx_pass.Clear();
                TxtBx_username.Clear();
                this.Hide();            
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }


        //private void Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //if (e.CloseReason == CloseReason.UserClosing && !_loggedin)
        //  Owner.Show();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
            Hide();
        }

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HelpLinkLabel.Text = "Click Here To Get More Information";
            HelpLinkLabel.Links.Add(6, 4, "file:///C:/Users/Khairy/Desktop/new%201.html");
        }

        private void ClickHereLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CompanyLogin().Show();
            this.Hide();
        }

        private void TxtBx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBx_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

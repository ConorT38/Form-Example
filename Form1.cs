using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient.MySqlConnection conn;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pass1.PasswordChar = '*';
            pass2.PasswordChar = '*';
            PasswordLog.PasswordChar = '*';
            //These panels will not show up on Startup
            Logged.Visible = false;
            Login.Visible = false;
            
           

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            String first = fname.Text;
            String last = lname.Text;
            String user = username.Text;
            String password = pass1.Text;
            String conpassword = pass2.Text;
            if (!(Regex.IsMatch(first, @"[A-Za-z]")))
            {
                MessageBox.Show("That is not a First name.");
                fname.Text = "";
                lname.Text = "";
                username.Text = "";
                pass1.Text = "";
                pass2.Text = "";
            }
            else if (!(Regex.IsMatch(last, @"[A-Za-z]")))
            {
                MessageBox.Show("That is not a Last name.");
                fname.Text = "";
                lname.Text = "";
                username.Text = "";
                pass1.Text = "";
                pass2.Text = "";
            }
            else if (!(Regex.IsMatch(password, @"[A-Za-z0-9]")))
            {
                MessageBox.Show("Password may only have letters and numbers");
                fname.Text = "";
                lname.Text = "";
                username.Text = "";
                pass1.Text = "";
                pass2.Text = "";
            }
            else if (!(password.Equals(conpassword)))
            {
                MessageBox.Show("Password do not match");
                fname.Text = "";
                lname.Text = "";
                username.Text = "";
                pass1.Text = "";
                pass2.Text = "";
            }
            else
            {
                MessageBox.Show("Your details:\nFirst name: " + first + "\nLast name: " + last + "\nUsername: " + user + "\nPassword: " + password);
                label7.Text = first;
                fname.Text = "";
                lname.Text = "";
                username.Text = "";
                pass1.Text = "";
                pass2.Text = "";
                //The user will appear on the "Logged in" Panel, after confirming details
                Logged.Visible = true;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            username.Text = "";
            pass1.Text = "";
            pass2.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Logged.Visible = true;
            Login.Visible = true;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Logged.Visible = false;
            Login.Visible = true;
            label7.Text = "";
        }

        private void LoginBtnL_Click(object sender, EventArgs e)
        {
            Logged.Visible = true;
            Login.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class LoginForm : Form
    {
        public int openHour;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked == true)
            {
                LoginPasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordCheckBox_CheckedChanged(sender, e);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            /*openHour = (DateTime.Now).Hour;
            if (false) //openHour < 10 || openHour > 18
            {
                MessageBox.Show("You can not open outside office hour(10:00 AM to 6:00 PM)");
            }
            */
            //check username and password
            if (LoginUserInput.Text == "Admin" && LoginPasswordInput.Text == "Admin")
            {
                //set the user as admin
                GlobalValues.IsAdmin = true;
                // show mainform form
                MainForm f1 = new MainForm();
                this.Hide();
                f1.Show();
            }
            else
            {
                // show labelMessage(Username password not valid)
                MessageBox.Show("Your Username/Password is not correct");
            }
        }
        private void BtnGuest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

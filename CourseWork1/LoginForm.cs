using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnGuest_Click_1(object sender, EventArgs e)
        {
            // Close the login form
            Close();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            //check username and password
            if (LoginUserInput.Text == "Admin" && LoginPasswordInput.Text == "Admin")
            {
                //set the user as admin
                GlobalValues.IsAdmin = true;

                // close the login form
                Close();
            }
            else
            {
                // show labelMessage(Username password not valid)
                labelMessage.Visible = true;
            }
        }
    }
}

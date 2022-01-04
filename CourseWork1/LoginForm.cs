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
        
        public LoginForm()
        {
            InitializeComponent();
        }

        // mask/show data on the password input field
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
            PasswordCheckBox_CheckedChanged(sender, e); // call this method when loading form
        }

        // Login button' logic 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //check username and password
            if (LoginUserInput.Text == "Admin" && LoginPasswordInput.Text == "Admin")
            {
                Helper.isAdmin = true;
                //set the user as admin
                // show mainform
                MainForm f1 = new MainForm();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Your Username/Password is not correct");
            }
        }

        // login as employee without login credentials
        private void btnEmpLogin_Click(object sender, EventArgs e)
        {
            MainForm f1 = new MainForm();
            this.Hide();
            f1.Show();
        }

        // close login form when executed
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   // close current object. i.e. Login Form
        }
    }
}

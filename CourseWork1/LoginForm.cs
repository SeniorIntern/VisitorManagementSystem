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

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpLogin_Click(object sender, EventArgs e)
        {
            MainForm f1 = new MainForm();
            this.Hide();
            f1.Show();
        }
    }
}

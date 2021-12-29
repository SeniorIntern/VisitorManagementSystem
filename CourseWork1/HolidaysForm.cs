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
    public partial class HolidaysForm : Form
    {
        public HolidaysForm()
        {
            InitializeComponent();
        }

        private void HolidaysForm_Load(object sender, EventArgs e)
        {

        }

        public static void HolidaysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.HolidayView = null;
        }

    }
}

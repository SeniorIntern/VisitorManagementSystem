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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        // added later for calling in MainForm.cs
        public static void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ReportView = null;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            /*
            Report r = Helper.GetReportByDate(dateTimerPicker1.Value);
            UpdateReport(r);
            */
        }
    }
}

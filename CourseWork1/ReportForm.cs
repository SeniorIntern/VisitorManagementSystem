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

        private void UpdateReport(Report r)
        {
            labelCountAdult.Text = r.Adult.ToString();
            labelCountChild.Text = r.Children.ToString();
            labelCountGroup.Text = r.Group.ToString();
            labelCountTotal.Text = (r.Adult + r.Children+ r.Group).ToString();
            labelTxnAdult.Text = r.AdultIncome.ToString();
            labelTxnChild.Text = r.ChildIncome.ToString();
            labelTxnGroup.Text = r.GroupIncome.ToString();
            labelTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();

            chartCount.Series["Count"].Points.Clear();
            chartCount.Series["Income"].Points.Clear();
            chartCount.Series["Count"].Points.AddXY("Adult", r.Adult);
            chartCount.Series["Count"].Points.AddXY("Child", r.Children);
            chartCount.Series["Count"].Points.AddXY("Group", r.Group);
            chartCount.Series["Income"].Points.AddXY("Adult", r.AdultIncome);
            chartCount.Series["Income"].Points.AddXY("Child", r.ChildIncome);
            chartCount.Series["Income"].Points.AddXY("Group", r.GroupIncome);
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            Report r = Helper.GetReportByDate(dateTimerPicker.Value);
            UpdateReport(r);
        }
    }
}

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
    public partial class WeekendTicketForm : Form
    {
        WeekendTicket weRates;

        public WeekendTicketForm()
        {
            InitializeComponent();
        }

        private void WeekendTicketForm_Load(object sender, EventArgs e)
        {
            ReadWeekendTktCsvFile();
            WeekendTicketsGridView.DataSource = null;
            WeekendTicketsGridView.DataSource = GlobalValues.WeekendTicketList;
        }

        public static void WeekendTicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TicketOptionForm.WeTicketView = null;
        }

        public void ReadWeekendTktCsvFile()
        {
            GlobalValues.WeekendTicketList = new List<WeekendTicket>();
            string[] weTickets = File.ReadAllLines(Helper.weTicketFilePath);
            foreach (string t in weTickets)
            {
                string[] wts = t.Split(',');
                if (wts.Length != 7) continue;
                WeekendTicket weTktObjOne = new WeekendTicket();    // creating object of Visitor class
                weTktObjOne.weTktId = Convert.ToInt32(wts[0]);
                weTktObjOne.weTktType = wts[1];
                weTktObjOne.weRate1hr = Convert.ToInt32(wts[2]);
                weTktObjOne.weRate2hr = Convert.ToInt32(wts[3]);
                weTktObjOne.weRate3hr = Convert.ToInt32(wts[4]);
                weTktObjOne.weRate4hr = Convert.ToInt32(wts[5]);
                weTktObjOne.weRateXhr = Convert.ToInt32(wts[6]);

                GlobalValues.WeekendTicketList.Add(weTktObjOne);
            }
        }

        private void btnUpdateWERate_Click(object sender, EventArgs e)
        {
            string TktType = weekendTicketType.Text;

            weRates = Helper.ChangeWeekendRate(TktType);
            if (tbWeRate1hr.Text == "" || tbWeRate2hr.Text == "" || tbWeRate3hr.Text == "" || tbWeRate4hr.Text == "" || tbWeRateXhr.Text == "")
            {
                MessageBox.Show("Textbox must not be empty.");
            }

            else
            {
                weRates.weTktId = Convert.ToInt32(weekendTicketId.Text);
                weRates.weRate1hr = Convert.ToInt32(tbWeRate1hr.Text);
                weRates.weRate2hr = Convert.ToInt32(tbWeRate2hr.Text);
                weRates.weRate3hr = Convert.ToInt32(tbWeRate3hr.Text);
                weRates.weRate4hr = Convert.ToInt32(tbWeRate4hr.Text);
                weRates.weRateXhr = Convert.ToInt32(tbWeRateXhr.Text);
                Helper.UpdateWeekendRateToCsv();
                MessageBox.Show("Update Sucessfull");
                ReadWeekendTktCsvFile();
                WeekendTicketsGridView.DataSource = null;
                WeekendTicketsGridView.DataSource = GlobalValues.WeekendTicketList;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// added for using input output functionality with CSV File
using System.IO;

namespace CourseWork1
{
    public partial class TicketForm : Form
    {
        Ticket wdRates;

        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            ReadTktCsvFile();
            WeekdayTicketsGridView.DataSource = null;
            WeekdayTicketsGridView.DataSource = GlobalValues.TicketList;
        }

        public static void TicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TicketOptionForm.TicketView = null;
        }

        public void ReadTktCsvFile()
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[] tickets = File.ReadAllLines(Helper.ticketFilePath);
            foreach (string t in tickets)
            {
                string[] ts = t.Split(',');
                if (ts.Length != 7) continue;
                Ticket tktObjOne = new Ticket();    // creating object of Visitor class
                tktObjOne.TktId = Convert.ToInt32(ts[0]);
                tktObjOne.TktType = ts[1];
                tktObjOne.Rate1hr = Convert.ToInt32(ts[2]);
                tktObjOne.Rate2hr = Convert.ToInt32(ts[3]);
                tktObjOne.Rate3hr = Convert.ToInt32(ts[4]);
                tktObjOne.Rate4hr = Convert.ToInt32(ts[5]);
                tktObjOne.RateXhr = Convert.ToInt32(ts[6]);
                GlobalValues.TicketList.Add(tktObjOne);
            }
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            string wdTktType = TicketType.Text;

            wdRates = Helper.ChangeWeekdayRate(wdTktType);  //to create
            if (tbWdRate1hr.Text == "" || tbWdRate2hr.Text == "" || tbWdRate3hr.Text == "" || tbWdRate4hr.Text == "" || tbWdRateXhr.Text == "")
            {
                MessageBox.Show("Textbox must not be empty.");
            }

            else
            {
                wdRates.TktId = Convert.ToInt32(weekdayTicketId.Text);
                wdRates.Rate1hr = Convert.ToInt32(tbWdRate1hr.Text);
                wdRates.Rate2hr = Convert.ToInt32(tbWdRate2hr.Text);
                wdRates.Rate3hr = Convert.ToInt32(tbWdRate3hr.Text);
                wdRates.Rate4hr = Convert.ToInt32(tbWdRate4hr.Text);
                wdRates.RateXhr = Convert.ToInt32(tbWdRateXhr.Text);
                Helper.UpdateWeekdayRateToCsv();      //to create
                MessageBox.Show("Update Sucessfull");
                ReadTktCsvFile();
                WeekdayTicketsGridView.DataSource = null;
                WeekdayTicketsGridView.DataSource = GlobalValues.TicketList; // to correct
            }
        }
    }
}

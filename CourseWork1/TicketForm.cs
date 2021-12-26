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
        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load_1(object sender, EventArgs e)
        {
            TicketsGridView.DataSource = null;
            ReadTktCsvFile();
        }

        public static void TicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.TicketView = null;
        }

        string TfilePath = "C:\\ProjectFiles\\ticketRate.csv";
        private void AddTktRateToCsv(int TktId, string TktType, int Rate1hr, int Rate2hr, int Rate3hr)
        {
            string newRt = "\n" + TktId + "," + TktType + "," + Rate1hr + "," + Rate2hr + "," + Rate3hr;
            File.AppendAllText(TfilePath, newRt);
        }

        public void ReadTktCsvFile()
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[]tickets = File.ReadAllLines(TfilePath);
            foreach (string t in tickets)
            {
                string[] ts = t.Split(',');
                if (ts.Length != 5) continue;
                Ticket tktObjOne = new Ticket();    // creating object of Visitor class
                tktObjOne.TktId = Convert.ToInt32(ts[0]);
                tktObjOne.TktType = ts[1];
                tktObjOne.Rate1hr = Convert.ToInt32(ts[2]);
                tktObjOne.Rate2hr = Convert.ToInt32(ts[3]);
                tktObjOne.Rate3hr = Convert.ToInt32(ts[4]);

                GlobalValues.TicketList.Add(tktObjOne);
            }
            TicketsGridView.DataSource = GlobalValues.TicketList;
        }
        private void btnAddRate_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket tktObjTwo = new Ticket();
                tktObjTwo.TktId = (int)TicketId.Value;
                tktObjTwo.TktType = TicketType.Text;
                tktObjTwo.Rate1hr = (int)TicketFirstRate.Value;
                tktObjTwo.Rate2hr = (int)TicketSecondRate.Value;
                tktObjTwo.Rate3hr = (int)TicketThirdRate.Value;

                GlobalValues.TicketList.Add(tktObjTwo);

                AddTktRateToCsv(tktObjTwo.TktId, tktObjTwo.TktType, tktObjTwo.Rate1hr, tktObjTwo.Rate2hr, tktObjTwo.Rate3hr);
                TicketId.Value = tktObjTwo.TktId + 1;
                TicketType.Text = tktObjTwo.TktType;
                TicketFirstRate.Value = tktObjTwo.Rate1hr;
                TicketSecondRate.Value = tktObjTwo.Rate2hr;
                TicketThirdRate.Value = tktObjTwo.Rate3hr;

                MessageBox.Show("Ticket Rate Added Sucessfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input! Please enter correct data.");
            }
            TicketsGridView.DataSource = null;
            TicketsGridView.DataSource = GlobalValues.TicketList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork1
{
    public partial class ExitForm : Form
    {
        static string entryfilePath = "C:\\ProjectFiles\\visitors.csv";
        static string ticketFilePath = "C:\\ProjectFiles\\ticketRate.csv";

        public ExitForm()
        {
            InitializeComponent();
        }

        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        // find entry details of the visitor by using visitorId
        public static Visitor GetRecordWithId(string searchterm)
        {
            if (GlobalValues.VisitorList == null || GlobalValues.VisitorList.Count < 1)
            {
                GlobalValues.VisitorList = Helper.ReadCsvFile(entryfilePath);
            }

            int id = Convert.ToInt32(searchterm);
            Visitor visitor = null;
            foreach (Visitor v in GlobalValues.VisitorList)
            {
                if (v.Id == id)
                {
                    visitor = v;
                }
            }
            return visitor;
        }

        public static Ticket GetTktRecordWithId(string searchterm)
        {
            if (GlobalValues.TicketList == null || GlobalValues.TicketList.Count < 1) // replace TicketList.Count
            {
                GlobalValues.TicketList = Helper.ReadTktCsvFile(ticketFilePath);
            }

            int tktid = Convert.ToInt32(searchterm);
            Ticket ticket = null;
            foreach (Ticket t in GlobalValues.TicketList)
            {
                if (t.TktId == tktid) // identify Id and id
                {
                    ticket = t;
                }
            }
            return ticket;
        }

        // fetch cost data for ticketType
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String Id = searchId.Text;
            Visitor v = GetRecordWithId(Id);

            btnExit.Visible = true;
            labelType.Text = v.Type.ToString();
            labelCount.Text = v.Count.ToString();
            labelEntry.Text = v.entryTime.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // settings visibility
            labelDuration.Visible = true;
            labelExit.Visible = true;
            btnComplete.Visible = true;

            labelExit.Text = DateTime.Now.ToString();

            // calculate duration
            int durationHr = (DateTime.Now - Convert.ToDateTime(labelEntry.Text)).Hours;
            int durationMins = (DateTime.Now - Convert.ToDateTime(labelEntry.Text)).Minutes;
            labelDuration.Text = durationHr.ToString() + "Hrs" + durationMins.ToString() + "Mins";

            // calculate cost
            String TktId = searchId.Text;
            Ticket t = GetTktRecordWithId(TktId);

            labelCost.Visible = true;
            labelCost.Text = t.Rate2hr.ToString();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            /*
            // btnComplete will save all the details on a csv file.
            AddExitRecordsToCsv(vtrObjTwo.Id, vtrObjTwo.Type, vtrObjTwo.Count, vtrObjTwo.entryTime);
            VisitorId.Value = vtrObjTwo.Id + 1; // auto increment for visitor Id
            VisitorType.Text = "";
            VisitorCount.Value = vtrObjTwo.Count;

            MessageBox.Show("Visitor exit details Recorded");
            */
        }
    }
}

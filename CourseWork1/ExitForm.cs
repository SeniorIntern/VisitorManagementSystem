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

        // settings instance variables
        static int TktId;
        static int totalHours;
        static int totalCharge;
        static int rate;
        static int m = 1;

        public ExitForm()
        {
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            TicketForm TF = new TicketForm();
            TF.ReadTktCsvFile();
        }

        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        // fetch cost data for ticketType
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            String Id = searchId.Text;
            Visitor v = Helper.GetRecordWithId(Id);
            btnExit.Visible = true;
            try
            {
                labelType.Text = v.Type.ToString();
                labelCount.Text = v.Count.ToString();
                labelEntry.Text = v.entryTime.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Visitor with that Id is not available");
            }
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
            
            /* 
            a minute more will be taken as an additional hour. i.e duration 1hr 1 minute will be charged
            same as 2 hour.
            */
            if(durationMins >= 1)
            {
                totalHours = durationHr + 1; // if it's not been an hour i.e 0. +1 will set it as 1 hour
            }

            // calculate cost
            if (labelType.Text == "Child")
            {
                TktId = 1;
                m = Convert.ToInt32(labelCount.Text);
            }
            else if (labelType.Text == "Adult")
            {
                TktId = 2;
                m = Convert.ToInt32(labelCount.Text);
            }
            else if (labelType.Text == "Group")
            { 
                m = 1;
                if(Convert.ToInt32(labelCount.Text) <= 5)
                {
                    TktId = 3;
                }
                if (Convert.ToInt32(labelCount.Text) > 5 &  Convert.ToInt32(labelCount.Text) <= 10)
                {
                    TktId = 4;
                }
                if (Convert.ToInt32(labelCount.Text) > 10 & Convert.ToInt32(labelCount.Text) <= 15)
                {
                    TktId = 5;
                }
                // visitor count is limited to 15 in entryForm
            }
            else
            {
                MessageBox.Show("Not available");
            }
            
            Ticket t = Helper.GetTktRecordWithId(TktId);

            switch (totalHours)
            {
                case 1:
                    rate = t.Rate1hr;
                    break;
                case 2:
                    rate = t.Rate2hr;
                    break;
                case 3:
                    rate = t.Rate3hr;
                    break;
                default:
                    rate = t.RateXhr;
                    break;
            }

            labelCost.Visible = true;
            totalCharge = rate * m;
            labelCost.Text = totalCharge.ToString(); 
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
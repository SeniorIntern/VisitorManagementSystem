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
        static int TktIdvalue;
        static int totalHours;
        static int totalCharge;
        static int rate;
        static int m = 1; // m will be the multiplier. multiply rate per person by visitor count.

        public ExitForm()
        {
            InitializeComponent();
        }

        // load necessary class' objects as required
        private void ExitForm_Load(object sender, EventArgs e)
        {
            TicketForm TF = new TicketForm();
            WeekendTicketForm WeekendTF = new WeekendTicketForm();
            TF.ReadTktCsvFile();
            WeekendTF.ReadWeekendTktCsvFile();
            radioButtonApplyWeekdayRate.Visible = false;
            radioButtonApplyWeekendRate.Visible = false;
            labelRateType.Visible = false;
        }

        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        // fetch visitor data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            labelType.Visible = true;
            labelCount.Visible = true;
            String Id = searchId.Text;
            Visitor v = Helper.GetRecordWithId(Id);
            labelRateType.Visible = true;
            radioButtonApplyWeekdayRate.Visible = true;
            radioButtonApplyWeekendRate.Visible = true;

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

        // logic for calculating cost based on duration hours and day
        private void btnExit_Click(object sender, EventArgs e)
        {
            // settings visibility
            labelDuration.Visible = true;
            labelExit.Visible = true;
            btnComplete.Visible = true;

            labelExit.Text = DateTime.Now.ToString();

            // Select ticket rate options to apply
            //radioButtonApplyWeekdayRate
            

            // calculate duration
            int durationHr = (DateTime.Now - Convert.ToDateTime(labelEntry.Text)).Hours;
            int durationMins = (DateTime.Now - Convert.ToDateTime(labelEntry.Text)).Minutes;
            labelDuration.Text = durationHr.ToString() + "Hrs" + durationMins.ToString() + "Mins";
            
            if(durationHr == 0 && durationMins == 0)
            {
                totalHours = 1;
            }
            /* 
            a minute more will be taken as an additional hour. i.e duration 1hr 1 minute will be charged
            same as 2 hour.
            */
            if (durationMins >= 1)
            {
                totalHours = durationHr + 1; // if it's not been an hour i.e 0. +1 will set it as 1 hour
            }

            // calculate cost for weekend
            if (radioButtonApplyWeekendRate.Checked == true)
            {
                if (labelType.Text == "Child")
                {
                    TktIdvalue = 1;
                    m = Convert.ToInt32(labelCount.Text);
                }
                else if (labelType.Text == "Adult")
                {
                    TktIdvalue = 2;
                    m = Convert.ToInt32(labelCount.Text);
                }
                else if (labelType.Text == "Group")
                {
                    m = 1;
                    if (Convert.ToInt32(labelCount.Text) <= 5)
                    {
                        TktIdvalue = 3;
                    }
                    if (Convert.ToInt32(labelCount.Text) > 5 & Convert.ToInt32(labelCount.Text) <= 10)
                    {
                        TktIdvalue = 4;
                    }
                    if (Convert.ToInt32(labelCount.Text) > 10 & Convert.ToInt32(labelCount.Text) <= 15)
                    {
                        TktIdvalue = 5;
                    }
                    // visitor count is limited to 15 in entryForm
                }
                else
                {
                    MessageBox.Show("Not available");
                }

                WeekendTicket wt = Helper.GetWeTktRecordWithId(TktIdvalue);

                switch (totalHours)
                {
                    case 1:
                        rate = wt.weRate1hr;
                        break;
                    case 2:
                        rate = wt.weRate2hr;
                        break;
                    case 3:
                        rate = wt.weRate3hr;
                        break;
                    case 4:
                        rate = wt.weRate4hr;
                        break;
                    default:
                        rate = wt.weRateXhr;
                        break;
                }

                labelCost.Visible = true;
                totalCharge = rate * m;
                labelCost.Text = totalCharge.ToString();
            }

            // calculate cost for weekday
            if (radioButtonApplyWeekdayRate.Checked == true)
            {
                if (labelType.Text == "Child")
                {
                    TktIdvalue = 1;
                    m = Convert.ToInt32(labelCount.Text);
                }
                else if (labelType.Text == "Adult")
                {
                    TktIdvalue = 2;
                    m = Convert.ToInt32(labelCount.Text);
                }
                else if (labelType.Text == "Group")
                {
                    m = 1;
                    if (Convert.ToInt32(labelCount.Text) <= 5)
                    {
                        TktIdvalue = 3;
                    }
                    if (Convert.ToInt32(labelCount.Text) > 5 & Convert.ToInt32(labelCount.Text) <= 10)
                    {
                        TktIdvalue = 4;
                    }
                    if (Convert.ToInt32(labelCount.Text) > 10 & Convert.ToInt32(labelCount.Text) <= 15)
                    {
                        TktIdvalue = 5;
                    }
                    // visitor count is limited to 15 in entryForm
                }
                else
                {
                    MessageBox.Show("Not available");
                }

                Ticket t = Helper.GetTktRecordWithId(TktIdvalue);

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
                    case 4:
                        rate = t.Rate4hr;
                        break;
                    default:
                        rate = t.RateXhr;
                        break;
                }
                labelCost.Visible = true;
                totalCharge = rate * m;
                labelCost.Text = totalCharge.ToString();
            }


        }
        // btnComplete will save all the details on a csv file.
        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                Record rcd = new Record();    // creating record' object
                rcd.vId = (int)searchId.Value;
                rcd.vType = labelType.Text;
                rcd.vCount = Convert.ToInt32(labelCount.Text);
                rcd.vEntTime = Convert.ToDateTime(labelEntry.Text);
                rcd.vExtTime = Convert.ToDateTime(labelExit.Text);
                rcd.vDuration = labelDuration.Text;
                rcd.vCost = Convert.ToInt32(labelCost.Text);

                GlobalValues.RecordList.Add(rcd);

                Helper.AddRecordToCsv(rcd.vId, rcd.vType, rcd.vCount, rcd.vEntTime, rcd.vExtTime, rcd.vDuration, rcd.vCost);
                rcd.vId = Convert.ToInt32(searchId.Value);
                rcd.vType =  labelType.Text;
                rcd.vCount = Convert.ToInt32(labelCount.Text);
                rcd.vEntTime = Convert.ToDateTime(labelEntry.Text);
                rcd.vExtTime = Convert.ToDateTime(labelExit.Text);
                rcd.vDuration = labelDuration.Text;
                rcd.vCost = Convert.ToInt32(labelCost.Text);
                     
                MessageBox.Show("Exit Record Saved");
            }
            catch (FormatException)
            {
                MessageBox.Show("Something went wrong with btnComplete");
            }
        }

        // set button exit visibility as true when weekday rate radio button is clicked
        private void radioButtonApplyWeekdayRate_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Visible = true;
        }

        // set button exit visibility as true when Weekend rate radio button is clicked
        private void radioButtonApplyWeekendRate_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Visible = true;
        }
    }
}

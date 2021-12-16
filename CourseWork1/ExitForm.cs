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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }
        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*
            rec.ExitTime = DateTime.Now;
            labelExit.Text = DateTime.Now.ToString("yyyy/MM/dd" HH:MM);

            int durationHr = (rec.ExitTime - rec.EntryTime).Hours;
            int durationHr = (rec.ExitTime - rec.EntryTime).Minutes;
            labelDuration.Text = durationHr + "hr" + durationMin + "min";

            List<TktRate> rateList = Helper.GetTktRateList(GlobalValues.TktRateWeekdayFile); // incomplete
            if(rate == null)
            {
                MessageBox.Show("Error fetching tkt rate");
            }

            rec.Income = Helper.GetCost(rec.EntryTime, rec.ExitTime, rate, rec.Count);
            labelCost.Text = rec.Incom.ToString();
            btnComplete.Visible = True;
            */
        }

        /*
        private void btnsearch_click(object sender, eventargs e)
        {
            int id = (int)inputid.value;
            rec = helper.getrecordwithid(id);
            if(rec != null)
            {
                labeltype.text = rec.tkttype;
                labelcount.text = rec.count.tostring();
                labelentry.text = rec.entrytime.tostring("yyyy/mm/dd hh:mm");
                btnexit.visible = true;
            }
            else
            {
                messagebox.show("record not found\n" + globalvalues.msg);
                showemptyvalues();
            }
        }
        */
    }
}

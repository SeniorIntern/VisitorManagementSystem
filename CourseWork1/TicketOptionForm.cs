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
    public partial class TicketOptionForm : Form
    {
        public TicketOptionForm()
        {
            InitializeComponent();
        }

       
        public static void TicketOptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.TicketOptView = null;
        }

        private void TicketOptionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWeekdaysTicket_Click(object sender, EventArgs e)
        {
            ShowTicketForm();
        }

        public static TicketForm TicketView;
        private void ShowTicketForm()
        {
            if (TicketView == null)
            {
                TicketView = new TicketForm();
                TicketView.FormClosed += TicketForm.TicketForm_FormClosed;
                TicketView.Show();
            }
            else
            {
                TicketView.Activate();
            }
        }

        private void btnHolidaysTicket_Click(object sender, EventArgs e)
        {
            ShowWeekendTicketForm();
        }

        public static WeekendTicketForm WeTicketView;
        private void ShowWeekendTicketForm()
        {
            if (WeTicketView == null)
            {
                WeTicketView = new WeekendTicketForm();
                WeTicketView.FormClosed += WeekendTicketForm.WeekendTicketForm_FormClosed;
                WeTicketView.Show();
            }
            else
            {
                WeTicketView.Activate();
            }
        }
    }
}

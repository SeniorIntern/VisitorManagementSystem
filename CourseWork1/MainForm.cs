using System;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class MainForm : Form
    {
        LoginForm LF;
        MainForm MF;

        public MainForm()
        {
            InitializeComponent();
            timer1.Start(); // for showing system' time in menu strip
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set button visibility and labels for admin and staff
            if (Helper.isAdmin)
            {
                labelGreetUser.Text = "Welcome ADMIN";
                labelEmployeeMsg.Visible = false;
            }
            else
            {
                labelGreetUser.Text = "Welcome Employee";
                btnDailyRepForm.Enabled = false;
                btnTicketsForm.Enabled = false;
                btnWeeklyRepForm.Enabled = false;
                labelEmployeeMsg.Visible = true;
            }

            btnWeekdaysRate.Visible = false;
            btnWeekendRate.Visible = false;
        }

        // setup timer on a label to show time on menustrip
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; //  creating DateTime object: dt
            this.LabelDate.Text = dt.ToString();
        }

        LoginForm LoginF;
        private void LF_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginF = null;
            menuStrip.Enabled = true;   // enable MenuStrip
        }

        // for showing Entry Form
        private void btnEntryForm_Click(object sender, EventArgs e)
        {
            ShowEntryForm();    // calling entry form-showing method
        }

        public static EntryForm EntryView;

        // Logic to show entry form
        private void ShowEntryForm()
        {
            if (EntryView == null)
            {
                EntryView = new EntryForm();
                EntryView.FormClosed += EntryForm.EntryForm_FormClosed;
                EntryView.Show();
            }
            else
            {
                EntryView.Activate();
            }
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            ShowExitForm(); // calling exit form-showing method
        }

        public static ExitForm ExitView;
        // Logic to show Exit Form
        private void ShowExitForm()
        {
            if (ExitView == null)
            {
                ExitView = new ExitForm();
                ExitView.FormClosed += ExitForm.ExitForm_FormClosed;
                ExitView.Show();
            }
            else
            {
                ExitView.Activate();
            }
        }

        private void btnDailyRepForm_Click(object sender, EventArgs e)
        {
            ShowDayReportForm();    // calling daily report form-showing method
        }

        public static DailyReportForm ReportView;
        // Logic to show Daily Report Form
        private void ShowDayReportForm()
        {
            if (ReportView == null)
            {
                ReportView = new DailyReportForm();
                ReportView.FormClosed += DailyReportForm.ReportForm_FormClosed;
                ReportView.Show();
            }
            else
            {
                ReportView.Activate();
            }
        }

        // Logic to set button visibility for Weekday ticket rate button and weekend ticket rate button
        private void btnTicketsForm_Click(object sender, EventArgs e)
        {
            btnWeekdaysRate.Visible = true;
            btnWeekendRate.Visible = true;

        }

        private void btnWeeklyRepForm_Click(object sender, EventArgs e)
        {
            ShowWeeklyReportForm(); // calling weekly report form-showing method
        }

        public static WeeklyReportForm WeeklyReportView;
        // Logic to show Weekly Report Form
        private void ShowWeeklyReportForm()
        {
            if (WeeklyReportView == null)
            {
                WeeklyReportView = new WeeklyReportForm();
                WeeklyReportView.FormClosed += WeeklyReportForm.WeeklyReportForm_FormClosed;
                WeeklyReportView.Show();
            }
            else
            {
                WeeklyReportView.Activate();
            }
        }

        // logout button logic.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();   // close current form
            LF = new LoginForm();
            LF.Show();  // show login form
        }

        private void btnWeekdaysRate_Click(object sender, EventArgs e)
        {
            ShowTicketForm();   // calling weekday ticket form-showing method
        }

        public static TicketForm TicketView;
        // Logic to show Ticket Form
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

        private void btnWeekendRate_Click(object sender, EventArgs e)
        {
            ShowWeekendTicketForm();    // calling weekly ticket form-showing method
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

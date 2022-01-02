using System;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class MainForm : Form
    {
        //WeeklyReportForm wrf;
        LoginForm LF;
        MainForm MF;

        public MainForm()
        {
            InitializeComponent();
            //ShowLogin(); // For showing login Form when program starts
            timer1.Start(); // for showing time
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //menuStrip.Enabled = false; // fow disabling menustrip
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
        }

        //labelGreetUser.Text = "Welcome, Admin";
        private void timer1_Tick(object sender, EventArgs e)
        {
            // creating DateTime object: dt
            DateTime dt = DateTime.Now;
            this.LabelDate.Text = dt.ToString();
        }

        LoginForm LoginF;
        private void LF_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginF = null;
            menuStrip.Enabled = true;   // enable MenuStrip
        }

        // for showing entry form onClicking button
        private void btnEntryForm_Click(object sender, EventArgs e)
        {
            ShowEntryForm();
        }

        public static EntryForm EntryView;
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
            ShowExitForm();
        }

        public static ExitForm ExitView;
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
            ShowDayReportForm();
        }

        public static DailyReportForm ReportView;
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

        private void btnTicketsForm_Click(object sender, EventArgs e)
        {
            ShowTicketOptForm();
        }

        public static TicketOptionForm TicketOptView;
        private void ShowTicketOptForm()
        {
            if (TicketOptView == null)
            {
                TicketOptView = new TicketOptionForm();
                TicketOptView.FormClosed += TicketOptionForm.TicketOptionForm_FormClosed;
                TicketOptView.Show();
            }
            else
            {
                TicketOptView.Activate();
            }
        }

        private void btnWeeklyRepForm_Click(object sender, EventArgs e)
        {
            ShowWeeklyReportForm();
        }

        public static WeeklyReportForm WeeklyReportView;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LF = new LoginForm();
            LF.Show();
        }

    }
}

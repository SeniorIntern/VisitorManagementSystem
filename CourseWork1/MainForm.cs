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
            btnWeekdaysRate.Visible = true;
            btnWeekendRate.Visible = true;

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

        private void btnWeekdaysRate_Click(object sender, EventArgs e)
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

        private void btnWeekendRate_Click(object sender, EventArgs e)
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

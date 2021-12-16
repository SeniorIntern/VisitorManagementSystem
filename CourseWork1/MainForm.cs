using System;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            ShowLogin(); // For showing login Form when program starts
            timer1.Start(); // for showing time
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // creating DateTime object: dt
            DateTime dt = DateTime.Now;
            this.LabelDate.Text = dt.ToString();
        }

        LoginForm LF;
        private void LF_FormClosed(object sender, FormClosedEventArgs e)
        {
            LF = null;
            // enable MenuStrip
            menuStrip.Enabled = true;
        }

        // for showing login form
        private void ShowLogin()
        {
            if (LF == null)
            {
                LF = new LoginForm();
                LF.FormClosed += LF_FormClosed;
                LF.MdiParent = this;
                LF.Show();
            }
            else
            {
                LF.Activate();
            }
        }

        // for showing entry form
        private void EntryFormMenu_Click(object sender, EventArgs e)
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

        // for showing exit form
        private void ExitFormMenu_Click(object sender, EventArgs e)
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

        // for showing report form
        private void ReportFormMenu_Click(object sender, EventArgs e)
        {
            ShowReportForm();
        }
        public static ReportForm ReportView;
        private void ShowReportForm()
        {
            if (ReportView == null)
            {
                ReportView = new ReportForm();
                ReportView.FormClosed += ReportForm.ReportForm_FormClosed;
                ReportView.Show();
            }
            else
            {
                ReportView.Activate();
            }
        }

        // for showing ticket form
        private void TicketFormMenu_Click(object sender, EventArgs e)
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

        // for showing ticket form
        private void VisitorFormMenu_Click(object sender, EventArgs e)
        {
            ShowVisitorForm();
        }
        public static VisitorForm VisitorView;
        private void ShowVisitorForm()
        {
            if (VisitorView == null)
            {
                VisitorView = new VisitorForm();
                VisitorView.FormClosed += VisitorForm.VisitorForm_FormClosed;
                VisitorView.Show();
            }
            else
            {
                VisitorView.Activate();
            }
        }
    }
}

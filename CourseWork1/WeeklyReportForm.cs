using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class WeeklyReportForm : Form
    {
        public WeeklyReportForm()
        {
            InitializeComponent();
        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {
            
        }

        public static void WeeklyReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.WeeklyReportView = null;
        }

        public static List<Record> GetRecordsFromCSV(string recordFilePath)
        {
            GlobalValues.RecordList = new List<Record>();
            string[] records = File.ReadAllLines(recordFilePath);
            foreach (string rds in records)
            {
                string[] recs = rds.Split(',');
                if (recs.Length != 7) continue;
                Record recObj = new Record();
                recObj.vId = Convert.ToInt32(recs[0]);
                recObj.vType = recs[1];
                recObj.vCount = Convert.ToInt32(recs[2]);
                recObj.vEntTime = Convert.ToDateTime(recs[3]);
                recObj.vExtTime = Convert.ToDateTime(recs[4]);
                recObj.vDuration = recs[5];
                recObj.vCost = Convert.ToInt32(recs[6]);
                GlobalValues.RecordList.Add(recObj);
            }
            return GlobalValues.RecordList;
        }

        public static Report GetReportPerDay(DateTime day)
        {
            List<Record> recordList = GetRecordsFromCSV(Helper.recordFilePath);
            Report report = new Report();
            report.Date = day;
            foreach (Record r in recordList)
            {
                if (r.vEntTime.DayOfYear != day.DayOfYear) continue;
                if (r.vType == "Adult")
                {
                    report.Adult += r.vCount;
                    report.AdultIncome += r.vCost;
                }
                else if (r.vType == "Child")
                {
                    report.Children += r.vCount;
                    report.ChildIncome += r.vCost;
                }
                else if (r.vType == "Group")
                {
                    report.Group += r.vCount;
                    report.GroupIncome += r.vCost;
                }
            }
            return report;
        }

        private void UpdateReportA(Report r)
        {
            DayACountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayATxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayA.Text = DateTime.Now.DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.Clear();
            WeeklyReportchart.Series["TotalEarnings"].Points.Clear();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayA.Text, DayACountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayA.Text, DayATxnTotal.Text);
        }

        private void UpdateReportB(Report r)
        {
            DayBCountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayBTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayB.Text = DateTime.Now.AddDays(-1).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayB.Text, DayBCountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayB.Text, DayBTxnTotal.Text);
        }

        private void UpdateReportC(Report r)
        {
            DayCCountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayCTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayC.Text = DateTime.Now.AddDays(-2).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayC.Text, DayCCountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayC.Text, DayCTxnTotal.Text);
        }

        private void UpdateReportD(Report r)
        {
            DayDCountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayDTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayD.Text = DateTime.Now.AddDays(-3).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayD.Text, DayDCountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayD.Text, DayDTxnTotal.Text);
        }

        private void UpdateReportE(Report r)
        {
            DayECountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayETxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayE.Text = DateTime.Now.AddDays(-4).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayE.Text, DayECountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayE.Text, DayETxnTotal.Text);
        }

        private void UpdateReportF(Report r)
        {
            DayFCountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayFTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayF.Text = DateTime.Now.AddDays(-5).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayF.Text, DayFCountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayF.Text, DayFTxnTotal.Text);
        }

        private void UpdateReportG(Report r)
        {
            DayGCountTotal.Text = (r.Adult + r.Children + r.Group).ToString();
            DayGTxnTotal.Text = (r.AdultIncome + r.ChildIncome + r.GroupIncome).ToString();
            DayG.Text = DateTime.Now.AddDays(-6).DayOfWeek.ToString();
            WeeklyReportchart.Series["TotalVisitors"].Points.AddXY(DayG.Text, DayGCountTotal.Text);
            WeeklyReportchart.Series["TotalEarnings"].Points.AddXY(DayG.Text, DayGTxnTotal.Text);
        }

        private void CalculateValues()
        {
            for (int i = 0; i < 7; i++)
            {
                Report r = GetReportPerDay(DateTime.Today.AddDays(-i));
                if(i == 0)
                {
                    UpdateReportA(r);
                }
                if (i == 1)
                {
                    UpdateReportB(r);
                }
                if (i == 2)
                {
                    UpdateReportC(r);
                }
                if (i == 3)
                {
                    UpdateReportD(r);
                }
                if (i == 4)
                {
                    UpdateReportE(r);
                }
                if (i == 5)
                {
                    UpdateReportF(r);
                }
                if (i == 6)
                {
                    UpdateReportG(r);
                }
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            CalculateValues();
            labelSortOpt.Visible = true;
            radioBtnSortByCount.Visible = true;
            radioBtnSortByEarnings.Visible = true;
        }

        private void sortingByCount() {
            int a, b, c, d, e, f, g;
            a = Convert.ToInt32(DayACountTotal.Text);
            b = Convert.ToInt32(DayBCountTotal.Text);
            c = Convert.ToInt32(DayCCountTotal.Text);
            d = Convert.ToInt32(DayDCountTotal.Text);
            e = Convert.ToInt32(DayECountTotal.Text);
            f = Convert.ToInt32(DayFCountTotal.Text);
            g = Convert.ToInt32(DayGCountTotal.Text);

            int[] arr = { a, b, c, d, e, f, g };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++) {
                for (int i = 0; i <= arr.Length - 2; i++) {
                    if (arr[i] > arr[i + 1]) {
                        temp= arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            label5.Text = arr[0].ToString();
            label6.Text = arr[1].ToString();
            label7.Text = arr[2].ToString();
            label8.Text = arr[3].ToString();
            label9.Text = arr[4].ToString();
            label10.Text = arr[5].ToString();
            label11.Text = arr[6].ToString();
        }

        private void sortingByEarnings()
        {
            int a, b, c, d, e, f, g;
            a = Convert.ToInt32(DayATxnTotal.Text);
            b = Convert.ToInt32(DayBTxnTotal.Text);
            c = Convert.ToInt32(DayCTxnTotal.Text);
            d = Convert.ToInt32(DayDTxnTotal.Text);
            e = Convert.ToInt32(DayETxnTotal.Text);
            f = Convert.ToInt32(DayFTxnTotal.Text);
            g = Convert.ToInt32(DayGTxnTotal.Text);

            // BUBLE SORTING
            int[] arr = { a, b, c, d, e, f, g };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            label5.Text = arr[0].ToString();
            label6.Text = arr[1].ToString();
            label7.Text = arr[2].ToString();
            label8.Text = arr[3].ToString();
            label9.Text = arr[4].ToString();
            label10.Text = arr[5].ToString();
            label11.Text = arr[6].ToString();
        }


        private void radioBtnSortByCount_CheckedChanged(object sender, EventArgs e)
        {
            sortingByCount();
            label13.Text = "Visitor Count by rising order";
        }

        private void radioBtnSortByEarnings_CheckedChanged(object sender, EventArgs e)
        {
            sortingByEarnings();
            label13.Text = "Total Income by rising order";
        }

    }
}

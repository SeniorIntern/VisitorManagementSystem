using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// added for using input output functionality with CSV File
using System.IO;

namespace CourseWork1
{
    public partial class EntryForm : Form
    {
       public EntryForm()
        {
            InitializeComponent();
        }

        public static void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.EntryView = null; 
        }

        string filePath = "C:\\ProjectFiles\\visitors.csv";

        public void ReadCsvFile()
        {
            GlobalValues.VisitorList = new List<Visitor>();
            string[] visitors = File.ReadAllLines(filePath);
            foreach (string s in visitors)
            {
                string[] st = s.Split(',');
                Visitor vt = new Visitor();
                vt.Id = Convert.ToInt32(st[0]);
                vt.Type = st[1];
                vt.Count = Convert.ToInt32(st[2]);

                GlobalValues.VisitorList.Add(vt); 
            }
            VisitorsGridView.DataSource = GlobalValues.VisitorList;
        }

        private void EntryForm_Load_1(object sender, EventArgs e)
        {
            VisitorsGridView.DataSource = null;
            ReadCsvFile();
        }

        private void AddStudentToCsv(int Id, string Type, int Count)
        {
            string newSt = "\n" + Id + "," + Type + "," + Count;
            File.AppendAllText(filePath, newSt);
        }

        private void BtnAddStudent_Click_1(object sender, EventArgs e)
        {
            // newCode C01 starts(12/16)
            if (VisitorId.Value < 1 || VisitorType.SelectedItem == null || VisitorCount.Value == 0)
            {
                MessageBox.Show("Please enter valid info");
                return;
            }
            else if (VisitorType.SelectedItem.ToString().Equals("Group") && VisitorCount.Value < 5) // incomplete
            {
                MessageBox.Show("Group must have at least 5 people");
                return;
            }
            else
            {
                try
                {
                    Visitor v = new Visitor();
                    v.Id = (int)VisitorId.Value;
                    v.Type = VisitorType.Text;
                    v.Count = (int)VisitorCount.Value;

                    GlobalValues.VisitorList.Add(v);

                    AddStudentToCsv(v.Id, v.Type, v.Count);
                    VisitorId.Value = v.Id + 1;
                    VisitorType.Text = "";
                    VisitorCount.Value = v.Count;
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Invalid Input! Please enter correct data.");
                }
                VisitorsGridView.DataSource = null;
                VisitorsGridView.DataSource = GlobalValues.VisitorList;
            }

            Record r = new Record();
            r.VId = (int)VisitorId.Value;
            r.VType = VisitorType.SelectedItem.ToString();
            r.VCount = (int)VisitorCount.Value;
            r.VEntrytime = DateTime.Now;
            r.VExitTime = r.VEntrytime;

            //GlobalValues.recordList.Add(r);
            //helper.saverecordtofile(r);
            //clearinputs();
            //MessageBox.Show("ticket issue complete");
            // newCode C01 ends
        }
    }
}

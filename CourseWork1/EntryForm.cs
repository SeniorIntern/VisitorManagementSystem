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
            // string records = File.ReadAllText(filePath);
            // OutputBox.Text = records;
            GlobalValues.VisitorList = new List<Visitor>();
            string[] visitors = File.ReadAllLines(filePath);
            foreach (string s in visitors)
            {
                // s-> {"1,	KhukuriRam, Kharel,	8"}
                string[] st = s.Split(',');
                // st-> {"1",	"KhukuriRam" "Kharel",	"8"}

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
            //StudentGridView.DataSource = GlobalValues.StudentList;
            //MainForm.ReadCsvFile();
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

        /*
        if(inputId.Value <1 || comboType.SelectedItem == null)
        {
            MessageBox.Show("Please enter valid info");
            return;
        }
        else if(comboType.SelectedItem.ToString().Equals("Group") && input) // incomplete
        {
	        MessageBox.Show("Group must have at least 5 people");
        }

        Record r = new Record()
        r.Id = (int)inputId.Value;
        r.TktType = comboType.SelectedItem.ToString();
        r.Count = (int)inputCount.Value
        r.EntryTime = DateTime.Now;
        r.ExitTime = r.EntryTime;

        GlobalValues.recordList.Add(r);
        Helper.SaveRecordToFile(r);
        ClearInputs();
        MessageBox.Show("Ticket Issue Complete");
        */
    }
}

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
        public static string rec;

        public ExitForm()
        {
            InitializeComponent();
        }

        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        public static void addRecord(string ID, string name, string age, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filepath, true))
                {
                    file.WriteLine(ID + "," + name + "," + age);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("addRecord did an oopsie");
            }
        }

        public static void GetRecordWithId(string searchterm)
        {
            string filepath = "testData.csv";
            int positionOfSearchTerm = 1;
            positionOfSearchTerm--;
            string[] recordNotFound = { };
            try
            {
                string[] lines = File.ReadAllLines(@filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchterm, fields, positionOfSearchTerm))
                    {
                        int Eid =  Int32.Parse(fields[0]);
                        string etype =  fields[1];
                        int Ecount = Int32.Parse(fields[2]);

                        Record r = new Record();
                        r.VId = Eid;
                        r.VType = etype;
                        r.VCount = Ecount;
                        //r.VEntryTime = DateTime.Now;
                        //r.VExitTime = r.VEntryTime;
                        GlobalValues.RecordList.Add(r);

                        rec = r.VId + "," + r.VType + "," + r.VCount;
                        //string[] exitValues = new string[] { rec };
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("GetRecordWithId did an oopsie");
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //String Id = searchId.Text;
            //GetRecordWithId(Id);

            String Id = searchId.Text;
            GetRecordWithId(Id);

            MessageBox.Show(rec);
            labelCount.Text = rec[rec.Length - 1].ToString();
        }
    }
}

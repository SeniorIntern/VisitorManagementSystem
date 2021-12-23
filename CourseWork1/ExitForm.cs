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
        static string entryfilePath = "C:\\ProjectFiles\\visitors.csv";
        // public static string rec; for testing 1
        // public static string[] recArray = { "","",""}; for testing 1
        public ExitForm()
        {
            InitializeComponent();
        }

        public static void ExitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ExitView = null;
        }

        // testing method
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

        public static Visitor GetRecordWithId(string searchterm)
        {
            //
            if (GlobalValues.VisitorList == null || GlobalValues.VisitorList.Count < 1)
            {
                GlobalValues.VisitorList = Helper.ReadCsvFile(entryfilePath);
            }
            
            int id = Convert.ToInt32(searchterm);
            Visitor visitor = null;//= new Visitor();
            foreach (Visitor v in GlobalValues.VisitorList)
            {
                if (v.Id == id)
                {
                    visitor = v;
                }
            }
            return visitor;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String Id = searchId.Text;
            Visitor v = GetRecordWithId(Id);

            //MessageBox.Show(rec);  For testinig 1
            //labelCount.Text = rec[rec.Length - 1].ToString(); For testing 1

            labelType.Text = v.Type.ToString();
            labelCount.Text = v.Count.ToString();
            labelEntry.Text = v.entryTime.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            labelExit.Text = DateTime.Now.ToString();

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            /*
            AddExitRecordsToCsv(vtrObjTwo.Id, vtrObjTwo.Type, vtrObjTwo.Count, vtrObjTwo.entryTime);
            VisitorId.Value = vtrObjTwo.Id + 1; // auto increment for visitor Id
            VisitorType.Text = "";
            VisitorCount.Value = vtrObjTwo.Count;

            MessageBox.Show("Visitor exit details Recorded");
            */
        }
    }
}

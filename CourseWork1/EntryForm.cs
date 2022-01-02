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
        public static string entryFilePath = "visitors.csv";
        public EntryForm()
        {
            InitializeComponent();
            Helper.ReadWETktRate();
            Helper.ReadWDTktRate();
            Helper.ReadCsvFile(entryFilePath);
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            radioButtonWeekDay.Checked = true;
            VisitorId.Text = Convert.ToString(GlobalValues.VisitorList.Max<Visitor>(vtrObjOne => vtrObjOne.Id) + 1); // increase Id value after adding visitor
        }

        /*
        public static void DeserializableRecordData()
        {
            if (File.Exists(Helper.SerializedFilePath))
            {
                Stream stream = File.Open(Helper.SerializedFilePath, FileMode.Open);
                if (stream != null && stream.Length > 0)
                {
                    BinaryFormatter BF = new BinaryFormatter();

                    // Reading visit list information
                    Helper.RecordCollxnList = (RecordCollxn)BF.Deserialize(stream);
                    MessageBox.Show("Sucessfully deserlized");
                }
                stream.Close();
            }
        }
        */

        public static void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.EntryView = null;
        }

        private void AddStudentToCsv(int Id, string Type, int Count, DateTime entryTime)
        {
            string newVt = "\n" + Id + "," + Type + "," + Count + "," + entryTime;
            File.AppendAllText(Helper.entryFilePath, newVt);
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (VisitorType.SelectedItem.ToString().Equals("") || VisitorCount.Value == 0)
            {
                MessageBox.Show("Please enter valid info");
                return;
            }
            else if (VisitorType.SelectedItem.ToString().Equals("Group") && VisitorCount.Value < 5)
            {
                MessageBox.Show("Group must have at least 5 people");
                return;
            }
            else if (VisitorType.SelectedItem.ToString().Equals("Group") && VisitorCount.Value > 15)
            {
                MessageBox.Show("Group of 15 or more is not allowed");
                return;
            }
            else
            {
                try
                {
                    Visitor vtrObjTwo = new Visitor();
                    vtrObjTwo.Id = Convert.ToInt32(VisitorId.Text);
                    vtrObjTwo.Type = VisitorType.Text;
                    vtrObjTwo.Count = (int)VisitorCount.Value;
                    vtrObjTwo.entryTime = DateTime.Now;

                    GlobalValues.VisitorList.Add(vtrObjTwo);

                    AddStudentToCsv(vtrObjTwo.Id, vtrObjTwo.Type, vtrObjTwo.Count, vtrObjTwo.entryTime);
                    VisitorId.Text = vtrObjTwo.Id.ToString();
                    VisitorType.Text = "";
                    VisitorCount.Value = vtrObjTwo.Count;
                    VisitorId.Text = Convert.ToString(GlobalValues.VisitorList.Max<Visitor>(vtrObjOne => vtrObjOne.Id) + 1); // increase Id value after adding visitor

                    MessageBox.Show("Visitor entry done");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input! Please enter correct data.");
                }
                //TktGridView.DataSource = null;
                //TktGridView.DataSource = GlobalValues.VisitorList;
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            //Helper.AddRecordToCsv(GlobalValues.RecordList);
            //Helper.SerializableRecordData(GlobalValues.RecordList);
        }

        private void radioButtonWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            TktGridView.DataSource = GlobalValues.TicketList;
        }

        private void radioButtonWeekEnd_CheckedChanged(object sender, EventArgs e)
        {
            TktGridView.DataSource = GlobalValues.WeekendTicketList;
        }
    }
}

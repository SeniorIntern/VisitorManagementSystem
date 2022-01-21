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
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseWork1
{
    public partial class EntryForm : Form
    {
        public int openHour;
        public static string entryFilePath = "visitors.csv";
        public static string srzFilePath = "visitorData";

        //  call necessary methods 
        public EntryForm()
        {
            InitializeComponent();
            Helper.ReadWETktRate();
            Helper.ReadWDTktRate();
            Helper.ReadCsvFile(entryFilePath);
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            radioButtonWeekDay.Checked = true;  // check radio button when form loads 
            VisitorId.Text = Convert.ToString(GlobalValues.VisitorList.Max<Visitor>(vtrObjOne => vtrObjOne.Id) + 1); // increase Id value after adding visitor

            EntryGridView.DataSource = null;
            EntryGridView.DataSource = GlobalValues.VisitorList;

            openHour = (DateTime.Now).Hour;
            try {
                //openHour < 10 || openHour > 18
                if (false) // Disable visitor entry outside office hours. 
                {
                    btnAddVisitor.Enabled = false;
                    MessageBox.Show("Visitor can not enter outside working hours(10:00 AM to 6:00 PM)");
                }
            }
            catch
            {
                MessageBox.Show("Check your date time format or Check User Manual");
            }

        }

        // form close action
        public static void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.EntryView = null;
        }

        // logic to add Visitor to CSV 
        private void AddStudentToCsv(int Id, string Type, int Count, DateTime entryTime)
        {
            string newVt = "\n" + Id + "," + Type + "," + Count + "," + entryTime;
            File.AppendAllText(Helper.entryFilePath, newVt);
        }

        // Deserialized added visitor details
        public void DeSerializeEntryData()
        {
            try
            {
                if (File.Exists(srzFilePath))
                {
                    using (FileStream stream = new FileStream(srzFilePath, FileMode.Open))
                    {
                        if (stream != null && stream.Length > 0)
                        {
                            VisitorCollection vColl = new VisitorCollection();
                            BinaryFormatter binaryFormatter = new BinaryFormatter();

                            // Reading visitor list information
                            vColl = (VisitorCollection)binaryFormatter.Deserialize(stream);
                            GlobalValues.VisitorList = vColl.VisitorList;
                            MessageBox.Show("Sucessfully deserialized");
                        }
                        stream.Close();
                    }
                    EntryGridView.DataSource = null;
                    EntryGridView.DataSource = GlobalValues.VisitorList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeSerialization unsucessfull");
            }
        }

        // Show Weekday ticket rate when weekday radio button is checked
        private void radioButtonWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            TktGridView.DataSource = GlobalValues.TicketList;
        }

        // Show Weekend ticket rate when weekday radio button is checked
        private void radioButtonWeekEnd_CheckedChanged(object sender, EventArgs e)
        {
            TktGridView.DataSource = GlobalValues.WeekendTicketList;
        }

        // trigger form validation, logic to add visitor details on visitor list
        private void btnAddVisitor_Click(object sender, EventArgs e)
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

                    // seraialization process
                    using (FileStream stream = new FileStream(srzFilePath, FileMode.Create))
                    {
                        VisitorCollection vColl = new VisitorCollection();
                        vColl.VisitorList = GlobalValues.VisitorList;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, vColl);
                        stream.Close();
                    }
                    MessageBox.Show("Sucessfully Serialized");
                    DeSerializeEntryData(); // callind DeSerialization method

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input! Please enter correct data.");
                }
            }
        }
    }
}

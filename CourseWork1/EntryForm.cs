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
        public static string entryFilePath = "visitors.csv";
        public static string srzFilePath = "visitorData";

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

            EntryGridView.DataSource = null;
            EntryGridView.DataSource = GlobalValues.VisitorList;
        }

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

                    using (FileStream stream = new FileStream(srzFilePath, FileMode.Create))
                    {
                        VisitorCollection vColl = new VisitorCollection();
                        vColl.VisitorList = GlobalValues.VisitorList;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, vColl);
                        stream.Close();
                    }
                    MessageBox.Show("Sucessfully Serialized");
                    DeSerializeEntryData();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input! Please enter correct data.");
                }
                //TktGridView.DataSource = null;
                //TktGridView.DataSource = GlobalValues.VisitorList;
            }
        }

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
                            MessageBox.Show("Visitor Count: " + GlobalValues.VisitorList.Count);
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

            }
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

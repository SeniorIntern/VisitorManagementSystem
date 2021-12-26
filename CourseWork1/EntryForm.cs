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
        string entryfilePath = "C:\\ProjectFiles\\visitors.csv";

        public EntryForm()
        {
            InitializeComponent();
        }
        
        private void EntryForm_Load(object sender, EventArgs e)
        {
            VisitorsGridView.DataSource = null;
            VisitorsGridView.DataSource = Helper.ReadCsvFile(entryfilePath);
        }

        public static void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.EntryView = null;
        }

        private void AddStudentToCsv(int Id, string Type, int Count, DateTime entryTime)
        {
            string newVt = "\n" + Id + "," + Type + "," + Count + "," + entryTime;
            File.AppendAllText(entryfilePath, newVt);
        }

        private void BtnAddStudent_Click_1(object sender, EventArgs e)
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
                    vtrObjTwo.Id = (int)VisitorId.Value;
                    vtrObjTwo.Type = VisitorType.Text;
                    vtrObjTwo.Count = (int)VisitorCount.Value;
                    vtrObjTwo.entryTime = DateTime.Now;

                    GlobalValues.VisitorList.Add(vtrObjTwo);

                    AddStudentToCsv(vtrObjTwo.Id, vtrObjTwo.Type, vtrObjTwo.Count, vtrObjTwo.entryTime);
                    VisitorId.Value = vtrObjTwo.Id + 1; // auto increment for by 1 with inital visitor Id value
                    VisitorType.Text = "";
                    VisitorCount.Value = vtrObjTwo.Count;

                    MessageBox.Show("Visitor entry done");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input! Please enter correct data.");
                }
                VisitorsGridView.DataSource = null;
                VisitorsGridView.DataSource = GlobalValues.VisitorList;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    internal class Helper
    {
        static string entryfilePath = "C:\\ProjectFiles\\visitors.csv";
        static string ticketFilePath = "C:\\ProjectFiles\\ticketRate.csv";
        static string recordFilePath = "C:\\ProjectFiles\\records.csv";

        // create a method with return type-list for reading entry csv file
        public static List<Visitor> ReadCsvFile(string entryFilePath)
        {
            GlobalValues.VisitorList = new List<Visitor>();
            string[] visitors = File.ReadAllLines(entryFilePath);
            foreach (string v in visitors)
            {
                string[] vs = v.Split(',');
                if (vs.Length != 4) continue;
                Visitor vtrObjOne = new Visitor();
                vtrObjOne.Id = Convert.ToInt32(vs[0]);
                vtrObjOne.Type = vs[1];
                vtrObjOne.Count = Convert.ToInt32(vs[2]);
                vtrObjOne.entryTime = Convert.ToDateTime(vs[3]);
                GlobalValues.VisitorList.Add(vtrObjOne);
            }
            return GlobalValues.VisitorList;
        }

        public static List<Record> ReadRecordCsvFile(string recordFilePath)
        {
            GlobalValues.RecordList = new List<Record>();
            string[] records = File.ReadAllLines(recordFilePath);
            foreach (string r in records)
            {
                string[] rc = r.Split(',');
                if (rc.Length != 4) continue;
                Record rcObjTwo = new Record();     // creating second object of record
                rcObjTwo.vId = Convert.ToInt32(rc[0]);
                rcObjTwo.vType = rc[1];
                rcObjTwo.vCount = Convert.ToInt32(rc[2]);
                rcObjTwo.vEntTime = Convert.ToDateTime(rc[3]);
                rcObjTwo.vExtTime = Convert.ToDateTime(rc[4]);
                rcObjTwo.vDuration = rc[5];
                rcObjTwo.vCost = Convert.ToInt32(rc[3]);
                GlobalValues.RecordList.Add(rcObjTwo);
            }
            return GlobalValues.RecordList;
        }

        public static List<Ticket> ReadTktCsvFile(string ticketFilePath)
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[] tickets = File.ReadAllLines(ticketFilePath);
            foreach (string t in tickets)
            {
                string[] ts = t.Split(',');
                if (ts.Length != 5) continue;
                Ticket tktObjOne = new Ticket();
                tktObjOne.TktId = Convert.ToInt32(ts[0]);
                tktObjOne.TktType = ts[1];
                tktObjOne.Rate1hr = Convert.ToInt32(ts[2]);
                tktObjOne.Rate2hr = Convert.ToInt32(ts[3]);
                tktObjOne.Rate3hr = Convert.ToInt32(ts[4]);
                GlobalValues.TicketList.Add(tktObjOne);
            }
            return GlobalValues.TicketList;
        }

        // ExitForm-find entry details of the visitor by using visitorId
        public static Visitor GetRecordWithId(string searchterm)
        {
            if (GlobalValues.VisitorList == null || GlobalValues.VisitorList.Count < 1)
            {
                GlobalValues.VisitorList = ReadCsvFile(entryfilePath);

            }

            int id = Convert.ToInt32(searchterm);
            Visitor visitor = null;
            foreach (Visitor v in GlobalValues.VisitorList)
            {
                if (v.Id == id)
                {
                    visitor = v;
                }
            }
            return visitor;
        }

        // ExitForm- get ticket Id using visitor type
        public static Ticket GetTktRecordWithId(int searchterm)
        {
            if (GlobalValues.TicketList == null)
            {
                GlobalValues.TicketList = ReadTktCsvFile(ticketFilePath);
            }

            int tktid = searchterm;
            Ticket ticket = null;
            foreach (Ticket t in GlobalValues.TicketList)
            {
                if (t.TktId == tktid)
                {
                    ticket = t;
                }
            }
            return ticket;
        }

        // for saving exit details on CSV 
        public static void AddRecordToCsv(int vId, string vType, int vCount, DateTime vEntTime, DateTime vExtTime, string vDuration, int vCost)
        {
            string newRc = "\n" + vId + "," + vType + "," + vCount + "," + vEntTime + "," + vExtTime + "," + vDuration + "," + vCost;
            File.AppendAllText(recordFilePath, newRc);
        }

        //public static List<Record> GetRecordsFromCSV(string filePath)
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

        public static Report GetReportByDate(DateTime day)
        {
            //List<Record> recordList = GetRecordsFromCSV(Globalvalues.RecordFilePath);
            List<Record> recordList = GetRecordsFromCSV(recordFilePath);
            Report report = new Report();
            report.Date = day;
            foreach(Record r in recordList)
            {
                if (r.vEntTime.DayOfYear != day.DayOfYear) continue;
                if(r.vType == "Adult")
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

    }
}

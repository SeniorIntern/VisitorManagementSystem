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
        public static bool isAdmin = false;
        public static string entryFilePath = "visitors.csv";
        public static string ticketFilePath = "ticketRate.csv";
        public static string weTicketFilePath = "WeekEndtktRate.csv";
        public static string recordFilePath = "records.csv";
        public static string SerializedFilePath = "Record.save";
        
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

        public static List<Ticket> ReadTktCsvFile(string ticketFilePath)
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[] tickets = File.ReadAllLines(ticketFilePath);
            foreach (string t in tickets)
            {
                string[] ts = t.Split(',');
                if (ts.Length != 7) continue;
                Ticket tktObjOne = new Ticket();
                tktObjOne.TktId = Convert.ToInt32(ts[0]);
                tktObjOne.TktType = ts[1];
                tktObjOne.Rate1hr = Convert.ToInt32(ts[2]);
                tktObjOne.Rate2hr = Convert.ToInt32(ts[3]);
                tktObjOne.Rate3hr = Convert.ToInt32(ts[4]);
                tktObjOne.Rate4hr = Convert.ToInt32(ts[5]);
                tktObjOne.RateXhr = Convert.ToInt32(ts[6]);
                GlobalValues.TicketList.Add(tktObjOne);
            }
            return GlobalValues.TicketList;
        }

        public static List<WeekendTicket> ReadWeTktCsvFile(string ticketFilePath)
        {
            GlobalValues.WeekendTicketList = new List<WeekendTicket>();
            string[] weTickets = File.ReadAllLines(weTicketFilePath);
            foreach (string t in weTickets)
            {
                string[] wts = t.Split(',');
                if (wts.Length != 7) continue;
                WeekendTicket weTktObjOne = new WeekendTicket();
                weTktObjOne.weTktId = Convert.ToInt32(wts[0]);
                weTktObjOne.weTktType = wts[1];
                weTktObjOne.weRate1hr = Convert.ToInt32(wts[2]);
                weTktObjOne.weRate2hr = Convert.ToInt32(wts[3]);
                weTktObjOne.weRate3hr = Convert.ToInt32(wts[4]);
                weTktObjOne.weRate4hr = Convert.ToInt32(wts[5]);
                weTktObjOne.weRateXhr = Convert.ToInt32(wts[6]);
                GlobalValues.WeekendTicketList.Add(weTktObjOne);
            }
            return GlobalValues.WeekendTicketList;
        }


        // Read weekend ticket price rates from CSV file
        public static void ReadWETktRate()
        {
            GlobalValues.WeekendTicketList = new List<WeekendTicket>();
            string[] lines = File.ReadAllLines(weTicketFilePath);
            foreach (string line in lines)
            {

                string[] st = line.Split(',');
                if (st.Length != 7)
                {
                    continue;
                }
                WeekendTicket s = new WeekendTicket();
                s.weTktId = Convert.ToInt32(st[0]);
                s.weTktType = st[1];
                s.weRate1hr = Convert.ToInt32(st[2]);
                s.weRate2hr = Convert.ToInt32(st[3]);
                s.weRate3hr = Convert.ToInt32(st[4]);
                s.weRate4hr = Convert.ToInt32(st[5]);
                s.weRateXhr = Convert.ToInt32(st[6]);
                GlobalValues.WeekendTicketList.Add(s);
            }
        }

        // Read weekend ticket price rates from CSV file
        public static void ReadWDTktRate()
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[] lines = File.ReadAllLines(ticketFilePath);
            foreach (string line in lines)
            {

                string[] st = line.Split(',');
                if (st.Length != 7)
                {
                    continue;
                }
                Ticket s = new Ticket();
                s.TktId = Convert.ToInt32(st[0]);
                s.TktType = st[1];
                s.Rate1hr = Convert.ToInt32(st[2]);
                s.Rate2hr = Convert.ToInt32(st[3]);
                s.Rate3hr = Convert.ToInt32(st[4]);
                s.Rate4hr = Convert.ToInt32(st[5]);
                s.RateXhr = Convert.ToInt32(st[6]);
                GlobalValues.TicketList.Add(s);
            }
        }

        /*
        public void ReadTktCsvFile()
        {
            GlobalValues.TicketList = new List<Ticket>();
            string[] tickets = File.ReadAllLines(ticketFilePath);
            foreach (string t in tickets)
            {
                string[] ts = t.Split(',');
                if (ts.Length != 6) continue;
                Ticket tktObjOne = new Ticket();    // creating object of Visitor class
                tktObjOne.TktId = Convert.ToInt32(ts[0]);
                tktObjOne.TktType = ts[1];
                tktObjOne.Rate1hr = Convert.ToInt32(ts[2]);
                tktObjOne.Rate2hr = Convert.ToInt32(ts[3]);
                tktObjOne.Rate3hr = Convert.ToInt32(ts[4]);
                tktObjOne.RateXhr = Convert.ToInt32(ts[5]);
                GlobalValues.TicketList.Add(tktObjOne);
            }
        }
        */

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

        // ExitForm-find entry details of the visitor by using visitorId
        public static Visitor GetRecordWithId(string searchterm)
        {
            if (GlobalValues.VisitorList == null || GlobalValues.VisitorList.Count < 1)
            {
                GlobalValues.VisitorList = ReadCsvFile(entryFilePath);

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

        // ExitForm- get Weekday ticket Id using visitor type
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

        // ExitForm- get Weekend ticket Id using visitor type
        public static WeekendTicket GetWeTktRecordWithId(int searchterm)
        {
            if (GlobalValues.WeekendTicketList == null)
            {
                GlobalValues.WeekendTicketList = ReadWeTktCsvFile(weTicketFilePath); //change read method
            }

            int tktid = searchterm;
            WeekendTicket weTicket = null;
            foreach (WeekendTicket wt in GlobalValues.WeekendTicketList)
            {
                if (wt.weTktId == tktid)
                {
                    weTicket = wt;
                }
            }
            return weTicket;
        }


        public static void AddRecordToCsv(int vId, string vType, int vCount, DateTime vEntTime, DateTime vExtTime, string vDuration, int vCost)
        {
            string newRc = "\n" + vId + "," + vType + "," + vCount + "," + vEntTime + "," + vExtTime + "," + vDuration + "," + vCost;
            File.AppendAllText(recordFilePath, newRc);
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
                recObj.vEntTime = Convert.ToDateTime(recs[3]);  // FormatException error
                recObj.vExtTime = Convert.ToDateTime(recs[4]);
                recObj.vDuration = recs[5];
                recObj.vCost = Convert.ToInt32(recs[6]);
                GlobalValues.RecordList.Add(recObj);
            }
            return GlobalValues.RecordList;
        }

        public static Report GetReportByDate(DateTime day)
        {
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

        public static WeekendTicket ChangeWeekendRate(string weTktType)
        {
            return GlobalValues.WeekendTicketList.Find(weRates => weRates.weTktType == weTktType);
        }

        public static void UpdateWeekendRateToCsv()
        {
            try
            {
                string rates = "";
                string path = weTicketFilePath;
                for (int i = 0; i < GlobalValues.WeekendTicketList.Count; i++)
                {
                    WeekendTicket rate = GlobalValues.WeekendTicketList[i];
                    if (i == GlobalValues.WeekendTicketList.Count - 1)
                    {
                        rates += rate.weTktId + "," + rate.weTktType + "," + rate.weRate1hr + "," + rate.weRate2hr + "," + rate.weRate3hr + "," + rate.weRate4hr + "," + rate.weRateXhr;

                    }
                    else
                    {
                        rates += rate.weTktId + "," + rate.weTktType + "," + rate.weRate1hr + "," + rate.weRate2hr + "," + rate.weRate3hr + "," + rate.weRate4hr + "," + rate.weRateXhr + "\n";
                    }
                }
                if (rates != "")
                {
                    File.WriteAllText(path, rates);
                }
            }
            catch (Exception e)
            {
                
            }
        }

        public static Ticket ChangeWeekdayRate(string wdTktType)
        {
            return GlobalValues.TicketList.Find(wdRates => wdRates.TktType == wdTktType);
        }

        public static void UpdateWeekdayRateToCsv()
        {
            try
            {
                string rates = "";
                string path = ticketFilePath;
                for (int i = 0; i < GlobalValues.TicketList.Count; i++)
                {
                    Ticket rate = GlobalValues.TicketList[i];
                    if (i == GlobalValues.TicketList.Count - 1)
                    {
                        rates += rate.TktId + "," + rate.TktType + "," + rate.Rate1hr + "," + rate.Rate2hr + "," + rate.Rate3hr + "," + rate.Rate4hr + "," + rate.RateXhr;
                    }
                    else
                    {
                        rates += rate.TktId + "," + rate.TktType + "," + rate.Rate1hr + "," + rate.Rate2hr + "," + rate.Rate3hr + "," + rate.Rate4hr + "," + rate.RateXhr + "\n";
                    }
                }
                if (rates != "")
                {
                    File.WriteAllText(path, rates); 
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}

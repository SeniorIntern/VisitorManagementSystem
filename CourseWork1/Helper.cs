using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    internal class Helper
    {

        /*
        public static void  AppendRecordToCsv(string filepath, Record r) {
            string rec = r.Id + "," + r.TktType + "," + r.Count + "," + r.EntryType + "," + r.EntryType + "," + r.Income;
            string[] lines = new string[] { rec };
            File.AppendAllLines(filepath, lines);
        }

        public static void SaveRecordToFIle(Record r) {
            string fullPath = Path.Combine(GlobalValues.DirPath, GlobalValues.fullPath  ) // incomplete
            if(!Directory.Exists(GlobalValues.DirPath))
            {
                //create Directory
                Directory.CreateDirectory(GlobalValues.DirPath);
            }
            if(!File.Exists(fullPath))
            {
                File.Create(fullPath);
            }
            AppendRecordToCsv(fullPath, r);
        }

        public static void UpdateRecordToCsv(string filepath, list<Record> record) { }
        public static string[ GetLinesFromFile(string filepath) { }

        public static list<TktRate> GetTktRateList(string filepath) {
            if(!File.Exists(filePath))
            {
                return null;
            }

            List<TktRate> rateList = new List<TktRate>();
            string[] rates = GetLinesFromFile(filePath);
            foreach(string line in rates)
            {
                string[] st = line.Split(',');
                if(st.length != 5) continue;
                TktRate rate = new TktRate();
                rate.tktRate = st[0];
                rate.Rate1hr = Convert.ToInt32(st[1]);
                rate.Rate1hr = Convert.ToInt32(st[2]);
                rate.Rate1hr = Convert.ToInt32(st[3]);
                rate.Rate1hr = Convert.ToInt32(st[4]);
                rateList.Add(rate);
            }
            return rateList;
        }

        public static list<Record> GetRecordsFromCsv(string filepath) { }
        public static void GetRecordWithId(int id) { }

        public static int GetCost(DateTime entry, DateTime exit, TktRate rate, int count = 1) 
        {
            int[]  rates = { 0, rate.Rate1hr, rate.Rate2hr, rate.Rate3hr, rate.Rate4hr };
            
            int durationHr = (exit - entry).Hours;
            int durationMin = (exit - entry).Minutes;

            int costHr = rates[durationHr];
            int costMin = (rates[Math.Min(durationHr + 1, rates.Length-1)] - rates[durationHr]) / 60 * durationMin;
            int totalCost = costHr + costMin;
            return Math.Max(rate.Rate1hr, totalCost)*count;
        }

        public static Report GetReportByDate(DateTime day) {
            List<Record> recordList = GetRecordsFromCsv(GlobalValues.RecordFilePath)
            report.Date = new Report();
            report.Date = day;
            forearch(Record r in recordList)
            {
                if(r.EntryTime.DayOfYear != day.DayofYear) continue;
                if(r.TktType == "Adult")
                {
                    report.Adults += r.Count;
                    report.AdultIncome += r.Income;
                }
                else if(r.TktType == "Child")
                {
                    report.Children += r.Count;    
                    report.ChildIncome += r.Income;
                }
                else if(r.TktType == "Group")
                {
                    report.Group += r.Count;    
                    report.GroupIncome += r.Income;
                }
            }
            return report;
        }
        */
    }
}

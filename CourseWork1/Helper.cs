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
        /*
        
        public static void AppendRecordToCsv(string filepath, Record r)
        {
            string rec = r.VId + "," + r.VType + "," + r.VCount + "," + r.VEntrytime + "," + r.VExitTime + "," + r.Income;
            string[] lines = new string[] { rec };
            File.AppendAllLines(filepath, lines);
        }

        public static void SaveRecordToFile(Record r)
        {
            string fullPath = Path.Combine(GlobalValues.DirPath, GlobalValues.fullPath) // incomplete
            if (!Directory.Exists(GlobalValues.DirPath))
            {
                //create Directory
                Directory.CreateDirectory(GlobalValues.DirPath);
            }
            if (!File.Exists(fullPath))
            {
                File.Create(fullPath);
            }
            AppendRecordToCsv(fullPath, r);
        }
        
        public static list<Ticket> GetTktRateList(string filepath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            List<Ticket> rateList = new List<Ticket>();
            string[] rates = GetLinesFromFile(filePath);
            foreach (string line in rates)
            {
                string[] st = line.Split(',');
                if (st.Length != 5) continue;
                Ticket rate = new Ticket();
                rate.tktRate = st[0];
                rate.Rate1hr = Convert.ToInt32(st[1]);
                rate.Rate2hr = Convert.ToInt32(st[2]);
                rate.Rate3hr = Convert.ToInt32(st[3]);
                rateList.Add(rate);
            }
            return rateList;
        }

        public static void GetCost()
        {

        }
        
        public static void GetRecordWithId(int id) { }
        
        public static string GetLinesFromFile(string filepath) { }
        */
    }
}

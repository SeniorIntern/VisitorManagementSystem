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
        // create a method with returnType-list
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


        /*
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

        */
    }
}
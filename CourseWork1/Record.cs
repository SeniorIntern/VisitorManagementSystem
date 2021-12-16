using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    internal class Record
    {
        public int Id { get; set; }
        public String TktType { get; set; }
        public int Count { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public float Income { get; set; }

    }
}

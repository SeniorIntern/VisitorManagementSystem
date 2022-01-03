using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    [Serializable]
    public class Visitor
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public DateTime entryTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day0 { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Day3 { get; set; }
        public string Day4 { get; set; }
        public string Day5 { get; set; }
        public string Day6 { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeFinish { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    class TaskAssign
    {
        public int Id { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeFinish { get; set; }
        public bool Day0 { get; set; }
        public bool Day1 { get; set; }
        public bool Day2 { get; set; }
        public bool Day3 { get; set; }
        public bool Day4 { get; set; }
        public bool Day5 { get; set; }
        public bool Day6 { get; set; }

        public TaskAssign()
        {
            Tasks = new Collection<Task>();
        }
    }
}

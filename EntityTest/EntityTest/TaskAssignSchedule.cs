using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class TaskAssignSchedule
    {
        public int Id { get; set; }
        public TaskAssign TaskAssign { get; set; }
        public Schedule Schedule { get; set; }
    }
}

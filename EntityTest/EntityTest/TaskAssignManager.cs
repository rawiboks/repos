using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class TaskAssignManager
    {
        public int Id { get; set; }
        public TaskAssign TaskAssign { get; set; }
        public Manager Manager { get; set; }
    }
}

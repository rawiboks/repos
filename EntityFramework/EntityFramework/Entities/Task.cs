using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public TaskAssign TAssign { get; set; }
    }
}

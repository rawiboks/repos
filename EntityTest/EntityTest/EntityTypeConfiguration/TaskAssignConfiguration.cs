using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.EntityTypeConfiguration
{
    public class TaskAssignConfiguration:EntityTypeConfiguration<TaskAssign>
    {
        public TaskAssignConfiguration()
        {
            HasRequired(t => t.Task);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.EntityTypeConfiguration
{
    public class TaskAssignScheduleConfiguration:EntityTypeConfiguration<TaskAssignSchedule>
    {
        public TaskAssignScheduleConfiguration()
        {
            HasRequired(t => t.Schedule);
            HasRequired(t => t.TaskAssign);
        }
    }
}

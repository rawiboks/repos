using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class EntityContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<test MyProperty { get; set; }
    }
}

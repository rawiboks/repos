using EntityTest.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class EntityTestContext :DbContext
    {
        public EntityTestContext() : base("EntityTestContext") { }

        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TaskAssign> TaskAssign { get; set; }
        public DbSet<TaskAssignManager> TaskAssignManager { get; set; }
        public DbSet<TaskAssignSchedule> TaskAssignSchedule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new TaskAssignConfiguration());
            modelBuilder.Configurations.Add(new TaskAssignScheduleConfiguration());
            modelBuilder.Configurations.Add(new SchedulesConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

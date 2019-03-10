using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.EntityTypeConfiguration
{
    class SchedulesConfiguration:EntityTypeConfiguration<Schedule>
    {
        public SchedulesConfiguration()
        {
            Property(s => s.Name)
                .IsRequired();

            Property(s => s.Day0)
                .IsRequired();
        }
    }
}

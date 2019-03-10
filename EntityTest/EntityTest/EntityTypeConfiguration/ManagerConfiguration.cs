using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.EntityTypeConfiguration
{
    class ManagerConfiguration : EntityTypeConfiguration<Manager>
    {
        public ManagerConfiguration()
        {
            HasRequired(m => m.Schedule);

            Property(m => m.Name)
                .IsRequired();
        }
    }
}

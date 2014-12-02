using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Models.Mapping
{
    class applyMap : EntityTypeConfiguration<apply>
    {
        public applyMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Apply);

            // Properties
            // Table & Column Mappings
            this.ToTable("apply", "pidev");
            this.Property(t => t.id_Apply).HasColumnName("id_Apply");
            this.Property(t => t.id_Freelancer).HasColumnName("id_Freelancer");
            this.Property(t => t.id_Job).HasColumnName("id_Job");
            this.Property(t => t.startDate).HasColumnName("startDate");
        }
    }
}


using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class bankMap : EntityTypeConfiguration<bank>
    {
        public bankMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("bank", "pidev");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.fund).HasColumnName("fund");
            this.Property(t => t.gain).HasColumnName("gain");
        }
    }
}

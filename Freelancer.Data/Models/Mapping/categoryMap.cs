using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class categoryMap : EntityTypeConfiguration<category>
    {
        public categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Ca);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("categories", "pidev");
            this.Property(t => t.id_Ca).HasColumnName("id_Ca");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}

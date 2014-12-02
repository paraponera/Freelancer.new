using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class claimMap : EntityTypeConfiguration<claim>
    {
        public claimMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.contenu)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);
            this.Property(t => t.contenu).IsRequired();

            this.Property(t => t.state)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("claim", "pidev");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.contenu).HasColumnName("contenu");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.title).HasColumnName("title");
        }
    }
}

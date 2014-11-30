using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class jobMap : EntityTypeConfiguration<job>
    {
        public jobMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.required_skills)
                .HasMaxLength(255);

            this.Property(t => t.state)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("job", "pidev");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.estimate_duration).HasColumnName("estimate_duration");
            this.Property(t => t.jobownerid).HasColumnName("jobownerid");
            this.Property(t => t.required_skills).HasColumnName("required_skills");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.categ_fk).HasColumnName("categ_fk");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.jobs)
                .HasForeignKey(d => d.categ_fk);

        }
    }
}

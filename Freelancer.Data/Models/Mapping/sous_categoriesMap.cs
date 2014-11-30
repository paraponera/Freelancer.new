using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class sous_categoriesMap : EntityTypeConfiguration<sous_categories>
    {
        public sous_categoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Sc);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sous_categories", "pidev");
            this.Property(t => t.id_Sc).HasColumnName("id_Sc");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.Id_Ca).HasColumnName("Id_Ca");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.sous_categories)
                .HasForeignKey(d => d.Id_Ca);

        }
    }
}

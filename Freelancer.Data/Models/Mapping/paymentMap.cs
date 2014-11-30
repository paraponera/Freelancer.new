using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class paymentMap : EntityTypeConfiguration<payment>
    {
        public paymentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("payment", "pidev");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.compte).HasColumnName("compte");
            this.Property(t => t.idfreelancer).HasColumnName("idfreelancer");
            this.Property(t => t.idjobowner).HasColumnName("idjobowner");
            this.Property(t => t.solde).HasColumnName("solde");
        }
    }
}

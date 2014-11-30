using Freelancer.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Freelancer.Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.city)
                .HasMaxLength(255);

            this.Property(t => t.country)
                .HasMaxLength(255);

            this.Property(t => t.e_mail)
                .HasMaxLength(255);

            this.Property(t => t.first_name)
                .HasMaxLength(255);

            this.Property(t => t.last_name)
                .HasMaxLength(255);

            this.Property(t => t.pwd)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            this.Property(t => t.username)
                .HasMaxLength(255);

            this.Property(t => t.about)
                .HasMaxLength(255);

            this.Property(t => t.cv)
                .HasMaxLength(255);

            this.Property(t => t.friend_list)
                .HasMaxLength(255);

            this.Property(t => t.skills)
                .HasMaxLength(255);

            this.Property(t => t.company_name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "pidev");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.e_mail).HasColumnName("e_mail");
            this.Property(t => t.first_name).HasColumnName("first_name");
            this.Property(t => t.fund).HasColumnName("fund");
            this.Property(t => t.last_name).HasColumnName("last_name");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.pwd).HasColumnName("pwd");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.about).HasColumnName("about");
            this.Property(t => t.cv).HasColumnName("cv");
            this.Property(t => t.friend_list).HasColumnName("friend_list");
            this.Property(t => t.skills).HasColumnName("skills");
            this.Property(t => t.company_name).HasColumnName("company_name");
        }
    }
}

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Freelancer.Data.Models.Mapping;
using Freelancer.Domain;
using MySql.Data.Entity;


namespace Freelancer.Data.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class pidevContext : DbContext
    {
        static pidevContext()
        {
            Database.SetInitializer<pidevContext>(null);
        }

        public pidevContext()
            : base("pidevContext")
        {
        }
        public DbSet<Friendslist> Friendslists { get; set; }
        public DbSet<bank> banks { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<claim> claims { get; set; }
        public DbSet<job> jobs { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<sous_categories> sous_categories { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new bankMap());
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new claimMap());
            modelBuilder.Configurations.Add(new jobMap());
            modelBuilder.Configurations.Add(new paymentMap());
            modelBuilder.Configurations.Add(new sous_categoriesMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}

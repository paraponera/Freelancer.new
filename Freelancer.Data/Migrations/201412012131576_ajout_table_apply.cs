namespace Freelancer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_table_apply : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.apply",
                c => new
                    {
                        id_Apply = c.Int(nullable: false, identity: true),
                        id_Freelancer = c.Int(nullable: false),
                        id_Job = c.Int(nullable: false),
                        startDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.id_Apply);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.apply");
        }
    }
}

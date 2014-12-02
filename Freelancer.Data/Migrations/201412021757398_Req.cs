namespace Freelancer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Req : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.claim", "contenu", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.claim", "contenu", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
    }
}

namespace Freelancer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingfirendlist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friendslists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idUser = c.Int(nullable: false),
                        idFriend = c.Int(nullable: false),
                        friend = c.Boolean(nullable: false),
                        request = c.Boolean(nullable: false),

                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Friendslists");
        }
    }
}

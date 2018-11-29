namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieAndCustomersSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsSubscribedToNewsLetter = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        LastUpdatedDateTime = c.DateTime(nullable: false),
                        LastUpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        LastUpdatedDateTime = c.DateTime(nullable: false),
                        LastUpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}

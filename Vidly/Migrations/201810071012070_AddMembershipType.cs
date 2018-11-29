namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        LastUpdatedDateTime = c.DateTime(nullable: false),
                        LastUpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "ID");
            AddForeignKey("dbo.Customers", "ID", "dbo.MembershipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "ID" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}

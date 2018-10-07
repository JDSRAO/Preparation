namespace Vidly.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Vidly.Models;

    public partial class PopulateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            var memberShipTypes = new List<MembershipType>()
            {
                new MembershipType() { ID = 1, SignUpFee = 0, DiscountRate = 0, DurationInMonths = 0, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 30, DiscountRate = 10, DurationInMonths = 1, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 3, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 3, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow }
            };
        }
        
        public override void Down()
        {
        }
    }
}

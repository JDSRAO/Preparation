namespace Vidly.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Identity.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Vidly.Identity.AuthContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var memberShipTypes = GetMembershipTypes();
            context.MembershipTypes.AddRange(memberShipTypes);
        }

        private List<MembershipType> GetMembershipTypes()
        {
            var memberShipTypes = new List<MembershipType>()
            {
                new MembershipType() { ID = 1, SignUpFee = 0, DiscountRate = 0, DurationInMonths = 0, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 30, DiscountRate = 10, DurationInMonths = 1, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 3, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow },
                new MembershipType() { ID = 1, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 3, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow }
            };
            return memberShipTypes;
        }
    }
}

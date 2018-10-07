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
            foreach (var item in memberShipTypes)
            {
                context.MembershipTypes.AddOrUpdate(item);
            }

            var genres = GetGenreInformation();
            foreach (var genre in genres)
            {
                context.Genres.AddOrUpdate(genre);
            }
        }

        private List<MembershipType> GetMembershipTypes()
        {
            var memberShipTypes = new List<MembershipType>()
            {
                new MembershipType() { ID = 1, SignUpFee = 0, DiscountRate = 0, DurationInMonths = 0, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow, Name = "Pay as you go" },
                new MembershipType() { ID = 2, SignUpFee = 30, DiscountRate = 10, DurationInMonths = 1, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow, Name = "Monthly" },
                new MembershipType() { ID = 3, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 4, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow, Name = "Quarterly" },
                new MembershipType() { ID = 4, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 12, CreatedDateTime = DateTime.UtcNow, CreatedBy = "Admin", LastUpdatedBy = "Admin", LastUpdatedDateTime = DateTime.UtcNow, Name = "Yearly" }
            };
            return memberShipTypes;
        }

        public List<Genre> GetGenreInformation()
        {
            var genre = new List<Genre>()
            {
                new Genre() { ID = 1, Name = "Action" },
                new Genre() { ID = 1, Name = "Romance" },
                new Genre() { ID = 1, Name = "Sci-Fi" },
                new Genre() { ID = 1, Name = "Thriller" }
            };
            return genre;
        }
    }
}

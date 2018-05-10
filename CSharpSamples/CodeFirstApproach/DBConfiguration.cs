using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.CodeFirstApproach
{
    public sealed class DBConfiguration : DbMigrationsConfiguration<EFDbContext>
    {
        public DBConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(EFDbContext context)
        {
            base.Seed(context);
        }
    }
}

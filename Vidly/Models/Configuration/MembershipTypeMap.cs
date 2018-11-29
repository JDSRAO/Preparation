using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Vidly.Models.Configuration
{
    public class MembershipTypeMap : EntityTypeConfiguration<MembershipType>
    {
        public MembershipTypeMap()
        {
            HasKey(x => x.ID);

            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.DiscountRate).IsRequired();
            Property(x => x.SignUpFee).IsRequired();
            Property(x => x.DurationInMonths).IsRequired();
            Property(x => x.CreatedDateTime).IsRequired();
            Property(x => x.CreatedBy).IsRequired();
            Property(x => x.LastUpdatedDateTime).IsRequired();
            Property(x => x.LastUpdatedBy).IsRequired();

            ToTable("MembershipTypes");
    }
    }
}
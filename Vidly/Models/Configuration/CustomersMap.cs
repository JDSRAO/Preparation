using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Models.Configuration
{
    public class CustomersMap : EntityTypeConfiguration<Customer>
    {
        public CustomersMap()
        {
            HasKey(x => x.ID);

            Property(x => x.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired();
            Property(x => x.CreatedDateTime).IsRequired();
            Property(x => x.CreatedBy).IsRequired();
            Property(x => x.LastUpdatedDateTime).IsRequired();
            Property(x => x.LastUpdatedBy).IsRequired();

            ToTable("Customers");
        }
    }
}
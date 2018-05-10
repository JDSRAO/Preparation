using CSharpSamples.CodeFirstApproach.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.CodeFirstApproach.Configuration
{
    public class UserMap : EntityTypeConfiguration<User>  
    {
        public UserMap()
        {
            //Key
            HasKey(x => x.ID);

            //Fields  
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.UserName).IsRequired().HasMaxLength(25);
            Property(t => t.Email).IsRequired();
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
            Property(t => t.IP);

            //table  
            ToTable("Users");
        }
    }
}

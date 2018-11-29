using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Vidly.Models.Configuration
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            HasKey(x => x.ID);

            Property(x => x.Name).IsRequired().HasMaxLength(50);

            ToTable("Genres");
        }
    }
}
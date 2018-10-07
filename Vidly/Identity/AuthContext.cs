using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Identity.Models;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using Vidly.Models;

namespace Vidly.Identity
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext() : base("authContext")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
          .Where(type => !String.IsNullOrEmpty(type.Namespace))
          .Where(type => type.BaseType != null && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
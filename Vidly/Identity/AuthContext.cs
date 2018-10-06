using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Identity.Models;

namespace Vidly.Identity
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext() : base("authContext")
        {

        }
    }
}
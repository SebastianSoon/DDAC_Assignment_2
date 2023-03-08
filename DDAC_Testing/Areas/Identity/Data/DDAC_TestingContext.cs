using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Testing.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Testing.Data
{
    public class DDAC_TestingContext : IdentityDbContext<DDAC_TestingUser>
    {
        public DDAC_TestingContext(DbContextOptions<DDAC_TestingContext> options)
            : base(options)
        {
        }

        public DbSet<DDAC_Testing.Models.Flower> Flower{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

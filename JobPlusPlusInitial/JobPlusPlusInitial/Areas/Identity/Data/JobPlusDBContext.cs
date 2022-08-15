using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPlusPlusInitial.Areas.Identity.Data;
using JobPlusPlusInitial.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobPlusPlusInitial.Data
{
    public class JobPlusDBContext : IdentityDbContext<ApplicationUser>
    {
        public JobPlusDBContext(DbContextOptions<JobPlusDBContext> options)
            : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

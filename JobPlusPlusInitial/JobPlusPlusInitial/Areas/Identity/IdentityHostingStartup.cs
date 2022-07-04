using System;
using JobPlusPlusInitial.Areas.Identity.Data;
using JobPlusPlusInitial.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JobPlusPlusInitial.Areas.Identity.IdentityHostingStartup))]
namespace JobPlusPlusInitial.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { 
            services.AddDbContext<JobPlusDBContext>(options =>
                options.UseSqlServer(
                    context.Configuration.GetConnectionString("JobPlusDBContextConnection")));
                   services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<JobPlusDBContext>();
            });


        }
    }
}
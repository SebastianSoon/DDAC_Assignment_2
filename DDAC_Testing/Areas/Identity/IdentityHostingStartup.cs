using System;
using DDAC_Testing.Areas.Identity.Data;
using DDAC_Testing.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DDAC_Testing.Areas.Identity.IdentityHostingStartup))]
namespace DDAC_Testing.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DDAC_TestingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DDAC_TestingContextConnection")));

                services.AddDefaultIdentity<DDAC_TestingUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DDAC_TestingContext>();
            });
        }
    }
}
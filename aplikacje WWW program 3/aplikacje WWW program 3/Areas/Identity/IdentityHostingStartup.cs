using System;
using aplikacje_WWW_program_3.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(aplikacje_WWW_program_3.Areas.Identity.IdentityHostingStartup))]
namespace aplikacje_WWW_program_3.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<aplikacje_WWW_program_3Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("aplikacje_WWW_program_3ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<aplikacje_WWW_program_3Context>();
            });
        }
    }
}
using System;
using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Addmition__Elgibilty_K_A.Areas.Identity.IdentityHostingStartup))]
namespace Addmition__Elgibilty_K_A.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DataBaseAE>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DataBaseAEConnection")));

                services.AddDefaultIdentity<Addmition__Elgibilty_K_AUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;

                })
                    .AddEntityFrameworkStores<DataBaseAE>();
            });
        }
    }
}
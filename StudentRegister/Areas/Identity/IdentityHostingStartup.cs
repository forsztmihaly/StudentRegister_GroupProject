using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentRegister.Data;

[assembly: HostingStartup(typeof(StudentRegister.Areas.Identity.IdentityHostingStartup))]
namespace StudentRegister.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StudentRegisterContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StudentRegisterContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<StudentRegisterContext>();
            });
        }
    }
}
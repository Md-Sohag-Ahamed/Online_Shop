using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Online_Shop.Data;

[assembly: HostingStartup(typeof(Online_Shop.Areas.Identity.IdentityHostingStartup))]
namespace Online_Shop.Areas.Identity
{
  public class IdentityHostingStartup : IHostingStartup
  {
    public void Configure(IWebHostBuilder builder)
    {
      builder.ConfigureServices((context, services) => {
      });
      //builder.ConfigureServices((context, services) =>
      //{
      //  services.AddDbContext<ApplicationDbContext>(options =>
      //      options.UseSqlServer(
      //          context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

      //  services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
      //      .AddEntityFrameworkStores<ApplicationDbContext>();
      //});
    }
  }
}

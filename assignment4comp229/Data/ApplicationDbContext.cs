using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace assignment4comp229.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static async System.Threading.Tasks.Task SeedUser(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            if (!context.Users.Any())
            {
                await userManager.CreateAsync(new IdentityUser() { UserName = "info@example.com", Email = "info@example.com" }, "Password@123");
                await userManager.CreateAsync(new IdentityUser() { UserName = "test@example.com", Email = "test@example.com" }, "Password@123");
            }
        }
    }
}

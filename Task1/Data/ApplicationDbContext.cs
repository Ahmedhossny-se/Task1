using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.HasDefaultSchema(""); Changes app schema
        builder.Entity<ApplicationUser>().ToTable("Users", "Task1");
        //.Ignore(e => e.PhoneNumberConfirmed); delete table     
        builder.Entity<IdentityRole>().ToTable("Roles", "Task1");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Task1");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Task1");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Task1");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Task1");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Task1");
    }
}

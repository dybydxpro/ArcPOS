using ArcPOS.Models.Auth;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ArcPOS.Data
{
    public class AuthDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> oso) : base(options, oso) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>(b =>
            {
                b.Property(e => e.AuthId).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);
            });

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser()
            {
                Id = "6872a1be-fe5e-4d2b-8ac1-26ce0c36f846",
                AuthId = 1,
                FirstName = "ArcPOS",
                LastName = "Admin",
                UserName = "tharindutd1998@gmail.com",
                NormalizedUserName = "THARINDUTD1998@GMAIL.COM",
                Email = "tharindutd1998@gmail.com",
                NormalizedEmail = "THARINDUTD1998@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEO2NZlDTC/AeRvEjQo61i7uEks7JlX0uxUFaBUIQlLiGiSZxHu7uIW43BUEoxe1fAA==",
                SecurityStamp = "ENOMQ2ITQD77EWDHLT572ZGEFSI3GDOO",
                ConcurrencyStamp = "776c7622-8ad0-484c-bf59-fb390dda1389",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "1",
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin"
                },
                new IdentityRole()
                {
                    Id = "2",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole()
                {
                    Id = "3",
                    Name = "User",
                    NormalizedName = "User"
                }
            );

            base.OnModelCreating(builder);
        }
    }
}

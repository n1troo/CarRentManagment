using CarRentManagment.Server.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>(); 

            builder.HasData(
                new ApplicationUser()
                {
                    Id = "0e350415-83bb-4464-9a02-2363e6d4aabb",
                    Email = "admin@o2.pl",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "ADMIN@O2.PL",
                    PasswordHash = hasher.HashPassword(null, "@Bc1234"),

                }
                );;
        }
    }
}

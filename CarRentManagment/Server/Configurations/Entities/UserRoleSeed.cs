using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> 
                { 
                    RoleId = "db35fdb4-b9b1-448f-ab90-c2e423a8731d",
                    UserId = "0e350415-83bb-4464-9a02-2363e6d4aabb"
                }
                );
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class RolesSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "db35fdb4-b9b1-448f-ab90-c2e423a8731d", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "bb32f9fe-8b49-436c-8070-f286fb5b8a95",  Name = "Customer", NormalizedName = "CUSTOMER" }
                );
        }
    }
}

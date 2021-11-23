using CarRentManagment.Shared.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData( 
                new Make { Id = 1, Name = "BMW", CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,  UpdatedBy = "System" },
                new Make { Id = 2, Name = "Toyota", CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,  UpdatedBy = "System" },
                new Make { Id = 3, Name = "Audi", CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,  UpdatedBy = "System" }
                );
        }
    }
}

using CarRentManagment.Shared.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model { Id = 1, Name = "E91", CreatedBy = "System", UpdatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Model { Id = 2, Name = "E90", CreatedBy = "System", UpdatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Model { Id = 3, Name = "S1", CreatedBy = "System", UpdatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Model { Id = 4, Name = "Aventis", CreatedBy = "System", UpdatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                );
        }
    }
}

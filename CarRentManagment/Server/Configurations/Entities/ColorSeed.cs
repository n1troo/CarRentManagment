using CarRentManagment.Shared.Domain;

using Microsoft.EntityFrameworkCore;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "System",
                },
                new Color
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "White",
                    UpdatedBy = "System",
                }
                );
        }
    }
}

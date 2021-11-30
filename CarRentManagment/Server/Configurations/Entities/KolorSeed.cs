using CarRentManagment.Shared.Domain;

using Microsoft.EntityFrameworkCore;

namespace CarRentManagment.Server.Configurations.Entities
{
    public class KolorSeed : IEntityTypeConfiguration<Kolor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Kolor> builder)
        {
            builder.HasData(
                new Kolor
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "System",
                },
                new Kolor
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

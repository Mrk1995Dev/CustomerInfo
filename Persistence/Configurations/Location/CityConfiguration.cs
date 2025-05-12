using Domain.Location;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.Location
{
    public class CityConfiguration : BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(30);
            base.Configure(builder);
        }
    }
}

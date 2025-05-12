using Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.User
{
    public class CustomerConfiguration : BaseEntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.Address).HasMaxLength(200);
            builder.Property(c => c.CityId).IsRequired(true);
            builder.Property(c => c.PhoneNumber).HasMaxLength(20);
            builder.Property(c => c.CityId).HasMaxLength(20);
            base.Configure(builder);
        }
    }
}

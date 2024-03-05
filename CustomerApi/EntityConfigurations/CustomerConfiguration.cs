using CustomerApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CustomerApi.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(s => s.Id).HasDefaultValue(new Guid());
            builder.Property(s => s.Name).HasMaxLength(250);
            builder.Property(s => s.LastName).HasMaxLength(250);
            builder.Property(s => s.Email).HasMaxLength(250);
            builder.Property(s => s.Address).HasMaxLength(500);
        }
    }
}

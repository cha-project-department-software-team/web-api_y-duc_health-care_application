using HealthCareApplication.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthCareApplication.Domains.Persistence.Contexts.Configurations;

public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.PersonId);

        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Age).IsRequired();
        builder.Property(x => x.PersonType).IsRequired();

        builder.HasOne(x => x.Address).WithOne().HasForeignKey<Person>(x => x.AddressId);
        builder.HasMany(x => x.HealthMetrics).WithOne(x => x.Person);
        builder.HasMany(x => x.Relatives).WithMany();
    }
}

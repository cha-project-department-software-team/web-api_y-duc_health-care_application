using HealthCareApplication.Domains.Models;
using HealthCareApplication.Domains.Persistence.Contexts.Configurations;
using Microsoft.EntityFrameworkCore;

namespace HealthCareApplication.Domains.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<HealthMetric> HealthMetrics { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AddressEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new HealthMetricEntityTypeConfiguration());
    }
}

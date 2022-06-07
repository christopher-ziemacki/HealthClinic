using HealthClinic.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthClinic.Data;

public class HealthClinicDbContext : DbContext
{
    public HealthClinicDbContext(DbContextOptions<HealthClinicDbContext> dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Person> People => Set<Person>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }

        optionsBuilder.UseNpgsql("Host=localhost;Database=health-clinic");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(p =>
        {
            p.HasKey(e => e.Id);
            p.Property(e => e.FirstName);
            p.Property(e => e.LastName);
        });

    }
}

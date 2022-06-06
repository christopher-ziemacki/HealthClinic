using HealthClinic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HealthClinic.Data;

public class HealthClinicDbContext : DbContext
{
    private readonly DbContextOptions<HealthClinicDbContext> _dbContextOptions;

    public HealthClinicDbContext(DbContextOptions<HealthClinicDbContext> dbContextOptions)
        : base(dbContextOptions)
    {
        _dbContextOptions = dbContextOptions;
    }
    
    public DbSet<Person> People { get; set; }

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

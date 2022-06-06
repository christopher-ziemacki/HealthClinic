using HealthClinic.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthClinic.Data;

public class HealthClinicDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}
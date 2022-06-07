using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HealthClinic.Data;

// public class DesignTimeHealthClinicDbContextFactory : IDesignTimeDbContextFactory<HealthClinicDbContext>
// {
//     public HealthClinicDbContext CreateDbContext(string[] args)
//     {
//         var optionsBuilder = new DbContextOptionsBuilder<HealthClinicDbContext>();
//         
//         var configuration = new ConfigurationBuilder()
//             .SetBasePath(Directory.GetCurrentDirectory())
//             .AddJsonFile("appsettings.json", true)
//             .Build();
//
//         var connectionString = configuration.GetConnectionString("DbCoreConnectionString");
//         if (connectionString is null)
//         {
//             connectionString = "Host=localhost;Database=health-clinic;Username=;Password=";
//         }
//         
//         optionsBuilder.UseNpgsql(connectionString);
//
//         return new HealthClinicDbContext(optionsBuilder.Options);
//     }
// }
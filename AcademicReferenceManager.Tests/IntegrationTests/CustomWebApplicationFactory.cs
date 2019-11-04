using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Seeding;
using System.Linq;

public class CustomWebApplicationFactory<TStartup> :  WebApplicationFactory<TStartup> where TStartup: class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();
            // Remove the app's DbContext registration.
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == 
                    typeof(DbContextOptions<ArmDbContext>));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }
            services.AddEntityFrameworkInMemoryDatabase();
            
            // Add ApplicationDbContext using an in-memory database for testing.
            services.AddDbContext<ArmDbContext>((options) => 
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
                options.UseInternalServiceProvider(serviceProvider);
            });
            
            
            // Build the service provider.
            var sp = services.BuildServiceProvider();

            using (var scope = sp.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<ArmDbContext>();
                var logger = scopedServices
                    .GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();
                
                // Wait for database to get created
                db.Database.EnsureCreated();

                // Ensure the database is created.
                try
                {
                    DatabaseSeeder seeder = new DatabaseSeeder();
                    seeder.seedDatabase(db);
                    Console.WriteLine(db.Friends.FirstOrDefault().FirstName);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred seeding the " +
                        "database with test messages. Error: {Message}", ex.Message);
                }
            }
        });
    }
    public ArmDbContext GetContext()
    {
        return Server.Host.Services.CreateScope().ServiceProvider.GetService<ArmDbContext>();
    }
}
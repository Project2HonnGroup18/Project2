using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AcademicReferenceManager.Services.Implementations;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Repositories.Implementations;

public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<Startup>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // Create a new service provider.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            services.AddSingleton<IBorrowRepository, BorrowRepository>();
            services.AddSingleton<IFriendDbContext, FriendDbContext>();
            services.AddSingleton<IPublicationDbContext, PublicationDbContext>();
            services.AddSingleton<IPublicationToFriendDbContext, PublicationToFriendDbContext>();

            // Build the service provider.
            var sp = services.BuildServiceProvider();

            // Create a scope to obtain a reference to the database contexts
            using (var scope = sp.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;

                var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

            }
        });
    }
}
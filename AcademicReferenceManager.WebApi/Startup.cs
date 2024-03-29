﻿using System;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Implementations;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Services.Implementations;
using AcademicReferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechnicalRadiation.WebApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using AcademicReferenceManager.Repositories.Seeding;

namespace AcademicReferenceManager.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<ArmDbContext>(options => options.UseSqlite("Data Source=ArmDb.db"));
            services.AddTransient<IFriendService, FriendService>();
            services.AddTransient<IPublicationService, PublicationService>();
            services.AddTransient<IBorrowService, BorrowService>();
            services.AddTransient<IPublicationRepository, PublicationRepository>();
            services.AddTransient<IFriendRepository, FriendRepository>();
            services.AddTransient<IBorrowRepository, BorrowRepository>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddSingleton<DatabaseSeeder>();

            
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Academic research manager API reference",
                    Description = "Describe me!",
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ArmDbContext>();
                //Create the database
                if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                {
                    context.Database.Migrate();
                    context.UpdateRatingForAllPublications();
                    context.SaveChanges();
                }
            }
            
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Academic research manager API reference");
                c.RoutePrefix = String.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.ConfigureExceptionHandler();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

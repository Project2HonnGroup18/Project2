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
using Microsoft.Extensions.Options;
using TechnicalRadiation.WebApi.Extensions;
using AcademicReferenceManager.Models.Database;

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
            services.AddTransient<IFriendService, FriendService>();
            services.AddTransient<IPublicationService, PublicationService>();
            services.AddTransient<IBorrowService, BorrowService>();
            services.AddTransient<IPublicationRepository, PublicationRepository>();
            services.AddTransient<IFriendRepository, FriendRepository>();
            services.AddSingleton<IBorrowRepository, BorrowRepository>();
            services.AddSingleton<IFriendDbContext, FriendDbContext>();
            services.AddSingleton<IPublicationDbContext, PublicationDbContext>();
            services.AddSingleton<IPublicationToFriendDbContext, PublicationToFriendDbContext>();

            // requires using Microsoft.Extensions.Options
            services.Configure<ArmDatabaseSettings>(
                Configuration.GetSection(nameof(ArmDatabaseSettings)));

            services.AddSingleton<IArmDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ArmDatabaseSettings>>().Value);

            services.AddSingleton<NewFriendService>();
            services.AddTransient<INewFriendService, NewFriendService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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

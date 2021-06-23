using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyOnionApi.Application;
using MyOnionApi.Infrastructure.Persistence;
using MyOnionApi.Infrastructure.Persistence.Contexts;
using MyOnionApi.Infrastructure.Shared;
using MyOnionApi.WebApi.Extensions;
using Serilog;

namespace MyOnionApi.WebApi
{
    public class Startup
    {
        private IConfiguration Config { get; }

        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationLayer();
            services.AddPersistenceInfrastructure(Config);
            services.AddSharedInfrastructure(Config);
            services.AddSwaggerExtension();
            services.AddControllersExtension();

            // CORS
            services.AddCorsExtension();
            services.AddHealthChecks();

            // API version
            services.AddApiVersioningExtension();

            // API explorer
            services.AddMvcCore()
                .AddApiExplorer();

            // API explorer version
            services.AddVersionedApiExplorerExtension();
        }

        // ReSharper disable once UnusedMember.Global
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, ApplicationDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            dbContext.Database.EnsureCreated();

            // Add this line; you'll need `using Serilog;` up the top, too
            app.UseSerilogRequestLogging();
            loggerFactory.AddSerilog();
            app.UseHttpsRedirection();
            app.UseRouting();

            //Enable CORS
            app.UseCors("AllowAll");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwaggerExtension();
            app.UseErrorHandlingMiddleware();
            app.UseHealthChecks("/health");
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
using CondominiumManagerApi.Core.Entities.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using CondominiumManagerApi.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace CondominiumManagerApi.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            builder.Configuration
             .SetBasePath($"{Directory.GetCurrentDirectory()}/WebApi")
             .AddJsonFile($"appsettings.{enviroment}.json", optional: false, reloadOnChange: true);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CondominiumManagement API", Version = "v1" });
            });

            builder.Services.AddScoped(serviceProvider =>
            {
                return new SqlSettings(builder.Configuration["SqlServer:ConnectionString"]);
            });

            builder.Services.AddRepositories();
            builder.Services.AddServices();

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CondominiumManagement API v1");
            });
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
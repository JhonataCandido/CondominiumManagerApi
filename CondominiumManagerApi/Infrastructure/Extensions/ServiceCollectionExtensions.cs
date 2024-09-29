using CondominiumManagerApi.Infrastructure.SqlServer.Repositories.Interfaces;
using CondominiumManagerApi.Infrastructure.SqlServer.Repositories;
using CondominiumManagerApi.Application.Services.CondominiumService;

namespace CondominiumManagerApi.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICondominiumRepository, CondominiumRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICondominiumService, CondominiumService>();
        }
    }
}
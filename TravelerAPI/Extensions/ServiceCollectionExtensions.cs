using Microsoft.EntityFrameworkCore;
using TravelerAPI.Data.Repositories;
using TravelerAPI.Exceptions;

namespace TravelerAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Database"));
            });

            services.AddScoped<ITravelPlanRepository, TravelPlanRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();

            services.AddExceptionHandler<CustomExceptionHandler>();

            return services;
        }
    }
}

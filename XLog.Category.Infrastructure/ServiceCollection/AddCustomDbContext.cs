using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XLog.Category.Infrastructure.Persistence;

namespace XLog.Category.Infrastructure.ServiceCollection
{
    public static class CustomServiceCollectionExtenstion
    {
        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseOracle(connectionString
                //providerOptions => providerOptions.EnableRetryOnFailure()
                ));
            return services;
        }
    }
}

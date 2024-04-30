using Catalog.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{
    public static class CatalogInfrastructureDepencyInjection
    {
        public static IServiceCollection AddCatalogInfrastructureDepencyInjection(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<CatalogDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseNpgsql("Con");
            });

            return services;
        }
    }
}

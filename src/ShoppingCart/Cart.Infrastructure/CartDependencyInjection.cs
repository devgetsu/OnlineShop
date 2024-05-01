using Cart.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart.Infrastructure
{
    public static class CartDependencyInjection
    {
        public static IServiceCollection AddCartDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CartDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseNpgsql(configuration.GetConnectionString(""));
            });
            return services;
        }
    }
}

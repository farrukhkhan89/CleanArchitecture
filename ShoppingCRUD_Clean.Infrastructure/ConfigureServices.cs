using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCRUD_Clean.Domain.Repository;
using ShoppingCRUD_Clean.Infrastructure.Data;
using ShoppingCRUD_Clean.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ShoppingCRUD_Clean.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices
             (this IServiceCollection services, IConfiguration configuration)

        {
            services.AddDbContext<ShoppingDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("ShoppingDbContext") ??
                    throw new InvalidOperationException("connection string 'ShoppingDbContext not found '"))
            );

            services.AddTransient<IShoppingListRepository, ShoppingListRepository>();
            return services;

        }

    }
}

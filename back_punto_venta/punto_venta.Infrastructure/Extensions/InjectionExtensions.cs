using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using punto_venta.Infrastructure.Persistence.Contexts;
using punto_venta.Infrastructure.Persistence.Interfaces;
using punto_venta.Infrastructure.Persistence.Repositories;

namespace punto_venta.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(DbPuntoVentaContext).Assembly.FullName;
            services.AddDbContext<DbPuntoVentaContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("DbPuntoVentaConection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;


        }
    }
}

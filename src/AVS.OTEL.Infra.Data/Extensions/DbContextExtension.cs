using AVS.OTEL.Infra.Data.Constants;
using AVS.OTEL.Infra.Data.Contexts;
using AVS.OTEL.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AVS.OTEL.Infra.Data.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration
                .GetConnectionString(
                    ContextConstants.CONNECTION_STRING_DEFAULT
                ) ?? throw new InvalidOperationException(ContextConstants.MSG_ERROR_CONN_STRING_NOT_FOUND);
            services.AddSingleton<DapperContext>();
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(
                    connectionString, 
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                )
            );

            return services;
        }

        public static void UseSeedDataDapperService(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<DapperContext>();
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            var categoryRepository = new CategoryRepository(context);
            var categories = categoryRepository.GetAll();

            var userRepository = new UserRepository(context);
            var user = userRepository.Authenticate("Alex", "123456");
            
        }

        public static void UseSeedDataService(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            var discountRepository = new DiscountRepository(context);
            var discount = discountRepository.GetAllAsync(CancellationToken.None).ConfigureAwait(false);          

        }
    }
}

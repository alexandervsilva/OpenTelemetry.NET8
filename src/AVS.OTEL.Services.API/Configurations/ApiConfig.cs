using AVS.OTEL.Services.API.Constants;
using System.Reflection;

namespace AVS.OTEL.Services.API.Configurations
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, WebApplicationBuilder builder) 
        {
            services.AddControllers();

            services.AddCors(opt =>
                    opt.AddPolicy(
                        ContextConstants.CORS_TOTAL, 
                        builder => builder.AllowAnyOrigin()
                                          .AllowAnyMethod()
                                          .AllowAnyHeader()
                    )
            );  
            
            builder.Configuration
                .SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}", true, true)
                .AddEnvironmentVariables();
            
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            if (builder.Environment.IsProduction())
                builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), true);
        }
    }
}

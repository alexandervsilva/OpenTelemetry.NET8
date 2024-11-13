
using AVS.OTEL.Infra.Data.Extensions;
using AVS.OTEL.Services.API.Configurations;
using AVS.OTEL.Services.API.Constants;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace AVS.OTEL.Services.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddApiConfiguration(builder);
            builder.Services.AddPersistenceService(builder.Configuration);            
           
            var app = builder.Build();
           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                //app.UseSeedDataDapperService();
                //app.UseSeedDataService();
            }

            var supportedCultures = new[] { new CultureInfo(ContextConstants.CULTURE_INFO_PTBR) };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ContextConstants.CULTURE_INFO_PTBR),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();

            app.UseCors(ContextConstants.CORS_TOTAL);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

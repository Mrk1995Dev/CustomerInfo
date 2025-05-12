using ApplicationService;
using ApplicationService.Location.Contract;
using ApplicationService.User.Contract;
using ApplicationService.User.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;

namespace Infrastructure.Configurations
{
    public static class ConfigureService
    {
        public static IServiceCollection ConfigureAllServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDataBaseConfigService(configuration)
                .AddBuissinessConfigService(configuration);

            return services;
        }

        public static IServiceCollection AddDataBaseConfigService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:SqlServer"];
            services.AddDbContext<DataBaseContext>(optionsAction => optionsAction.UseSqlServer(connectionString));
            services.AddScoped<IDataBaseContext, DataBaseContext>();

            return services;
        }

        public static IServiceCollection AddBuissinessConfigService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICustomerManagmentService, CustomerManagmentService>();
            services.AddTransient<ICityService, CityService>();
            return services;
        }
    }
}

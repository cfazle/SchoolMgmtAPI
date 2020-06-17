using Microsoft.Extensions.DependencyInjection;
using LoggerService;
using Contracts;

namespace SchoolAPI.Extension
{
    public  static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }
}

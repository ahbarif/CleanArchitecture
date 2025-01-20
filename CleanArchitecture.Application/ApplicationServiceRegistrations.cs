using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Application
{
    public static class ApplicationServiceRegistrations
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(typeof(Startup));

            return services;
        }
    }
}
 
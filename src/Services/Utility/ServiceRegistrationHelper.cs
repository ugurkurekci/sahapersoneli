using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Services.Utility;

public static class ServiceRegistrationHelper
{

    public static IServiceCollection AddAllServices(this IServiceCollection services, Assembly assembly)
    {

        var types = assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract)
            .ToList();

        foreach (var implementationType in types)
        {
            var serviceType = implementationType.GetInterfaces().FirstOrDefault();
            if (serviceType != null)
            {
                services.AddScoped(serviceType, implementationType);
            }
        }

        return services;

    }

}
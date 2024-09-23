using Entity.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using Services.Utility;
using System.Reflection;

namespace Services.Dl;

public static class DependencyInjection
{

    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {

        services.AddDbContext<ProjectDbContext>();

        services.AddAllServices(Assembly.GetExecutingAssembly());

        return services;

    }

}
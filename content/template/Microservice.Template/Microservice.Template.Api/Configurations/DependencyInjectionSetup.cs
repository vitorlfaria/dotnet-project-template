using Microservice.Template.Infrasctructure.Ioc;

namespace Microservice.Template.Api;

public static class DependencyInjectionSetup
{
    public static void AddDependencyInjectionSetup(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        DependencyInjectionContainer.RegisterServices(services);
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace DynamicDataApi;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataApiBuilder(this IServiceCollection services)
    {
        return services;
    }
}

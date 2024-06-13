using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddClient(this IServiceCollection service)
    {
        service.AddSingleton(
    }
}

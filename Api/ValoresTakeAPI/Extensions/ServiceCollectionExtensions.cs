using Infrastructure.Api;
using Microsoft.Extensions.DependencyInjection;
using RestEase;

namespace Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddClient(this IServiceCollection service)
    {
        service.AddSingleton(RestClient.For<IGithubClient>("https://api.github.com"));
    }
}

using Domain.Entities;
using RestEase;

namespace Infrastructure.Api;

[Header("User-Agent", "Valores.Take.API")]
public interface IGithubClient
{
    [Get("/orgs/takenet/repos?sort=created&direction=asc&language=C%23")]
    Task<List<GithubResponse>> GetOldestCsharpReposAsync();
}

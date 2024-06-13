using Domain.Entities;
using RestEase;

namespace Infrastructure.Api;

public interface IGithubClient
{
    [Header("Authorization")]
    public string Authorization { get; set; }

    [Get("/orgs/takenet/repos?sort=created&direction=asc&language=C%23")]
    Task<List<GithubResponse>> GetOldestCsharpReposAsync();
}

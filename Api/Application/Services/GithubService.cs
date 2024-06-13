using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Api;

namespace Application.Services;

public class GithubService : IGithubService
{
    private const string CSHARP = "C#";
    private const int FIRST_FIVE_REPOS = 5;
    private const int EMPTY_VALUE = 0;

    private readonly IGithubClient _githubClient;

    public GithubService(IGithubClient githubClient)
    {
        _githubClient = githubClient;
    }

    public async Task<List<GithubResponse>> GetFiveOldestCsharpReposAsync()
    {
        var response = await _githubClient.GetOldestCsharpReposAsync();
        if (response.Count == EMPTY_VALUE)
        {
            return [];
        }
        return response.Where(x => x.Language != null && x.Language.Equals(CSHARP)).Take(FIRST_FIVE_REPOS).ToList();
    }
}

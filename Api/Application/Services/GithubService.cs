using Domain.Entities;
using Domain.Interfaces;
using Domain.Settings;
using Infrastructure.Api;

namespace Application.Services;

public class GithubService : IGithubService
{
    private const string CSHARP = "C#";
    private const int FIRST_FIVE_REPOS = 5;
    private const int EMPTY_VALUE = 0;

    private readonly IGithubClient _githubClient;
    private readonly CustomSettings _settings;

    public GithubService(IGithubClient githubClient, CustomSettings settings)
    {
        _githubClient = githubClient;
        _settings = settings;
    }

    public async Task<List<GithubResponse>> GetFiveOldestCsharpReposAsync()
    {
        _githubClient.Authorization = _settings.GithubAuthorization;
        var response = await _githubClient.GetOldestCsharpReposAsync();
        if (response.Count == EMPTY_VALUE)
        {
            return [];
        }
        return response.Where(x => x.Language.Equals(CSHARP)).Take(FIRST_FIVE_REPOS).ToList();
    }
}
